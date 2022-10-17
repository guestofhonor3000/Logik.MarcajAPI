using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DataAccess;

namespace MarcajAPI.Controllers
{
    public class MenuGroupsController : ApiController
    {
        public List<MenuGroup> Get()
        {
            using (dbelogikEntities en = new dbelogikEntities())
            {
                en.Configuration.ProxyCreationEnabled = false;
                var menuGroups = en.MenuGroups.ToList();
                return menuGroups;
            }
        }
    }
}
