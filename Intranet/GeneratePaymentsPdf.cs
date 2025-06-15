using QuestPDF.Fluent;
using Clinic.Database;

public class GeneratePaymentsPdf
{
    public static byte[] Run(List<Payment> payments)
    {
        var pdf = QuestPDF.Fluent.Document.Create(container =>
        {
            container.Page(page =>
            {
                page.Margin(40);
                page.Header().Text("Lista płatności").FontSize(18).Bold();

                page.Content().Column(col =>
                {
                    col.Item().Text($"Liczba płatności: {payments.Count}");

                    foreach (var payment in payments)
                    {
                        col.Item().Text($"Pacjent: {payment.Patient?.FirstName } {payment.Patient?.LastName}");
                        col.Item().Text($"Opis: {payment.Description}");
                        col.Item().Text($"Kwota: {payment.Amount} zł");
                        col.Item().Text($"Data: {payment.PaymentDate:yyyy-MM-dd}");
                        col.Item().Text("------------------------------");
                    }
                });

                page.Footer().AlignCenter().Text($"Wygenerowano: {DateTime.Now:yyyy-MM-dd HH:mm}");
            });
        });

        return pdf.GeneratePdf();
    }
}
