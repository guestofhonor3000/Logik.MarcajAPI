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

        public HttpResponseMessage Delete(int id)
        {
            try
            {
                using (dbelogikEntities entities = new dbelogikEntities())
                {
                    var entity = entities.DineInTableGroups.FirstOrDefault(e => e.TableGroupID == id);
                    if (entity == null)
                    {
                        return Request.CreateErrorResponse(HttpStatusCode.NotFound,
                            "Group Table with ID = " + id.ToString() + " not found to delete");
                    }
                    else
                    {
                        var dineIns = entities.DineInTables.Where(x => x.TableGroupID == entity.TableGroupID).ToList();
                        List<DineInTable> ids = new List<DineInTable>();

                        foreach (var dineIn in dineIns)
                        {
                            ids.Add(dineIn);
                        }

                        foreach (var idd in ids)
                        {
                            entities.DineInTables.Remove(idd);
                        }
                        entities.DineInTableGroups.Remove(entity);
                        entities.SaveChanges();
                        return Request.CreateResponse(HttpStatusCode.OK);
                    }
                }
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }
        [HttpPost]
        public HttpResponseMessage Post([FromBody] DineInTableGroup item)
        {
            try
            {
                using (dbelogikEntities en = new dbelogikEntities())
                {
                    en.DineInTableGroups.Add(item);
                    en.SaveChanges();

                    var message = Request.CreateResponse(HttpStatusCode.Created, item);
                    message.Headers.Location = new Uri(Request.RequestUri + item.TableGroupID.ToString());
                    return message;
                }
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
        public HttpResponseMessage Put([FromBody] DineInTableGroup item, int id)
        {
            try
            {
                using (dbelogikEntities en = new dbelogikEntities())
                {
                    var a = en.DineInTableGroups.FirstOrDefault(x => x.TableGroupID == id);
                    if (item.TableGroupText == "" || item.TableGroupText == null)
                    {
                        if (item.GridSize != null)
                        {
                            a.GridSize = item.GridSize;
                        }
                    }
                    else
                    {
                        a.TableGroupText = item.TableGroupText;
                    }

                    en.SaveChanges();
                    var message = Request.CreateResponse(HttpStatusCode.Created, item);
                    message.Headers.Location = new Uri(Request.RequestUri + item.TableGroupID.ToString());
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
