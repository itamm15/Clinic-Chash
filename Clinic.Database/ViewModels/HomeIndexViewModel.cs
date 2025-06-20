using Clinic.Database;

public class HomeIndexViewModel
{
    public List<Patient> Patients { get; set; }
    public List<Doctor> Doctors { get; set; }
    public VisitsSummary Visits { get; set; }
}

public class VisitsSummary
{
    public List<int> Label { get; set; }
    public List<int> Data { get; set; }
}
