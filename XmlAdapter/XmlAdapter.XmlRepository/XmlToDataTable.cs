using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace XmlAdapter.XmlRepository
{
    public class XmlToDataTable
    {
        public static DataTable Convert(string xmlPath)
        {
            DataTable result = new DataTable();
            XmlHelper xmlHelper = new XmlHelper(xmlPath);
            string columnStr = xmlHelper.QueryXElementValue("Columns").ToString();
            string[] columnArray = columnStr.Split(',');
            foreach (string item in columnArray)
            {
                if (!result.Columns.Contains(item))
                {
                    result.Columns.Add(new DataColumn(item));
                }
            }

            IEnumerable<XElement> rows = xmlHelper.QueryXElement("Row");
            foreach (XElement row in rows)
            {
                DataRow newRow = result.NewRow();
                foreach (string item in columnArray)
                {
                    newRow[item] = xmlHelper.QueryXElementValue(row, item);
                }
                result.Rows.Add(newRow);
            }
            return result;
        }
    }
}
