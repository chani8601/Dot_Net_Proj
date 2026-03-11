using System;
using System.Xml.Linq;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DalXml
{
    internal static class Config
    {
        private static string fileName = "data-config";

        internal static int ProductNum
        {
            get
            {
                int num = ReadFromXml("ProductNum");
                WriteToXml("ProductNum", num + 1);
                return num;
            }
        }

        internal static int SaleNum
        {
            get
            {
                int num = ReadFromXml("SaleNum");
                WriteToXml("SaleNum", num + 1);
                return num;
            }
        }

        private static int ReadFromXml(string elementName)
        {
            XElement config = XElement.Load(fileName);
            return int.Parse(config.Element(elementName).Value);
        }

        private static void WriteToXml(string elementName, int value)
        {
            XElement config = XElement.Load(fileName);
            config.Element(elementName).Value = value.ToString();
            config.Save(fileName);
        }
    }
}
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DalXml
//{
//    static internal class Config
//    {
//        private static string file_name="data_config";
//        internal static int ProductNum
//        {
//            get
//            {
//                int num = ReadFromXml("ProductNum"); // קורא מהקובץ
//                WriteToXml("ProductNum", num + 1);   // מעלה את המספר
//                return num;                          // מחזיר את המספר הנוכחי
//            }
//            get
//            {
//                int num = ReadFromXml("ProductNum"); // קורא מהקובץ
//                WriteToXml("ProductNum", num + 1);   // מעלה את המספר
//                return num;                          // מחזיר את המספר הנוכחי
//            }
//        }

//        private static void WriteToXml(string v1, int v2)
//        {
//            throw new NotImplementedException();
//        }

//        private static int ReadFromXml(string v)
//        {
//            throw new NotImplementedException();
//        }
//    }
//}
