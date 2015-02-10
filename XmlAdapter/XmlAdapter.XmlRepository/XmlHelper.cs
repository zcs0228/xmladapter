using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace XmlAdapter.XmlRepository
{
    public class XmlHelper
    {
        private string _filePath;

        public XmlHelper(string filePath)
        {
            _filePath = filePath;
        }

        /// <summary>
        /// 创建XML文件
        /// </summary>
        public void CreateDocument()
        {
            XDocument xdoc = new XDocument(new XDeclaration("1.0", "utf-8", "yes"),
                new XElement("Root"));
            xdoc.Save(_filePath);
        }
        /// <summary>
        /// 向XML跟节点中添加元素
        /// </summary>
        /// <param name="nodeName">元素名称</param>
        /// <param name="xelements">元素属性及内容</param>
        public void AddXmlNodeToRoot(string nodeName, params object[] xelements)
        {
            XElement rootNode = XElement.Load(_filePath);
            XElement newNode = new XElement(nodeName, xelements);
            rootNode.Add(newNode);
            rootNode.Save(_filePath);
        }
        /// <summary>
        /// 从XML跟节点删除元素及其子元素
        /// </summary>
        /// <param name="nodeName">元素名称</param>
        /// <param name="IdElement">元素筛选条件</param>
        public void DeleteNodeFromRoot(string nodeName, XmlElementInfor IdElement)
        {
            XElement rootNode = XElement.Load(_filePath);

            IEnumerable<XElement> targetNodes = from target in rootNode.Descendants(nodeName) 
                                                where target.Element(IdElement.Name).Value.Equals(IdElement.Value)  
                                                select target;
            targetNodes.Remove();
            rootNode.Save(_filePath);
        }
        /// <summary>
        /// 更新元素
        /// </summary>
        /// <param name="nodeName">元素名称</param>
        /// <param name="IdElement">元素筛选条件</param>
        /// <param name="updateValue">需更新内容</param>
        public void UpdateNodeFromRoot(string nodeName, XmlElementInfor IdElement, XmlElementInfor[] updateValue)
        {
            XElement rootNode = XElement.Load(_filePath);
            IEnumerable<XElement> targetNodes = from target in rootNode.Descendants(nodeName)
                                                where target.Element(IdElement.Name).Value.Equals(IdElement.Value)
                                                select target;
            foreach (XElement node in targetNodes)
            {
                foreach (var item in updateValue)
                {
                    node.Element(item.Name).SetValue(item.Value);
                }
            }
            rootNode.Save(_filePath);
        }
        /// <summary>
        /// 从根节点查询元素
        /// </summary>
        /// <param name="nodeName">元素名称</param>
        /// <param name="IdElement">元素筛选条件</param>
        /// <returns></returns>
        public IEnumerable<XElement> QueryNodeFromRoot(string nodeName, XmlElementInfor IdElement)
        {
            XElement rootNode = XElement.Load(_filePath);
            IEnumerable<XElement> targetNodes = from target in rootNode.Descendants(nodeName)
                                                where target.Element(IdElement.Name).Value.Equals(IdElement.Value)
                                                select target;
            return targetNodes;
        }
    }
}
