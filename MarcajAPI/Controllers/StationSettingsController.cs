using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DataAccess;

namespace MarcajAPI.Controllers
{
    public class StationSettingsController : ApiController
    {
        
        public StationSetting Get(string stationName)
        {
            using (dbelogikEntities en = new dbelogikEntities())
            {
                en.Configuration.ProxyCreationEnabled = false;
                var station = en.StationSettings.Where(x => x.ComputerName == stationName).FirstOrDefault();
                return station;
            }
        }

        [HttpPost]
        public HttpResponseMessage Post([FromBody] StationSetting item)
        {
            try
            {
                using (dbelogikEntities en = new dbelogikEntities())
                {
                    en.StationSettings.Add(item);
                    en.SaveChanges();

                    var message = Request.CreateResponse(HttpStatusCode.Created, item);
                    message.Headers.Location = new Uri(Request.RequestUri + item.StationID.ToString());
                    return message;
                }
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

    }
}
