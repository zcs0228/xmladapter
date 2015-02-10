using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using XmlAdapter.XmlRepository;

namespace XmlTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"d:\website";
            XmlHelper helper = new XmlHelper(path);
            
            //helper.CreateDocument();

            object[] elements = { new XElement("a", "a"), new XElement("b", "b") };
            //helper.AddXmlNodeToRoot("root", elements);
            XmlElementInfor IdElement = new XmlElementInfor("a", "a");
            //helper.DeleteNodeFromRoot("root", IdElement);

            XmlElementInfor[] updateValue = { new XmlElementInfor("a", "a"), new XmlElementInfor("b", "b") };
            //helper.UpdateNodeFromRoot("root", IdElement, updateValue);

            helper.QueryNodeFromRoot("root", IdElement);
        }
    }
}
