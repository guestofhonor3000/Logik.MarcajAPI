using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DataAccess;
using System.Data.Entity;

namespace MarcajAPI.Controllers
{
    public class EmployeeFilesController : ApiController
    {
        public EmployeeFile Get(string securityCode)
        {
            using (dbelogikEntities en = new dbelogikEntities())
            {
                en.Configuration.ProxyCreationEnabled = false;
                var empFile = en.EmployeeFiles.Where(e => e.AccessCode == securityCode).FirstOrDefault();
                return empFile;
            }
        }

      
        public List<EmployeeFile> Get()
        {
            using (dbelogikEntities en = new dbelogikEntities())
            {
                en.Configuration.ProxyCreationEnabled = false;
                return en.EmployeeFiles.ToList();
            }
        }

       
        public int Get(int syncEmployee)
        {
            using (dbelogikEntities en = new dbelogikEntities())
            {
                int empId = 0;
                if (syncEmployee == 0)
                {
                    en.Configuration.ProxyCreationEnabled = false;
                    empId = en.EmployeeFiles.OrderByDescending(e => e.EmployeeID).FirstOrDefault().EmployeeID;
                }
                return empId;
            }
        }
        public HttpResponseMessage Put([FromBody] EmployeeFile item, int id)
        {
            try
            {
                using (dbelogikEntities en = new dbelogikEntities())
                {

                    var a = en.EmployeeFiles.FirstOrDefault(x => x.EmployeeID == id);

                    a.FirstName = item.FirstName;
                    a.LastName = item.LastName;
                    a.AccessCode = item.AccessCode;
                    a.SecurityLevel = item.SecurityLevel;

                    en.SaveChanges();

                    var message = Request.CreateResponse(HttpStatusCode.Created, item);
                    message.Headers.Location = new Uri(Request.RequestUri + item.EmployeeID.ToString());
                    return message;
                }
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        [HttpPost]
        public HttpResponseMessage Post([FromBody] List<EmployeeFile> modelList)
        {
            try
            {
                HttpResponseMessage message = null;
                using (dbelogikEntities en = new dbelogikEntities())
                {
                    foreach (var model in modelList)
                    {
                        en.EmployeeFiles.Add(model);
                        en.SaveChanges();
                        message = Request.CreateResponse(HttpStatusCode.Created, model);
                        message.Headers.Location = new Uri(Request.RequestUri + model.EmployeeID.ToString());
                    }
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
