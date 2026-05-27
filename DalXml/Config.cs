using System;
using System.Xml.Linq;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Dal
{
    internal static class Config
    {
        private static string fileName = "../xml/data-config.xml";

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
            if (!File.Exists(fileName))
            {
                new XElement("config",
                    new XElement("ProductNum", 1),
                    new XElement("SaleNum", 1)
                ).Save(fileName);
            }

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
