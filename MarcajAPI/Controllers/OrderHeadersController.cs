using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Configuration;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DataAccess;


namespace MarcajAPI.Controllers
{
    
    public class OrderHeadersController : ApiController
    {

     
        public List<OrderHeader> Get()
        {
            using(dbelogikEntities en = new dbelogikEntities())
            {
                en.Configuration.ProxyCreationEnabled = false;

                var a = en.OrderHeaders.ToList();
                return a;
            }
        }

        [HttpPost]
        public HttpResponseMessage Post([FromBody] OrderHeader item)
        {
            try
            {
                using (dbelogikEntities en = new dbelogikEntities())
                {

                    try
                    {
                        var a = en.OrderHeaders.OrderByDescending(i => i.FacturaNumber).FirstOrDefault().FacturaNumber + 1;
                        item.FacturaNumber = a;
                    }
                    catch
                    {
                        item.FacturaNumber = 0;
                    }

                    en.OrderHeaders.Add(item);
                    en.SaveChanges();

                    var message = Request.CreateResponse(HttpStatusCode.Created, item);
                    message.Headers.Location = new Uri(Request.RequestUri + item.OrderID.ToString());
                    return message;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                Debug.WriteLine(ex.InnerException);
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }


        public List<OrderHeader> Get(int getID, string type)
        {
            using (dbelogikEntities en = new dbelogikEntities())
            {
                en.Configuration.ProxyCreationEnabled = false;
                var a = new List<OrderHeader>();
                if (type == "DineInTable")
                {
                    a = en.OrderHeaders.Where(x => x.DineInTableID == getID).Where(x => x.OrderStatus == "1").ToList();
                }
                else if (type == "OrderHeader")
                {
                    a = en.OrderHeaders.Where(x => x.OrderID == getID).ToList();
                }
                return a;
            }
        }
      
        public List<OrderHeader> Get(string sync, int empId)
        {
            using (dbelogikEntities en = new dbelogikEntities())
            {
                en.Configuration.ProxyCreationEnabled = false;
                var a = new List<OrderHeader>();
                if (sync == "Now")
                {
                    var b = en.OrderHeaders.Where(x => x.OrderDateTime > DbFunctions.AddDays(DateTime.Now, -2)).ToList();
                    a = b;
                }
                else if(sync =="No")
                {
                    var b = en.OrderHeaders.Where(x => x.OrderStatus == "1").OrderByDescending(x => x.OrderID).ToList();
                    a = b;
                }
                else if(sync == "Bar")
                {
                    var b = en.OrderHeaders.Where(x => x.BarOrder ==true && x.OrderStatus=="1").OrderByDescending(x => x.OrderID).ToList();
                    a = b;
                }
                else if(sync == "EmpLogged")
                {
                    var b = en.OrderHeaders.Where(x => x.EmployeeID == empId && x.OrderStatus == "1").OrderByDescending(x => x.OrderID).ToList();
                    a = b;
                }
                else if (sync == "Restaurant")
                {
                    var b = en.OrderHeaders.Where(x => x.BarOrder == false && x.OrderStatus == "1").OrderByDescending(x => x.OrderID).ToList();
                    a = b;
                }
                return a;
            }
        }
        public HttpResponseMessage Put([FromBody] OrderHeader item, int id, string type)
        {
            try
            {
                using (dbelogikEntities en = new dbelogikEntities())
                {

                    if(type == "synchver")
                    {
                        var a = en.OrderHeaders.FirstOrDefault(x => x.OrderID == id);
                        //a.EditTimestamp = item.OrderDateTime;
                        a.SynchVer = item.SynchVer;
                        en.SaveChanges();
                    }
                    if(type == "moveorder")
                    {
                        var a = en.OrderHeaders.FirstOrDefault(x => x.OrderID == id);
                        //a.EditTimestamp = item.OrderDateTime;
                        a.DineInTableID = item.DineInTableID;
                        en.SaveChanges();
                    }
                    if (type == "moveemp")
                    {
                        var a = en.OrderHeaders.FirstOrDefault(x => x.OrderID == id);
                        //a.EditTimestamp = item.OrderDateTime;
                        a.EmployeeID = item.EmployeeID;
                        en.SaveChanges();
                    }
                    var message = Request.CreateResponse(HttpStatusCode.Created, item);
                    message.Headers.Location = new Uri(Request.RequestUri + item.OrderID.ToString());
                    return message;
                }
            }
            catch (Exception ex)
            {                                                                     
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
        public HttpResponseMessage Put([FromBody] OrderHeader item, int id)
        {
            try
            {
                using (dbelogikEntities en = new dbelogikEntities())
                {

                    var a = en.OrderHeaders.FirstOrDefault(x => x.OrderID == id);
                    a.SynchVer = item.SynchVer;
                    a.AmountDue = item.AmountDue;
                    a.SubTotal = item.SubTotal;
                    a.OrderStatus = item.OrderStatus;
                    en.SaveChanges();

                    var message = Request.CreateResponse(HttpStatusCode.Created, item);
                    message.Headers.Location = new Uri(Request.RequestUri + item.OrderID.ToString());
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
