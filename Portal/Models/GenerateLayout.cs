using Clinic.Database;

public static class GenerateLayout
{
  public static LayoutViewModel GenerateLayoutViewModel(AppDbContext context)
  {
    var texts = context.Texts.ToList();

    var pageTitle = texts.FirstOrDefault(t => t.Key == "menu_title").Content;

    var links = new List<MenuLink>
    {
      new MenuLink { Link = "/", Title = texts.FirstOrDefault(t => t.Key == "menu_link_1").Content },
      new MenuLink { Link = "/aboutus", Title = texts.FirstOrDefault(t => t.Key == "menu_link_2").Content},
      new MenuLink { Link = "/doctors", Title = texts.FirstOrDefault(t => t.Key == "menu_link_3").Content},
      new MenuLink { Link = "/services", Title = texts.FirstOrDefault(t => t.Key == "menu_link_4").Content },
      new MenuLink { Link = "/contact", Title = texts.FirstOrDefault(t => t.Key == "menu_link_5").Content}
      };

    var myAccountText = texts.FirstOrDefault(t => t.Key == "menu_link_6").Content;

    return new LayoutViewModel
    {
      PageTitle = pageTitle,
      Links = links,
      MyAccountText = myAccountText
    };
  }
}
