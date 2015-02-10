using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlAdapter.XmlRepository
{
    public class XmlElementInfor
    {
        private string _name;
        private string _value;

        public XmlElementInfor(string elementName, string elementValue)
        {
            _name = elementName;
            _value = elementValue;
        }

        public string Name { get { return _name; } }
        public string Value { get { return _value; } }
    }
}
