using Clinic.Database;

public class PortalHomeSpecsViewModel
{
  public string Name;
  public string Icon;
}

public class PortalHomeViewModel
{
  public List<PortalHomeSpecsViewModel> Specializations { get; set; }
  public List<Text> Texts { get; set; }
}
