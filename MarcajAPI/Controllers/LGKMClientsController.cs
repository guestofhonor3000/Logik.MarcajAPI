using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DataAccess;
using LGKDataAccess;

namespace MarcajAPI.Controllers
{
    public class LGKMClientsController : ApiController
    {
        public List<LGKMarcajClient> Get()
        {
            using(lgkdatabaseEntities en = new lgkdatabaseEntities())
            {
                en.Configuration.ProxyCreationEnabled = false;
                var a = en.LGKMarcajClients.ToList();
                return a;
            }
        }
    }
}
