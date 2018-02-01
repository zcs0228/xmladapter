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
            Tuple<string, string> rootNameSpace = new Tuple<string, string>("t1", "ssssss");
            List<Tuple<string, string>> childNameSpace = new List<Tuple<string, string>>();
            childNameSpace.Add(new Tuple<string, string>("t2", "sssfdsa"));
            childNameSpace.Add(new Tuple<string, string>("t3", "dafdaf"));
            string result = XmlHelper.CreateDocumentWithNameSpace("root", rootNameSpace, childNameSpace).ToString();
            

            //string basePath = AppDomain.CurrentDomain.BaseDirectory;

            //string path = basePath + "a.config";
            //string path1 = basePath + "b.xml";
            //XmlHelper helper = new XmlHelper(path);

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

            //DataTable dt = new DataTable();
            //dt.Columns.Add("a");
            //dt.Columns.Add("b");
            //DataRow dr1 = dt.NewRow();
            //dr1["a"] = 1;
            //dr1["b"] = 1;
            //dt.Rows.Add(dr1);
            //DataRow dr2 = dt.NewRow();
            //dr2["a"] = 2;
            //dr2["b"] = 3;
            //dt.Rows.Add(dr2);

            //string resulttest = DataTableToXml.ConvertToXMLString(dt, "root");

            //DataTable dttest = XmlToDataTable.ConvertFromXmlString(resulttest);

            /*
            string xml = @"<?xml version=""1.0"" encoding=""UTF-8""?>
<DATAINFOS SYSCODESYNCODE=""LKGYS"" UNIQUEID=""4475017BC928427DB5DC67D88B5ED34E"" SYSCODE=""GYS"" COMPANY=""三维天地科技有限公司"" SENDTIME=""2017-11-30 16:25:52"">
	<DATAINFO>
		<CATEGORYCODE REMARK=""类别编码"">03</CATEGORYCODE>
		<CATEGORYNAME REMARK=""类别名称"">员工供应商</CATEGORYNAME>
		<CODE REMARK=""主编码"">Y000494</CODE>
		<DESC1 REMARK=""供应商全称"">陆永生-6020</DESC1>
		<DESC2 REMARK=""语言"">ZH</DESC2>
		<DESC3 REMARK=""称谓""/>
		<DESC4 REMARK=""供应商分类"">员工供应商</DESC4>
		<DESC5 REMARK=""行业""/>
		<DESC6 REMARK=""客户""/>
		<DESC7 REMARK=""供应商联系人座机""/>
		<DESC8 REMARK=""供应商联系人手机""/>
		<DESC9 REMARK=""传真号""/>
		<DESC10 REMARK=""增值税登记号"">370811197707285010</DESC10>
		<DESC11 REMARK=""营业执照号""/>
		<DESC12 REMARK=""注册资金""/>
		<DESC13 REMARK=""法人代表""/>
		<DESC14 REMARK=""注释"">6020</DESC14>
		<DESC15 REMARK=""联系人""/>
		<DESC16 REMARK=""电子邮箱""/>
		<DESC17 REMARK=""国家"">CN</DESC17>
		<DESC18 REMARK=""城市""/>
		<DESC19 REMARK=""邮政编码""/>
		<DESC20 REMARK=""地区""/>
		<DESC21 REMARK=""助记码""/>
		<DESC22 REMARK=""街道""/>
		<DESC23 REMARK=""银行国家""/>
		<DESC24 REMARK=""银行代码""/>
		<DESC25 REMARK=""银行帐户""/>
		<DESC26 REMARK=""合作银行类型""/>
		<DESC27 REMARK=""银行帐户持有人""/>
		<DESC28 REMARK=""状态"">正常</DESC28>
		<DESC29 REMARK=""URI"">6020M21000</DESC29>
		<DESC30 REMARK=""银行名称""/>
		<CODEID REMARK=""MDM主键"">10231244</CODEID>
		<FREEZEFLAG REMARK=""数据状态"">0</FREEZEFLAG>
		<MNEMONICCODE REMARK=""助记码"">LYS</MNEMONICCODE>
		<RECORDERCODE REMARK=""制单人编码"">admin</RECORDERCODE>
		<RECORDERDESC REMARK=""制单人名称"">超级管理员</RECORDERDESC>
		<RECORDTIME REMARK=""制单时间"">2012-12-18 10:10:59</RECORDTIME>
		<RECORDERDCORP REMARK=""制单人单位编码"">1000</RECORDERDCORP>
		<SUBMITCORP REMARK=""提报单位编码"">100000</SUBMITCORP>
		<AUDITORCODE REMARK=""审核人编码"">luyongsheng</AUDITORCODE>
		<AUDITORDESC REMARK=""审核人名称"">陆永生</AUDITORDESC>
		<AUDITTIME REMARK=""审核时间"">2017-07-27 14:47:51</AUDITTIME>
		<VERSION REMARK=""主数据版本"">4</VERSION>
		<SYSCODEVERSION REMARK=""主数据模型版本"">29</SYSCODEVERSION>
		<CATEGORYVERSION REMARK=""分类模型版本"">4</CATEGORYVERSION>
		<SPECIALITYCODES>
			<SPECIALITYCODE SPECIALITYNAME=""供应商分类"" SPECIALITYCODE=""02""/>
			<SPECIALITYCODE SPECIALITYNAME=""基本信息"" SPECIALITYCODE=""01"">
				<PROPERTYCODE PROPERTYNAME=""状态"" PROPERTYCODE=""zczzs"" PREFIX="""" SUFFIX="""" BOUNDSYMBOL="""" UNIT="""">正常</PROPERTYCODE>
				<PROPERTYCODE PROPERTYNAME=""URI"" PROPERTYCODE=""uriaddr"" PREFIX="""" SUFFIX="""" BOUNDSYMBOL="""" UNIT="""">6020M21000</PROPERTYCODE>
				<PROPERTYCODE PROPERTYNAME=""注释"" PROPERTYCODE=""remark"" PREFIX="""" SUFFIX="""" BOUNDSYMBOL="""" UNIT="""">6020</PROPERTYCODE>
				<PROPERTYCODE PROPERTYNAME=""供应商联系人手机"" PROPERTYCODE=""telf2"" PREFIX="""" SUFFIX="""" BOUNDSYMBOL="""" UNIT=""""/>
				<PROPERTYCODE PROPERTYNAME=""供应商联系人座机"" PROPERTYCODE=""telf1"" PREFIX="""" SUFFIX="""" BOUNDSYMBOL="""" UNIT=""""/>
				<PROPERTYCODE PROPERTYNAME=""法人代表"" PROPERTYCODE=""j1kfrepre"" PREFIX="""" SUFFIX="""" BOUNDSYMBOL="""" UNIT=""""/>
				<PROPERTYCODE PROPERTYNAME=""注册资金"" PROPERTYCODE=""stcd3"" PREFIX="""" SUFFIX="""" BOUNDSYMBOL="""" UNIT=""""/>
				<PROPERTYCODE PROPERTYNAME=""称谓"" PROPERTYCODE=""anred"" PREFIX="""" SUFFIX="""" BOUNDSYMBOL="""" UNIT=""""/>
				<PROPERTYCODE PROPERTYNAME=""营业执照号"" PROPERTYCODE=""stcd"" PREFIX="""" SUFFIX="""" BOUNDSYMBOL="""" UNIT=""""/>
				<PROPERTYCODE PROPERTYNAME=""增值税登记号"" PROPERTYCODE=""stceg"" PREFIX="""" SUFFIX="""" BOUNDSYMBOL="""" UNIT="""">370811197707285010</PROPERTYCODE>
				<PROPERTYCODE PROPERTYNAME=""客户"" PROPERTYCODE=""kunnr"" PREFIX="""" SUFFIX="""" BOUNDSYMBOL="""" UNIT=""""/>
				<PROPERTYCODE PROPERTYNAME=""行业"" PROPERTYCODE=""brsch"" PREFIX="""" SUFFIX="""" BOUNDSYMBOL="""" UNIT=""""/>
				<PROPERTYCODE PROPERTYNAME=""供应商全称"" PROPERTYCODE=""name"" PREFIX="""" SUFFIX="""" BOUNDSYMBOL="""" UNIT="""">陆永生-6020</PROPERTYCODE>
				<PROPERTYCODE PROPERTYNAME=""语言"" PROPERTYCODE=""spras"" PREFIX="""" SUFFIX="""" BOUNDSYMBOL="""" UNIT="""">ZH</PROPERTYCODE>
				<PROPERTYCODE PROPERTYNAME=""电子邮箱"" PROPERTYCODE=""smtpaddr"" PREFIX="""" SUFFIX="""" BOUNDSYMBOL="""" UNIT=""""/>
				<PROPERTYCODE PROPERTYNAME=""传真号"" PROPERTYCODE=""telfx"" PREFIX="""" SUFFIX="""" BOUNDSYMBOL="""" UNIT=""""/>
				<PROPERTYCODE PROPERTYNAME=""联系人"" PROPERTYCODE=""namev"" PREFIX="""" SUFFIX="""" BOUNDSYMBOL="""" UNIT=""""/>
			</SPECIALITYCODE>
			<SPECIALITYCODE SPECIALITYNAME=""地址信息"" SPECIALITYCODE=""04"">
				<PROPERTYCODE PROPERTYNAME=""地区"" PROPERTYCODE=""regio"" PREFIX="""" SUFFIX="""" BOUNDSYMBOL="""" UNIT=""""/>
				<PROPERTYCODE PROPERTYNAME=""街道"" PROPERTYCODE=""stras"" PREFIX="""" SUFFIX="""" BOUNDSYMBOL="""" UNIT=""""/>
				<PROPERTYCODE PROPERTYNAME=""邮政编码"" PROPERTYCODE=""pstlz"" PREFIX="""" SUFFIX="""" BOUNDSYMBOL="""" UNIT=""""/>
				<PROPERTYCODE PROPERTYNAME=""城市"" PROPERTYCODE=""ort01"" PREFIX="""" SUFFIX="""" BOUNDSYMBOL="""" UNIT=""""/>
				<PROPERTYCODE PROPERTYNAME=""国家"" PROPERTYCODE=""land1"" PREFIX="""" SUFFIX="""" BOUNDSYMBOL="""" UNIT="""">CN</PROPERTYCODE>
			</SPECIALITYCODE>
			<SPECIALITYCODE SPECIALITYNAME=""银行信息"" SPECIALITYCODE=""03"">
				<VALUELIST REMARK=""特性多值"" ID=""21075961"">
					<PROPERTYCODE PROPERTYNAME=""银行名称"" PROPERTYCODE=""banka"">建行临沂龙潭支行</PROPERTYCODE>
					<PROPERTYCODE PROPERTYNAME=""银行代码"" PROPERTYCODE=""bankl"">105473000130</PROPERTYCODE>
					<PROPERTYCODE PROPERTYNAME=""银行账号"" PROPERTYCODE=""bankn"">6236682290000422879</PROPERTYCODE>
					<PROPERTYCODE PROPERTYNAME=""银行国家"" PROPERTYCODE=""banks"">CN</PROPERTYCODE>
					<PROPERTYCODE PROPERTYNAME=""合作银行类型"" PROPERTYCODE=""bvtyp""/>
					<PROPERTYCODE PROPERTYNAME=""银行帐户持有人"" PROPERTYCODE=""koinh"">陆永生</PROPERTYCODE>
				</VALUELIST>
                <VALUELIST REMARK=""特性多值"" ID=""21075961"">
					<PROPERTYCODE PROPERTYNAME=""银行名称"" PROPERTYCODE=""banka"">建行临沂龙潭支行</PROPERTYCODE>
					<PROPERTYCODE PROPERTYNAME=""银行代码"" PROPERTYCODE=""bankl"">105473000130</PROPERTYCODE>
					<PROPERTYCODE PROPERTYNAME=""银行账号"" PROPERTYCODE=""bankn"">6236682290000422879</PROPERTYCODE>
					<PROPERTYCODE PROPERTYNAME=""银行国家"" PROPERTYCODE=""banks"">CN</PROPERTYCODE>
					<PROPERTYCODE PROPERTYNAME=""合作银行类型"" PROPERTYCODE=""bvtyp""/>
					<PROPERTYCODE PROPERTYNAME=""银行帐户持有人"" PROPERTYCODE=""koinh"">aaa</PROPERTYCODE>
				</VALUELIST>
			</SPECIALITYCODE>
		</SPECIALITYCODES>
	</DATAINFO>
</DATAINFOS>";
            XElement xmlDoc = XElement.Parse(xml.Trim());

            IEnumerable<XElement> list =
                from target in xmlDoc.Descendants("SPECIALITYCODE")
                where target.Attribute("SPECIALITYNAME").Value == "银行信息"
                && target.Attribute("SPECIALITYCODE").Value == "03"
                select target;

            IEnumerable<XElement> lista =
                from target in list.FirstOrDefault().Descendants("VALUELIST")
                select target;

            IEnumerable<XElement> listb =
                from target in (from target in xmlDoc.Descendants("SPECIALITYCODE")
                                where target.Attribute("SPECIALITYNAME").Value == "银行信息"
                                && target.Attribute("SPECIALITYCODE").Value == "03"
                                select target).FirstOrDefault().Descendants("VALUELIST")
                select target;

            IEnumerable<XElement> list1 =
                from target in lista.FirstOrDefault().Descendants("PROPERTYCODE")
                where target.Attribute("PROPERTYNAME").Value== "银行名称" 
                && target.Attribute("PROPERTYCODE").Value == "banka"
                select target;
                */
        }
    }
}
