using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Web.Http;
using DataAccess;
using LGKDataAccess;

namespace MarcajAPI.Controllers
{
    public class LGKMClientsController : ApiController
    {
        List<OrderHeader> headers;
        string txt;
        public List<LGKMarcajClient> Get()
        {
            using(lgkdatabaseEntities en = new lgkdatabaseEntities())
            {
                en.Configuration.ProxyCreationEnabled = false;
                var a = en.LGKMarcajClients.ToList();
                return a;
            }
        }

        public string Get(string name)
        {
            using(lgkdatabaseEntities en = new lgkdatabaseEntities())
            {
                en.Configuration.ProxyCreationEnabled = false;
                var a = en.LGKMarcajClients.Where(x => x.ClientDbCode == name).FirstOrDefault();
                var ip = en.LGKLocations.Where(x=> x.NumeLocatie == a.ClientName).FirstOrDefault().IPs;
                var port = en.LGKLocations.Where(x => x.NumeLocatie == a.ClientName).FirstOrDefault().Port;
                string date = "RAPORTLOCAL \"" + "GETORDERS" + "\" \"" +"" + "\" \"" + "" + "\" \"" + a.ClientName + "\" ";
                StartClient(date,ip,port);
                return txt;
            }
        }

        void StartClient(string dateDeTrimis, string ipp, string port)
        {
            byte[] bytes = new byte[1024];

            try
            {
                string ipLocal = ipp;
                string portLocal = port;

                string[] ips = ipLocal.Split('.');
                byte[] ip = new byte[4];
                ip[0] = Convert.ToByte(ips[0]);
                ip[1] = Convert.ToByte(ips[1]);
                ip[2] = Convert.ToByte(ips[2]);
                ip[3] = Convert.ToByte(ips[3]);
              
                IPAddress ipAddress = new IPAddress(ip);
                IPEndPoint remoteEP = new IPEndPoint(ipAddress, Convert.ToInt32(portLocal));
                
                Socket sender = new Socket(ipAddress.AddressFamily,
                    SocketType.Stream, ProtocolType.Tcp);

                try
                {
                    sender.Connect(remoteEP);
                    
                    byte[] msg = Encoding.ASCII.GetBytes(dateDeTrimis + "<EOF>");

                    
                    int bytesSent = sender.Send(msg);

                    string text = "";
                    
                    while (true)
                    {
                        int bytesRec = sender.Receive(bytes);
                        text += Encoding.ASCII.GetString(bytes, 0, bytesRec);
                        if (text.IndexOf("<EOF>") > -1)
                        {
                            break;
                        }
                    }
                    txt = text;
                    sender.Shutdown(SocketShutdown.Both);
                    sender.Close();
                    
                    text = text.Replace(Environment.NewLine + "!XYZ", "");
                    text = text.Replace("<EOF>", "");


                    //OrderID;OrderDateTime;DineInTableID;AmountDue
                    if (text.Contains("GETORDERS"))
                    {
                        string[] ordersH = text.Split('#');

                        headers = new List<OrderHeader>();

                        foreach (var oH in ordersH)
                        {
                            string[] items = oH.Split(';');

                            if (items.Length > 1)
                            {
                                var model = new OrderHeader();
                                model.OrderID = Convert.ToInt32(items[0]);
                                model.OrderDateTime = Convert.ToDateTime(items[1]);
                                model.DineInTableID = Convert.ToInt32(items[2]);
                                model.AmountDue = Convert.ToSingle(items[3]);
                                headers.Add(model);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("1st Catch   " + ex.Message + "    " + ex.InnerException);
                    sender.Shutdown(SocketShutdown.Both);
                    sender.Close();
                    try
                    { 
                    }
                    catch (Exception) { }
                    return;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("2nd Catch   " + ex.InnerException);
                try
                { 
                }
                catch (Exception) { }
            }
        }
    }
}
