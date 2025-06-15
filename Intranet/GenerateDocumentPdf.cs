using QuestPDF.Fluent;

public class GenerateDocumentPdf
{
  public static byte[] Run(Clinic.Database.Document document)
  {
    var pdf = Document.Create(container =>
    {
      container.Page(page =>
      {
        page.Margin(40);
        page.Header().Text("Przychodnia Switałka").FontSize(20).Bold();
        page.Content().Column(col =>
        {
            col.Spacing(10);
            col.Item().Text($"Tytuł: {document.Title}");
            col.Item().Text($"Opis: {document.Description}");
            col.Item().Text($"Data utworzenia: {document.CreatedAt:yyyy-MM-dd}");
        });
        page.Footer().AlignCenter().Text($"Wygenerowano: {DateTime.Now:yyyy-MM-dd HH:mm}");
      });
    });

    return pdf.GeneratePdf();
  }
}
