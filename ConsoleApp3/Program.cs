using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        public override string ToString()
        {
            return base.ToString();
        }
        static void Main(string[] args)
        {
            List<Mod> lis = new List<Mod>();
            lis.Add(new Mod() { url = "uat.chinachemgroup.com/news/lifeplus-magazine", v = "{E3B852C4-667C-4DFC-AC3E-38AA353D5ED7}", s = "{2C118C30-95CE-4954-9A1D-7D9CDF2FEE44}", itemid = "{530173BB-A001-490A-8449-F57736858E85}" });
            lis.Add(new Mod() { url = "uat.chinachemgroup.com/zh-hk/news/multimedia-library", v = "{77E1E4D0-9032-447C-BB44-7BB4D9BB0C57}", s = "{DA7831B7-9C82-4775-A840-D917FB5E7A5D}", itemid = "{80B47EEC-768D-4710-8D95-4E5385BD4421}" });
            lis.Add(new Mod() { url = "uat.ninahotelgroup.com/en/nina-hotel-tsuen-wan-west-quarantine-hotel/rooms", v = "{E45D28C8-C99C-47A0-8B35-6992D95F0C10}", s = "{075F114A-F27E-453D-BF57-6BF2D63B398A}", itemid = "{954DBEBB-BE06-4F72-A7EB-EE637C7D12F5}" });
            lis.Add(new Mod() { url = "uat.ninahotelgroup.com/en/nina-hotel-tsuen-wan-west-quarantine-hotel/offers", v = "{87814536-0A8C-4BB3-9697-D5D729C6493C}", s = "{0FABB063-6F43-4995-A1CC-ED6D49FE4DEA}", itemid = "{7285E651-B066-43F0-83CE-BC34C8EE2B08}" });
            lis.Add(new Mod() { url = "uat.ninahotelgroup.com/en/nina-hotel-tsuen-wan-west-quarantine-hotel/news/awards-and-accolades", v = "{6A5DA596-7737-48C8-8C04-1C4D4C7404C3}", s = "{9DB9AC7C-4EB3-4F56-BA89-704807718BF9}", itemid = "{F7A5D9A2-1244-4CE4-A4D9-488475D9B789}" });
            lis.Add(new Mod() { url = "uat.ninahotelgroup.com/zh-hk/nina-hotel-tsuen-wan-west-quarantine-hotel/news/fact-sheet", v = "{6A5DA596-7737-48C8-8C04-1C4D4C7404C3}", s = "{8E0BB691-E861-4496-8F8F-9CB2D676B769}", itemid = "{84551981-B99D-46F3-B9A6-CBA8083C5153}" });
            lis.Add(new Mod() { url = "uat.ninahotelgroup.com/en/the-lily/news/fact-sheet", v = "{6A5DA596-7737-48C8-8C04-1C4D4C7404C3}", s = "{B07464F8-73A1-45B8-9327-9168DAE94361}", itemid = "{32440AE4-EEAF-4F25-ACE7-198BFDD63FA0}" });
            lis.Add(new Mod() { url = "uat.ninahotelgroup.com/en/nina-hotel-tsuen-wan-west/news/awards-and-accolades", v = "{6A5DA596-7737-48C8-8C04-1C4D4C7404C3}", s = "{9DB9AC7C-4EB3-4F56-BA89-704807718BF9}", itemid = "{8BA38D76-9D85-4623-91A6-52619ECD99E0}" });
            lis.Add(new Mod() { url = "uat.ninahotelgroup.com/zh-hk/nina-hotel-tsuen-wan-west/news/fact-sheet", v = "{6A5DA596-7737-48C8-8C04-1C4D4C7404C3}", s = "{8E0BB691-E861-4496-8F8F-9CB2D676B769}", itemid = "{2318C7E8-2F57-419D-9765-73D23AA8A43F}" });
            lis.Add(new Mod() { url = "cms-uat.ninahotelgroup.com/en/news/latest-news", v = "{E7227522-7763-4DD8-9A4B-45A235E21145}", s = "{34529749-70D4-423E-B81C-CE432758FC5E}", itemid = "{351E3247-8704-45EE-9BAD-44122C14D542}" });
            lis.Add(new Mod() { url = "cms-uat.ninahotelgroup.com/en/news/awards-and-accolades", v = "{6A5DA596-7737-48C8-8C04-1C4D4C7404C3}", s = "{37BAF10C-4C70-46E6-8E2F-6F746E20D1FB}", itemid = "{58CFFDE9-FCB4-4BB7-A16A-01DDABCDF0EB}" });
            lis.Add(new Mod() { url = "cms-uat.ninahotelgroup.com/en/news/multimedia-library", v = "{B8C402BC-47C7-430E-857C-82753F83D72E}", s = "{BBA3329B-5D9D-4C7A-A2B3-013CFE38DE8D}", itemid = "{B1EA85E9-56A3-4D23-A93B-9A1F92FE25D5}" });
            lis.Add(new Mod() { url = "cms-uat.ninahotelgroup.com/en/news/fact-sheet", v = "{6A5DA596-7737-48C8-8C04-1C4D4C7404C3}", s = "{0F474494-B282-439B-9CA7-2794F5745C9E}", itemid = "{AF08F23C-3274-4E36-A10A-620EB1B56F5A}" });
            lis.Add(new Mod() { url = "cms-uat.ninahotelgroup.com/zh-cn/nina-hotel-tsuen-wan-west-quarantine-hotel/news/latest-news", v = "{B4315740-8085-4B23-94B4-7AB716B7C0D5}", s = "{5BBDF308-0812-45DC-947E-6959FC57091A}", itemid = "{D4414188-B622-4D9D-A1E3-FF11D98E4D51}" });
            lis.Add(new Mod() { url = "cms-uat.ninahotelgroup.com/zh-hk/nina-hotel-tsuen-wan-west-quarantine-hotel/news/latest-news", v = "{B4315740-8085-4B23-94B4-7AB716B7C0D5}", s = "{34529749-70D4-423E-B81C-CE432758FC5E}", itemid = "{D4414188-B622-4D9D-A1E3-FF11D98E4D51}" });
            lis.Add(new Mod() { url = "cms-uat.ninahotelgroup.com/zh-cn/nina-hotel-tsuen-wan-west-quarantine-hotel/news/multimedia-library", v = "{B8C402BC-47C7-430E-857C-82753F83D72E}", s = "{A54DBE2E-3723-44DC-AD1A-70686E4854D1}", itemid = "{138BE07D-19E4-4708-A252-B1E6AD0A715D}" });
            lis.Add(new Mod() { url = "cms-uat.ninahotelgroup.com/zh-hk/nina-hotel-tsuen-wan-west-quarantine-hotel/news/multimedia-library", v = "{B8C402BC-47C7-430E-857C-82753F83D72E}", s = "{BBA3329B-5D9D-4C7A-A2B3-013CFE38DE8D}", itemid = "{138BE07D-19E4-4708-A252-B1E6AD0A715D}" });
            lis.Add(new Mod() { url = "cms-uat.ninahotelgroup.com/zh-hk/nina-hotel-island-south/news/latest-news", v = "{B4315740-8085-4B23-94B4-7AB716B7C0D5}", s = "{34529749-70D4-423E-B81C-CE432758FC5E}", itemid = "{4E20BF7E-8018-46E5-9AE8-28A21A81B223}" });
            lis.Add(new Mod() { url = "cms-uat.ninahotelgroup.com/zh-cn/nina-hotel-island-south/news/multimedia-library", v = "{B8C402BC-47C7-430E-857C-82753F83D72E}", s = "{9904B356-6FF4-4F6C-9126-85658A704577}", itemid = "{E278147F-BB66-49FD-A920-B78433D57146}" });
            lis.Add(new Mod() { url = "cms-uat.ninahotelgroup.com/zh-hk/nina-hotel-island-south/news/multimedia-library", v = "{B8C402BC-47C7-430E-857C-82753F83D72E}", s = "{BBA3329B-5D9D-4C7A-A2B3-013CFE38DE8D}", itemid = "{E278147F-BB66-49FD-A920-B78433D57146}" });
            lis.Add(new Mod() { url = "cms-uat.ninahotelgroup.com/zh-cn/nina-hotel-tsuen-wan-west/news/awards-and-accolades", v = "{6A5DA596-7737-48C8-8C04-1C4D4C7404C3}", s = "{9DB9AC7C-4EB3-4F56-BA89-704807718BF9}", itemid = "{8BA38D76-9D85-4623-91A6-52619ECD99E0}" });
            lis.Add(new Mod() { url = "cms-uat.ninahotelgroup.com/zh-hk/nina-hotel-tsuen-wan-west/news/latest-news", v = "{B4315740-8085-4B23-94B4-7AB716B7C0D5}", s = "{34529749-70D4-423E-B81C-CE432758FC5E}", itemid = "{F7FB0C07-12F5-49FF-871F-DC1302BFF807}" });
            lis.Add(new Mod() { url = "cms-uat.ninahotelgroup.com/zh-cn/nina-hotel-tsuen-wan-west/news/latest-news", v = "{B4315740-8085-4B23-94B4-7AB716B7C0D5}", s = "{5BBDF308-0812-45DC-947E-6959FC57091A}", itemid = "{F7FB0C07-12F5-49FF-871F-DC1302BFF807}" });
            lis.Add(new Mod() { url = "cms-uat.ninahotelgroup.com/zh-hk/nina-hotel-tsuen-wan-west/news/multimedia-library", v = "{B8C402BC-47C7-430E-857C-82753F83D72E}", s = "{BBA3329B-5D9D-4C7A-A2B3-013CFE38DE8D}", itemid = "{007325EE-6015-4C6A-8485-33804E5FAC2C}" });
            lis.Add(new Mod() { url = "cms-uat.ninahotelgroup.com/zh-cn/nina-hotel-tsuen-wan-west/news/multimedia-library", v = "{B8C402BC-47C7-430E-857C-82753F83D72E}", s = "{A54DBE2E-3723-44DC-AD1A-70686E4854D1}", itemid = "{007325EE-6015-4C6A-8485-33804E5FAC2C}" });
            lis.Add(new Mod() { url = "cms-uat.ninahotelgroup.com/zh-cn/nina-hotel-causeway-bay-quarantine-hotel/news/awards-and-accolades", v = "{6A5DA596-7737-48C8-8C04-1C4D4C7404C3}", s = "{9DB9AC7C-4EB3-4F56-BA89-704807718BF9}", itemid = "{05356FC2-4F5D-4138-A69F-56CF71DC0741}" });
            lis.Add(new Mod() { url = "cms-uat.ninahotelgroup.com/zh-cn/nina-hotel-causeway-bay-quarantine-hotel/news/latest-news", v = "{B4315740-8085-4B23-94B4-7AB716B7C0D5}", s = "{5BBDF308-0812-45DC-947E-6959FC57091A}", itemid = "{5835E010-9F3D-4D85-A61A-79A2BB0A2055}" });
            lis.Add(new Mod() { url = "cms-uat.ninahotelgroup.com/zh-hk/nina-hotel-causeway-bay-quarantine-hotel/news/latest-news", v = "{B4315740-8085-4B23-94B4-7AB716B7C0D5}", s = "{34529749-70D4-423E-B81C-CE432758FC5E}", itemid = "{5835E010-9F3D-4D85-A61A-79A2BB0A2055}" });
            lis.Add(new Mod() { url = "cms-uat.ninahotelgroup.com/zh-hk/nina-hotel-causeway-bay-quarantine-hotel/news/multimedia-library", v = "{B8C402BC-47C7-430E-857C-82753F83D72E}", s = "{BBA3329B-5D9D-4C7A-A2B3-013CFE38DE8D}", itemid = "{E43354A2-BF19-4763-A606-4D30A4A8DDA6}" });
            lis.Add(new Mod() { url = "cms-uat.ninahotelgroup.com/zh-cn/nina-hotel-causeway-bay-quarantine-hotel/news/multimedia-library", v = "{B8C402BC-47C7-430E-857C-82753F83D72E}", s = "{A54DBE2E-3723-44DC-AD1A-70686E4854D1}", itemid = "{E43354A2-BF19-4763-A606-4D30A4A8DDA6}" });
            lis.Add(new Mod() { url = "cms-uat.ninahotelgroup.com/zh-cn/nina-hotel-kowloon-east/news/latest-news", v = "{B4315740-8085-4B23-94B4-7AB716B7C0D5}", s = "{CB1B6D3C-9F62-454E-AC5D-888FA8DF07AF}", itemid = "{329D0B71-B35E-4238-80A3-BC93BE5865BC}" });
            lis.Add(new Mod() { url = "cms-uat.ninahotelgroup.com/zh-hk/nina-hotel-kowloon-east/news/latest-news", v = "{B4315740-8085-4B23-94B4-7AB716B7C0D5}", s = "{34529749-70D4-423E-B81C-CE432758FC5E}", itemid = "{329D0B71-B35E-4238-80A3-BC93BE5865BC}" });
            lis.Add(new Mod() { url = "cms-uat.ninahotelgroup.com/zh-hk/nina-hotel-kowloon-east/news/multimedia-library", v = "{B8C402BC-47C7-430E-857C-82753F83D72E}", s = "{BBA3329B-5D9D-4C7A-A2B3-013CFE38DE8D}", itemid = "{1A200766-118E-43AA-911A-13326BC51FF6}" });
            lis.Add(new Mod() { url = "cms-uat.ninahotelgroup.com/zh-cn/lodgewood-wan-chai/news/latest-news", v = "{B4315740-8085-4B23-94B4-7AB716B7C0D5}", s = "{7F89F276-8464-4274-BAEE-74A5C5C9CF54}", itemid = "{56459C72-547C-4FD3-805B-F3FA486E6DB4}" });
            lis.Add(new Mod() { url = "cms-uat.ninahotelgroup.com/zh-hk/lodgewood-wan-chai/news/latest-news", v = "{B4315740-8085-4B23-94B4-7AB716B7C0D5}", s = "{34529749-70D4-423E-B81C-CE432758FC5E}", itemid = "{56459C72-547C-4FD3-805B-F3FA486E6DB4}" });
            lis.Add(new Mod() { url = "cms-uat.ninahotelgroup.com/zh-hk/lodgewood-wan-chai/news/awards-and-accolades", v = "{6A5DA596-7737-48C8-8C04-1C4D4C7404C3}", s = "{37BAF10C-4C70-46E6-8E2F-6F746E20D1FB}", itemid = "{60023451-47F3-48CF-954F-050A0CDAE55E}" });
            lis.Add(new Mod() { url = "cms-uat.ninahotelgroup.com/zh-cn/lodgewood-wan-chai/news/awards-and-accolades", v = "{6A5DA596-7737-48C8-8C04-1C4D4C7404C3}", s = "{8977467F-FC24-478E-BF8F-C03126B65332}", itemid = "{60023451-47F3-48CF-954F-050A0CDAE55E}" });
            lis.Add(new Mod() { url = "cms-uat.ninahotelgroup.com/zh-hk/lodgewood-wan-chai/news/multimedia-library", v = "{B8C402BC-47C7-430E-857C-82753F83D72E}", s = "{BBA3329B-5D9D-4C7A-A2B3-013CFE38DE8D}", itemid = "{A79ED294-2925-4FC4-AE6B-B85CCCC20115}" });
            lis.Add(new Mod() { url = "cms-uat.ninahotelgroup.com/zh-cn/lodgewood-wan-chai/news/multimedia-library", v = "{B8C402BC-47C7-430E-857C-82753F83D72E}", s = "{A54DBE2E-3723-44DC-AD1A-70686E4854D1}", itemid = "{A79ED294-2925-4FC4-AE6B-B85CCCC20115}" });
            lis.Add(new Mod() { url = "cms-uat.ninahotelgroup.com/en/lodgewood-mong-kok/ninalife", v = "{0F4FF35B-3200-47B2-8AE3-E0770BBFF83A}", s = "{3E2F17DC-8E9F-4CF2-ABD7-06F97DA51C14}", itemid = "{C8D5EB50-88A8-4F4B-9F99-C5BC3B3CBBA7}" });
            lis.Add(new Mod() { url = "cms-uat.ninahotelgroup.com/en/lodgewood-mong-kok/offers", v = "{87814536-0A8C-4BB3-9697-D5D729C6493C}", s = "{03420B74-6D86-4F56-B99C-F38F793D9107}", itemid = "{02CC0B4E-F8C0-4EA1-8ABE-C5F8F10E4DDD}" });
            lis.Add(new Mod() { url = "cms-uat.ninahotelgroup.com/zh-hk/lodgewood-mong-kok/news/latest-news", v = "{B4315740-8085-4B23-94B4-7AB716B7C0D5}", s = "{34529749-70D4-423E-B81C-CE432758FC5E}", itemid = "{8B0C236C-EA4C-4B1D-BBEA-F38160ABCB03}" });
            lis.Add(new Mod() { url = "cms-uat.ninahotelgroup.com/zh-cn/lodgewood-mong-kok/news/latest-news", v = "{B4315740-8085-4B23-94B4-7AB716B7C0D5}", s = "{27CC7C67-3FA6-4541-9F5C-30D16F1B14F8}", itemid = "{8B0C236C-EA4C-4B1D-BBEA-F38160ABCB03}" });
            lis.Add(new Mod() { url = "cms-uat.ninahotelgroup.com/zh-hk/lodgewood-mong-kok/news/awards-and-accolades", v = "{6A5DA596-7737-48C8-8C04-1C4D4C7404C3}", s = "{B9DF393D-05E3-4FA2-8962-72C2C05294C6}", itemid = "{0ADFB043-F711-4DA6-BC89-51EEAD7BABE1}" });
            lis.Add(new Mod() { url = "cms-uat.ninahotelgroup.com/zh-cn/lodgewood-mong-kok/news/awards-and-accolades", v = "{6A5DA596-7737-48C8-8C04-1C4D4C7404C3}", s = "{B9DF393D-05E3-4FA2-8962-72C2C05294C6}", itemid = "{0ADFB043-F711-4DA6-BC89-51EEAD7BABE1}" });
            lis.Add(new Mod() { url = "cms-uat.ninahotelgroup.com/zh-hk/lodgewood-mong-kok/news/multimedia-library", v = "{B8C402BC-47C7-430E-857C-82753F83D72E}", s = "{BBA3329B-5D9D-4C7A-A2B3-013CFE38DE8D}", itemid = "{FB3A7804-DDD7-47D6-B214-8BB74EA1F05B}" });
            lis.Add(new Mod() { url = "cms-uat.ninahotelgroup.com/zh-hk/the-lily/news/latest-news", v = "{B4315740-8085-4B23-94B4-7AB716B7C0D5}", s = "{34529749-70D4-423E-B81C-CE432758FC5E}", itemid = "{FF7E6D05-E50A-4D54-B0FC-CDA0D35BD876}" });
            lis.Add(new Mod() { url = "cms-uat.ninahotelgroup.com/zh-hk/the-lily/news/awards-and-accolades", v = "{6A5DA596-7737-48C8-8C04-1C4D4C7404C3}", s = "{37BAF10C-4C70-46E6-8E2F-6F746E20D1FB}", itemid = "{C1CB955E-FB9C-422C-ACB9-8EC0F23A76C6}" });
            lis.Add(new Mod() { url = "cms-uat.ninahotelgroup.com/zh-hk/the-lily/news/multimedia-library", v = "{B8C402BC-47C7-430E-857C-82753F83D72E}", s = "{BBA3329B-5D9D-4C7A-A2B3-013CFE38DE8D}", itemid = "{79C7DC06-C42F-4FCE-A85D-15156BBE1D35}" });

            var strlist = new List<string>();

            foreach (var item in lis)
            {
                var temp = Path.Combine(item.url.Split('/').Skip(2).ToArray());
                strlist.Add(temp);
            }

            var ct = strlist.Distinct().ToList();
            FileStream fs = new FileStream("output.txt", FileMode.OpenOrCreate);
            StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);
            foreach (var ex in ct)
            {
                WriteL(sw, "{0}\t", ex.Replace('\\', '/'));
                WriteL(sw, "https:\\\\cms-uat.chinachemgroup.com\\en\\{0}\t", ex.Replace('\\', '/'));
                WriteL(sw, "https:\\\\cms-uat.chinachemgroup.com\\zh-cn\\{0}\t", ex.Replace('\\', '/'));
                WriteL(sw, "https:\\\\cms-uat.chinachemgroup.com\\zh-hk\\{0}\t", ex.Replace('\\', '/'));
                WriteL(sw, "https:\\\\uat.chinachemgroup.com\\en\\{0}\t", ex.Replace('\\', '/'));
                WriteL(sw, "https:\\\\uat.chinachemgroup.com\\zh-cn\\{0}\t", ex.Replace('\\', '/'));
                WriteL(sw, "https:\\\\uat.chinachemgroup.com\\zh-hk\\{0}\t", ex.Replace('\\', '/'));
                WriteL(sw, "https:\\\\cms-live.chinachemgroup.com\\en\\{0}\t", ex.Replace('\\', '/'));
                WriteL(sw, "https:\\\\cms-live.chinachemgroup.com\\zh-cn\\{0}\t", ex.Replace('\\', '/'));
                WriteL(sw, "https:\\\\cms-live.chinachemgroup.com\\zh-hk\\{0}\t", ex.Replace('\\', '/'));
                WriteL(sw, "https:\\\\www.chinachemgroup.com\\en\\{0}\t", ex.Replace('\\', '/'));
                WriteL(sw, "https:\\\\www.chinachemgroup.com\\zh-cn\\{0}\t", ex.Replace('\\', '/'));
                WriteL(sw, "https:\\\\www.chinachemgroup.com\\zh-hk\\{0}\r\n", ex.Replace('\\', '/'));

            }




            Console.WriteLine();

            sw.Flush();
            sw.Close();
            sw.Dispose();


            Console.WriteLine();




             







            //foreach (var item in lis)
            //{
            //    var urlstr1 = string.Format(@"https://{0}/sxa/search/results/?v={1}&itemid={2}&s={3}&l=en", item.url.Split('/').First(), item.v, item.itemid, item.s);
            //    var urlstr2 = string.Format(@"https://{0}/sxa/search/results/?v={1}&itemid={2}&s={3}&l=zh-CN", item.url.Split('/').First(), item.v, item.itemid, item.s);
            //    var urlstr3 = string.Format(@"https://{0}/sxa/search/results/?v={1}&itemid={2}&s={3}&l=zh-HK", item.url.Split('/').First(), item.v, item.itemid, item.s);
            //    try
            //    {

            //        WebClient MyWebClient = new WebClient
            //        {
            //            Credentials = CredentialCache.DefaultCredentials
            //        };

            //        var c1 = NewMethod(urlstr1, MyWebClient);
            //        var c2 = NewMethod(urlstr2, MyWebClient);
            //        var c3 = NewMethod(urlstr3, MyWebClient);

            //        Console.WriteLine(c1 + "\t" + c2 + "\t" + c3);
            //    }

            //    catch
            //    {

            //    }

            //}
        }

        private static void WriteL(StreamWriter sw, string v1, string v2)
        {
            sw.Write(v1, v2);
            Console.Write(v1, v2);
        }

        private static int NewMethod(string urlstr1, WebClient MyWebClient)
        {
            Byte[] pageData = MyWebClient.DownloadData(urlstr1); //从指定网站下载数据

            string pageHtml1 = Encoding.UTF8.GetString(pageData);  //如果获取网站页面采用的是GB2312，则使用这句            
            var cc1 = Newtonsoft.Json.JsonConvert.DeserializeObject<Rootobject>(pageHtml1);
            return cc1.Count;
        }
    }
    public class Rootobject
    {
        public int TotalTime { get; set; }
        public int CountTime { get; set; }
        public int QueryTime { get; set; }
        public object Signature { get; set; }
        public string Index { get; set; }
        public int Count { get; set; }
        public object[] Results { get; set; }
    }

}
