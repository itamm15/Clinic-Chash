using Clinic.Database;

public class LayoutViewModel
{
  public string PageTitle { get; set; }
  public List<MenuLink> Links { get; set; }
  public string MyAccountText { get; set; }
  public List<Text> Texts { get; set; }
}

public class MenuLink
{
  public string Link { get; set; }
  public string Title { get; set; }
}
