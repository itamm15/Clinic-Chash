public class CalendarViewModel
{
  public List<CalendarVisits> Visits { get; set; }
}

public class CalendarVisits
{
  public string title { get; set; }
  public DateTime start { get; set; }
  public DateTime end { get; set; }
}
