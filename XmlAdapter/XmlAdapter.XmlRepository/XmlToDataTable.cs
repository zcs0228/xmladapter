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
        public static DataTable ConvertFromXmlString(string xmlString)
        {
            XElement xmlDoc = XElement.Parse(xmlString);

            DataTable result = new DataTable();
            Dictionary<string, string> columnNameDic = new Dictionary<string, string>();//列名字典，判断是否有重复列
            bool isFirstLoop = true;//是否第一次循环
            foreach(XElement xeRow in xmlDoc.Descendants("Row"))
            {
                #region 第一次循环构件DataTable的列
                if (isFirstLoop)
                {
                    foreach (XElement xeCol in xeRow.Descendants())
                    {
                        string colName = xeCol.Name.ToString();

                        if (!columnNameDic.Keys.Contains(colName))
                        {
                            columnNameDic.Add(colName, "");
                            DataColumn dc = new DataColumn(colName);
                            result.Columns.Add(dc);
                        }
                        else
                        {
                            throw new Exception("列[" + colName + "]已经存在于DataTable中!");
                        }
                    }
                }
                isFirstLoop = false;
                #endregion

                #region 将数据添加到DataTable
                DataRow dr = result.NewRow();
                foreach (XElement xeCol in xeRow.Descendants())
                {
                    string colName = xeCol.Name.ToString();
                    string colValue = xeCol.Value;
                    dr[colName] = colValue;
                }
                result.Rows.Add(dr);
                #endregion
            }

            return result;
        }

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
