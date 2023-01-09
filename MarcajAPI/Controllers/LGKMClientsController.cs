using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Web.Http;
using System.Xml.Linq;
using DataAccess;
using LGKDataAccess;

namespace MarcajAPI.Controllers
{
    public class LGKMClientsController : ApiController
    {
        List<OrderHeader> headers;
        string txt;
        string res;
        DateTime dataAcum
        {
            get
            {
                return DateTime.Now.AddHours(2);
            }
        }
        public List<LGKMarcajClient> Get()
        {
            using(lgkdatabaseEntities en = new lgkdatabaseEntities())
            {
                en.Configuration.ProxyCreationEnabled = false;
                var a = en.LGKMarcajClients.ToList();
                return a;
            }
        }

        public string Get(string name, string type)
        {
            using(lgkdatabaseEntities en = new lgkdatabaseEntities())
            {
                if(type=="OH")
                {
                    en.Configuration.ProxyCreationEnabled = false;
                    var a = en.LGKMarcajClients.Where(x => x.ClientDbCode == name).FirstOrDefault();
                    var ip = en.LGKLocations.Where(x => x.NumeLocatie == a.ClientName).FirstOrDefault().IPs;
                    var port = en.LGKLocations.Where(x => x.NumeLocatie == a.ClientName).FirstOrDefault().Port;
                    string date = "RAPORTLOCAL \"" + "GETORDERS" + "\" \"" + "" + "\" \"" + "" + "\" \"" + a.ClientName + "\" ";
                    StartClient(date, ip, port);
                    return txt;
                }
                else if(type=="FOCASH")
                {
                    en.Configuration.ProxyCreationEnabled = false;
                    string cname = name.Split('@')[0];
                    string ohname = name.Split('@')[1];
                    var a = en.LGKMarcajClients.Where(x => x.ClientDbCode == cname).FirstOrDefault();
                    var ip = en.LGKLocations.Where(x => x.NumeLocatie == a.ClientName).FirstOrDefault().IPs;
                    var port = en.LGKLocations.Where(x => x.NumeLocatie == a.ClientName).FirstOrDefault().Port;
                    string date = "RAPORTLOCAL \"" + "ORDERFINALISED" + "\" \"" + "" + "\" \"" + "" + "\" \"" + a.ClientName + "\" \"" + ohname + "\" \"" + "CASH"+ "\" ";
                    StartClient(date, ip, port);
                    return txt;
                    
                }
                else if (type == "FOCARD")
                {
                    en.Configuration.ProxyCreationEnabled = false;
                    string cname = name.Split('@')[0];
                    string ohname = name.Split('@')[1];
                    var a = en.LGKMarcajClients.Where(x => x.ClientDbCode == cname).FirstOrDefault();
                    var ip = en.LGKLocations.Where(x => x.NumeLocatie == a.ClientName).FirstOrDefault().IPs;
                    var port = en.LGKLocations.Where(x => x.NumeLocatie == a.ClientName).FirstOrDefault().Port;
                    string date = "RAPORTLOCAL \"" + "ORDERFINALISED" + "\" \"" + "" + "\" \"" + "" + "\" \"" + a.ClientName + "\" \"" + ohname + "\" \"" + "CARD" + "\" ";
                    StartClient(date, ip, port);
                    return txt;

                }
                else
                {
                    en.Configuration.ProxyCreationEnabled = false;
                    string cname = name.Split('@')[0];
                    string ohname = name.Split('@')[1];
                    var a = en.LGKMarcajClients.Where(x => x.ClientDbCode == cname).FirstOrDefault();
                    var ip = en.LGKLocations.Where(x => x.NumeLocatie == a.ClientName).FirstOrDefault().IPs;
                    var port = en.LGKLocations.Where(x => x.NumeLocatie == a.ClientName).FirstOrDefault().Port;
                    string date = "RAPORTLOCAL \"" + "GETORDERTRANSACTIONS" + "\" \"" + "" + "\" \"" + "" + "\" \"" + a.ClientName + "\" \"" + ohname + "\" ";
                    //   \""    + "\" "
                    StartClient(date, ip, port);
                    PostClient(txt);
                    return res;
                }
            }
        }

