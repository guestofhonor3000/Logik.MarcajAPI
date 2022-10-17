using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DataAccess;
using MarcajAPI.Models;
using System.Threading;

namespace MarcajAPI.Controllers
{
    public class DineInTablesController : ApiController
    {
        public List<DineInTable> Get()
        {
            using(dbelogikEntities en = new dbelogikEntities())
            {
                en.Configuration.ProxyCreationEnabled = false;
                var dineInTables = en.DineInTables.ToList();
                return dineInTables;
            }
        }

       
        public List<CDineInTableAndEmpModel> Get(int dineInTableGroupID)
        {
            using (dbelogikEntities en = new dbelogikEntities())
            {
                en.Configuration.ProxyCreationEnabled = false;

                var returnList = new List<CDineInTableAndEmpModel>();
                
                var  lst = en.DineInTables.Where(x => x.TableGroupID == dineInTableGroupID).ToList();
                foreach(var dine in lst)
                {
                    var model = new CDineInTableAndEmpModel();
                    model.DineIn = dine;
                    returnList.Add(model);

                }
                
                foreach(var item in returnList)
                {
                    var id = GetId(item.DineIn.DineInTableID);
                    Debug.WriteLine(id);
                    try
                    {
                        var b = en.EmployeeFiles.Where(x => x.EmployeeID == id).ToList();
                        if(b.Count!=0)
                        {
                            item.EmpName = b[0].FirstName;
                        }
                    }
                    catch
                    {

                    }
                }
                return returnList;
             
            }

        }

        public int GetId(int id)
        {
            using(dbelogikEntities en = new dbelogikEntities())
            {
                var a = en.OrderHeaders.Where(x => x.DineInTableID == id).OrderByDescending(x => x.OrderID).FirstOrDefault();
                if(a != null)
                {
                    return a.EmployeeID;
                }
                else
                {
                    return -1;
                }
            }
        }
        public HttpResponseMessage Put([FromBody] DineInTable item, int id)
        {
            try
            {
                using (dbelogikEntities en = new dbelogikEntities())
                {
                    var a = en.DineInTables.FirstOrDefault(x => x.DineInTableID == id);

                    a.DineInTableInActive = item.DineInTableInActive;


                    en.SaveChanges();
                    var message = Request.CreateResponse(HttpStatusCode.Created, item);
                    message.Headers.Location = new Uri(Request.RequestUri + item.DineInTableID.ToString());
                    return message;
                }
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        [HttpPost]
        public HttpResponseMessage Post([FromBody] DineInTable item)
        {
            try
            {
                using(dbelogikEntities en = new dbelogikEntities())
                {
                    en.DineInTables.Add(item);
                    en.SaveChanges();

                    var message = Request.CreateResponse(HttpStatusCode.Created, item);
                    message.Headers.Location = new Uri(Request.RequestUri + item.DineInTableID.ToString());
                    return message;
                }
            }
            catch(Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
    }
}
