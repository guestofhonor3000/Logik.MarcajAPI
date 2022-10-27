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


        public List<CDineInTableAndEmpModel> Get(int dineInTableGroupID, string type)
        {
            using (dbelogikEntities en = new dbelogikEntities())
            {
                en.Configuration.ProxyCreationEnabled = false;

                var returnList = new List<CDineInTableAndEmpModel>();

                List<DineInTable> lst = new List<DineInTable>();
                if (type == "all")
                {
                    lst = en.DineInTables.Where(x => x.TableGroupID == dineInTableGroupID).ToList();

                }
                else if (type == "active")
                {
                    lst = en.DineInTables.Where(x => x.TableGroupID == dineInTableGroupID && x.DineInTableInActive == true).ToList();
                }
                foreach (var dine in lst)
                {
                    var model = new CDineInTableAndEmpModel();
                    model.DineIn = dine;
                    returnList.Add(model);
                }

                /*foreach(var item in returnList)
                {
                    var oH = en.OrderHeaders.Where(x => x.DineInTableID == item.DineIn.DineInTableID).OrderByDescending(x => x.OrderID).FirstOrDefault();
                    if(oH != null)
                    {
                        if (oH.OrderStatus == "1")
                        {
                            item.Opened = true;
                        }
                        else
                        {
                            item.Opened = false;
                        }
                    }
                    else
                    {
                        item.Opened = false;
                    }
                }*/

                foreach (var item in returnList)
                {
                    var id = GetId(item.DineIn.DineInTableID);
                    var opened = GetStatus(item.DineIn.DineInTableID);
                    Debug.WriteLine(id);
                    try
                    {
                        item.Opened = opened;
                        var b = en.EmployeeFiles.Where(x => x.EmployeeID == id).ToList();
                        if (b.Count != 0)
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

        public List<DineInTable> Get(int dineInTableGroupID)
        {
            using(dbelogikEntities en = new dbelogikEntities())
            {
                en.Configuration.ProxyCreationEnabled = false;

                var a = en.DineInTables.Where(x => x.TableGroupID == dineInTableGroupID && x.DineInTableInActive==true).ToList();
                return a;
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

        public bool GetStatus(int id)
        {
            using (dbelogikEntities en = new dbelogikEntities())
            {
                var a = en.OrderHeaders.Where(x => x.DineInTableID == id).OrderByDescending(x => x.OrderID).FirstOrDefault();
                if(a!=null)
                {
                    if (a.OrderStatus == "1")
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
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
