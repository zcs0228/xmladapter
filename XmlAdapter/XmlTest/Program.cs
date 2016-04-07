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

            //helper.AddXElement("root", elements);
            //helper.DeleteXElement("a");

            //helper.UpdateXElement("b", "aaaaa");

            //helper.QueryXElement("root");

            XAttribute[] xa = { new XAttribute("v1", "113"), new XAttribute("v2", "2aa"), new XAttribute("v3", "111") };
            //helper.AddOrUpdateXAttributeForXElement("b", xa);

            XElement[] xes = { new XElement("test1", "1111"), new XElement("test2", "22222") };
            //helper.AddElementToAfter("b", xes);
            //helper.AddElementToBefore("b", xes);

            //helper.AddAttributeToXElement("b", "v5", "test");

            //helper.AddCommentToAfter("b", "zhishi1");
            //helper.AddCommentToBefore("b", "zhishi2");

            XElement newElement = new XElement("newone", "newone");
            helper.ReplaceXElement("test1", "1111", newElement);
        }
    }
}
