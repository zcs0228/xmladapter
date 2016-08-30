using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace XmlAdapter.XmlRepository
{
    public class DataTableToXml
    {
        public static string ConvertToXMLString(DataTable sourceDt, string rootName)
        {
            //创建XML根节点
            XElement rootXElement = new XElement(rootName);

            //获取列名
            IList<string> columns = GetColumns(sourceDt);

            //将每一行转换为XML节点并添加到根节点中
            foreach (DataRow dr in sourceDt.Rows)
            {
                IList<XElement> rowCol = new List<XElement>();
                foreach (string col in columns)
                {
                    rowCol.Add(new XElement(col, dr[col]));
                }
                XElement newRow = new XElement("Row", rowCol.ToArray());
                rootXElement.Add(newRow);
            }

            //添加XML声明
            StringBuilder result = new StringBuilder("<?xml version=\"1.0\" encoding=\"utf - 8\"?>\n");
            result.Append(rootXElement.ToString());

            return result.ToString();
        }

        public static void Convert(DataTable sourceDt, string xmlPath)
        {
            XmlHelper xmlHelper = new XmlHelper(xmlPath);

            //获取列名
            IList<string> columns = GetColumns(sourceDt);
            StringBuilder columnsStr = new StringBuilder();
            foreach(string col in columns)
            {
                columnsStr.Append(col).Append(","); 
            }
            columnsStr.Remove(columnsStr.Length - 1, 1);
            xmlHelper.AddXElement("Columns", columnsStr.ToString());
        
            foreach(DataRow dr in sourceDt.Rows)
            {
                IList<XElement> rowCol = new List<XElement>();
                foreach (string col in columns)
                {
                    rowCol.Add(new XElement(col, dr[col]));
                }
                xmlHelper.AddXElement("Row", rowCol.ToArray());
            }
        }

        private static IList<string> GetColumns(DataTable dt)
        {
            IList<string> result = new List<string>();
            foreach(DataColumn col in dt.Columns)
            {
                result.Add(col.ColumnName);
            }
            return result;
        }
    }
}