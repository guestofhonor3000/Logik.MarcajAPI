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

        public List<DineInTable> Get(int dineInTableGroupID)
        {
            using (dbelogikEntities en = new dbelogikEntities())
            {
                en.Configuration.ProxyCreationEnabled = false;

                var a = en.DineInTables.Where(x => x.TableGroupID == dineInTableGroupID && x.DineInTableInActive == true).ToList();
                return a;
            }
        }
        public List<CDineInTableAndEmpModel> Get(int dineInTableGroupID, string type)
        {
            using (dbelogikEntities en = new dbelogikEntities())
            {
                en.Configuration.ProxyCreationEnabled = false;

                var listRet = new List<CDineInTableAndEmpModel>();

                List<DineInTable> lst = new List<DineInTable>();
                if (type == "all")
                {
                    lst = en.DineInTables.Where(x => x.TableGroupID == dineInTableGroupID).ToList();

                }
                else if (type == "active")
                {
                    lst = en.DineInTables.Where(x => x.TableGroupID == dineInTableGroupID && x.DineInTableInActive == true).ToList();
                }

                var result = from m1 in en.OrderHeaders.ToList()
                             join m2 in lst on m1.DineInTableID equals m2.DineInTableID
                             select new { m1.EmployeeID, m2 } into intermediate
                             join m3 in en.EmployeeFiles.ToList() on intermediate.EmployeeID equals m3.EmployeeID
                             select new CDineInTableAndEmpModel {EmpName=m3.FirstName, DineIn=intermediate.m2, Opened = intermediate.m2.OrderHeaders.OrderByDescending(x=>x.OrderDateTime).FirstOrDefault().OrderStatus=="1" ? true : false, TimeOpened = intermediate.m2.OrderHeaders.OrderByDescending(x=> x.OrderDateTime).FirstOrDefault().OrderDateTime.AddHours(2)};           
                var returnList = new List<CDineInTableAndEmpModel>();

                foreach(var l in lst)
                {
                    if(result.Where(x=> x.DineIn.DineInTableID  == l.DineInTableID).ToList().Count == 0)
                    {
                        var model = new CDineInTableAndEmpModel();
                        model.DineIn = l;
                        model.Opened = false;
                        model.TimeOpened = DateTime.MinValue;
                        model.EmpName = "";
                        returnList.Add(model);
                    }    
                }
                foreach(var res in result)
                {
                    returnList.Add(res);
                }

                return returnList;
            }
        }
      
        public HttpResponseMessage Put([FromBody] DineInTable item, int id, string type)
        {
            try
            {
                using (dbelogikEntities en = new dbelogikEntities())
                {
                    var a = en.DineInTables.FirstOrDefault(x => x.DineInTableID == id);

                    if (type == "status")
                    {
                        if (a.DineInTableInActive == true)
                        {
                            a.DineInTableInActive = false;
                        }
                        else
                        {
                            a.DineInTableInActive = true;
                        }
                    }
                    else if (type == "position")
                    {
                        a.DisplayPosition = item.DisplayPosition;
                    }



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
                using (dbelogikEntities en = new dbelogikEntities())
                {
                    en.DineInTables.Add(item);
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
        public HttpResponseMessage Put([FromBody] List<DineInTable> items)
        {
            try
            {
                using(dbelogikEntities en = new dbelogikEntities())
                {
                    foreach(var item in items)
                    {
                        var a = en.DineInTables.FirstOrDefault(x => x.DineInTableID == item.DineInTableID);
                        a.Booth = item.Booth;
                        a.Window = item.Window;
                        a.Smoking = item.Smoking;
                        a.DisplayPosition = item.DisplayPosition;
                        en.SaveChanges();
                    }
                    var message = Request.CreateResponse(HttpStatusCode.Created, items);
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