        public partial class CustomOrderTransaction
        {
            public OrderTransaction OT { get; set; }
            public string MenuItemText { get; set; }
        }
        void PostClient(string text)
        {
            string base_url = "https://sandbox-api.payosy.com";

            string[] mystrings = text.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            var newLst = new List<CustomOrderTransaction>();

            foreach(var str in mystrings)
            {
                try
                {
                    Debug.WriteLine(str);
                    var stringy = str.Split(';');
                    
                    var aa = new CustomOrderTransaction();
                    aa.OT = new OrderTransaction();
                   
                    aa.OT.OrderTransactionID = Convert.ToInt32(stringy[0]);
                    
                    aa.OT.MenuItemID = Convert.ToInt32(stringy[1]);
                    
                    aa.OT.MenuItemUnitPrice = Convert.ToSingle(stringy[2]);
                    
                    aa.OT.Quantity = Convert.ToInt32(stringy[3]);
                    
                    aa.OT.ExtendedPrice = Convert.ToSingle(stringy[4]);
                    
                    aa.MenuItemText = stringy[5];
                    
                    newLst.Add(aa);
                }
                catch(Exception ex)
                {
                    Debug.WriteLine("Thrown EX: "+ ex.Message);
                }
            }
  
            string ot_items ="";

            Single total = 0;

            foreach(var ot in newLst)
            {
                string ot_item = @"{
                                        ""name"":""" + ot.MenuItemText + @"""
                                        ""priceType"":0,
                                        ""price"":" + ot.OT.ExtendedPrice + @",
                                        ""taxPercent"":0,
                                        ""taxType"":0,
                                        ""quantityType"":""EX"",
                                        ""quantity"":" + ot.OT.Quantity + @"},";
                total += ot.OT.ExtendedPrice;
                ot_items += ot_item;
            }

            ot_items = ot_items.Remove(ot_items.Length - 1, 1);

            string ot_payment = @"{
                                            ""amount"":"+total+@",
                                            ""operationId"":0,
                                            ""type"":1,
                                            ""description"": ""CASH""
            }";
            
                        string req_string = @"
              --data '{
               ""terminalid"": ""EC0000000002"",
               ""id"": ""1213"",
               ""asyncACK"": false,
               ""isCopy"":0,
               ""typeCode"":0,
               ""note"":"" YİNE BEKLERİZ"",
               ""currencyCode"":0,
               ""basketID"":""1213"",
               ""taxTypeCode"":0,
               ""customerInfo"":{
                  ""taxID"":""99999999999"",
                  ""name"":""Mustafa Koray AKÇOCUK"",
                  ""isLock"":true,
                  ""room"":""1"",
                  ""street"":""Koray Akcocuk Cd."",
                  ""buildingName"":""Koray Binası"",
                  ""buildingNumber"":""16"",
                  ""citySubdivisonName"":""Alanya"",
                  ""cityName"":""Antalya"",
                  ""postalZone"":""07110"",
                  ""region"":""Güller Pınarı"",
                  ""country"":""Turkiye"",
                  ""taxScheme"":""Alanya"",
                  ""telephone"":""0 232 333 33 33"",
                  ""telefax"":""0 232 111 11 11"",
                  ""email"":""xxxx@xxxx.com""
               },
               ""items"":[
                  "+ ot_items + @"
               ],
               ""paymentItems"": [ 
                   "+ot_payment+@"
               ],
               ""adjust"":{
                  ""discountOrSurcharge"":0,
                  ""type"":0,
                  ""value"":50,
                  ""description"":""HOPI""
               }
            }'";

            res = req_string;
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
