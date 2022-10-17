using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DataAccess;

namespace MarcajAPI.Controllers
{
    public class DineInTableGroupController : ApiController
    {
        public List<DineInTableGroup> Get()
        {
            using (dbelogikEntities en = new dbelogikEntities())
            {
                en.Configuration.ProxyCreationEnabled = false;
                var dineInTables = en.DineInTableGroups.ToList();
                return dineInTables;
            }
        }
    }
}
