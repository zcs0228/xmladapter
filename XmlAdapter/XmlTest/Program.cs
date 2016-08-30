using System;
using System.Collections.Generic;
using System.Data;
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
            string basePath = AppDomain.CurrentDomain.BaseDirectory;

            string path = basePath + "a.config";
            string path1 = basePath + "b.xml";
            XmlHelper helper = new XmlHelper(path);

            //IEnumerable<XElement> result = helper.QueryXElement("Row");
            //foreach(var item in result.Descendants())
            //{
            //    string name = item.Name.ToString();
            //    string value = item.Value;
            //}

            //helper.CreateDocument();
            //helper.AddXElement("test1", "a");
            //helper.DeleteXElement("a");
            //helper.UpdateXElement("b", "aaaaa");

            //helper.QueryXElement("root");

            //XAttribute[] xa = { new XAttribute("v1", "113"), new XAttribute("v2", "2aa"), new XAttribute("v3", "111") };
            //helper.AddOrUpdateXAttributeForXElement("test1", xa);

            //XElement[] xes = { new XElement("test1", "1111"), new XElement("test2", "22222") };
            //helper.AddElementToAfter("b", xes);
            //helper.AddElementToBefore("b", xes);

            //helper.AddAttributeToXElement("b", "v5", "test");

            //helper.AddCommentToAfter("b", "zhishi1");
            //helper.AddCommentToBefore("b", "zhishi2");

            //XElement newElement = new XElement("newone", "newone");
            //helper.ReplaceXElement("test1", "1111", newElement);
            //helper.UpdateAttributeToXElement("test1", "v2", "123456");
            //DataTable dt = XmlToDataTable.Convert(path);
            //DataTableToXml.Convert(dt, path1);

            //helper.ReadXML(@"<?xml version=""1.0"" encoding=""utf-8""?><Root><Columns>a, b, c</Columns><Row><a>4</a><b>5</b><c>6</c></Row></Root> ");
            //helper.WriteXML("root");

            DataTable dt = new DataTable();
            dt.Columns.Add("a");
            dt.Columns.Add("b");
            DataRow dr1 = dt.NewRow();
            dr1["a"] = 1;
            dr1["b"] = 1;
            dt.Rows.Add(dr1);
            DataRow dr2 = dt.NewRow();
            dr2["a"] = 2;
            dr2["b"] = 3;
            dt.Rows.Add(dr2);

            string resulttest = DataTableToXml.ConvertToXMLString(dt, "root");

            DataTable dttest = XmlToDataTable.ConvertFromXmlString(resulttest);
        }
    }
}
