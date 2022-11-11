using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DDGofAdapter
{
    public class GeradorXMLAdapter
    {
        public string GerarXml(object o)
        {
            XmlSerializer serializer = new XmlSerializer(o.GetType());
            StringWriter writer = new StringWriter();
            serializer.Serialize(writer, o);
            string xml = writer.ToString();

            return xml;
        }
    }
}
