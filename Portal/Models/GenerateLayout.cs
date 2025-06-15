using Clinic.Database;

public static class GenerateLayout
{
  public static LayoutViewModel GenerateLayoutViewModel(AppDbContext context)
  {
    var texts = context.Texts.ToList();

    var pageTitle = texts.First(t => t.Key == "menu_title").Content;

    var links = new List<MenuLink>
    {
      new MenuLink { Link = "/", Title = texts.First(t => t.Key == "menu_link_1").Content },
      new MenuLink { Link = "/aboutus", Title = texts.First(t => t.Key == "menu_link_2").Content},
      new MenuLink { Link = "/doctors", Title = texts.First(t => t.Key == "menu_link_3").Content},
      new MenuLink { Link = "/services", Title = texts.First(t => t.Key == "menu_link_4").Content },
      new MenuLink { Link = "/contact", Title = texts.First(t => t.Key == "menu_link_5").Content}
      };

    var myAccountText = texts.First(t => t.Key == "menu_link_6").Content;

    return new LayoutViewModel
    {
      PageTitle = pageTitle,
      Links = links,
      MyAccountText = myAccountText,
      Texts = texts
    };
  }
}
