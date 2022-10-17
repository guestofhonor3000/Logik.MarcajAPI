using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DataAccess;

namespace MarcajAPI.Controllers
{
    public class OrderTransactionsController : ApiController
    {
     
        public List<OrderTransaction> Get(int getOrderID)
        {
            using (dbelogikEntities en = new dbelogikEntities())
            {
                en.Configuration.ProxyCreationEnabled = false;
                var a = en.OrderTransactions.Where(x => x.OrderID == getOrderID).ToList();
                return a;
            }
        }



        [HttpPost]
        public HttpResponseMessage Post([FromBody] List<OrderTransaction> items, int getDineInTableID, string type)
        {
            try
            {
                using (dbelogikEntities en = new dbelogikEntities())
                {
                    HttpResponseMessage message = null;
                    if (type == "activetable")
                    {
                        int step = 0;
                        foreach (var item in items)
                        {
                            step++;
                            if (step == 1)
                            {
                                var itemsToRemove = en.OrderTransactions.Where(x => x.OrderID == item.OrderID);
                                foreach (var itemToRemove in itemsToRemove)
                                {
                                    en.OrderTransactions.Remove(itemToRemove);
                                }
                            }
                            en.OrderTransactions.Add(item);
                            en.SaveChanges();
                            message = Request.CreateResponse(HttpStatusCode.Created, item);
                            message.Headers.Location = new Uri(Request.RequestUri + item.OrderTransactionID.ToString());


                        }

                    }
                    else if (type == "notactivetable")
                    {
                        var a = en.OrderHeaders.Where(x => x.DineInTableID == getDineInTableID).OrderByDescending(x => x.OrderID).FirstOrDefault().OrderID;
                        foreach (var item in items)
                        {
                            item.OrderID = a;
                            en.OrderTransactions.Add(item);
                            en.SaveChanges();
                            message = Request.CreateResponse(HttpStatusCode.Created, item);
                            message.Headers.Location = new Uri(Request.RequestUri + item.OrderTransactionID.ToString());
                        }
                    }
                    else if (type == "sync")
                    {
                        foreach (var item in items)
                        {
                            en.OrderTransactions.Add(item);
                            en.SaveChanges();
                            message = Request.CreateResponse(HttpStatusCode.Created, item);
                            message.Headers.Location = new Uri(Request.RequestUri + item.OrderTransactionID.ToString());
                        }

                    }
                    return message;
                }
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }


        public List<OrderTransaction> Get([FromUri] int[] getOrderIDList)
        {
            using (dbelogikEntities en = new dbelogikEntities())
            {
                en.Configuration.ProxyCreationEnabled = false;
                var a = new List<OrderTransaction>();
                foreach (var goID in getOrderIDList)
                {
                    var b = en.OrderTransactions.Where(x => x.OrderID == goID).ToList();
                    foreach (var c in b)
                    {
                        a.Add(c);
                    }
                }
                return a;
            }
        }
    }
}
