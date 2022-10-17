using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DataAccess;

namespace MarcajAPI.Controllers
{
    public class MenuItemsController : ApiController
    {
        public List<MenuItem> Get(int menuGroupID)
        {
            using (dbelogikEntities en = new dbelogikEntities())
            {
                en.Configuration.ProxyCreationEnabled = false;
                var menuItems = en.MenuItems.Where(x => x.MenuGroupID == menuGroupID).ToList();
                return menuItems;
            }
        }
        
        public List<MenuItem> Get()
        {
            using(dbelogikEntities en = new dbelogikEntities())
            {
                en.Configuration.ProxyCreationEnabled = false;
                var menuItems = en.MenuItems.ToList();
                return menuItems;
            }
        }
    }
}
