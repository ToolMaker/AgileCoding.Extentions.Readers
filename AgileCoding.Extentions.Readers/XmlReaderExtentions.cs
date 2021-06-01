using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace AgileCoding.Extentions.Readers
{
    public static class XmlReaderExtentions
    {
        public static bool ReadToNextElement(this XmlReader reader)
        {
            reader.Read();
            var nodeTypeName = reader.LocalName;
            do
            {
                int depth = reader.Depth;
                nodeTypeName = reader.LocalName;
                var elementName = reader.GetAttribute("name");

                if (nodeTypeName == "element" && reader.NodeType == XmlNodeType.Element)
                {
                    break;
                }

                reader.Read();
            }
            while (!reader.EOF && nodeTypeName != "element");

            return reader.EOF;
        }
    }
}
