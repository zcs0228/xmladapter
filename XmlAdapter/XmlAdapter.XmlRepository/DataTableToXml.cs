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