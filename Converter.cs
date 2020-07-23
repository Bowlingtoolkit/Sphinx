using System.Web.Script.Serialization;
using System.Xml;

namespace Sphinx
{
    public class Converter
    {
        public static string JSON(object jsondata)
        {
            return new JavaScriptSerializer().Serialize(jsondata);
        }

        public static string XML(XmlDocument myxml)
        {
            return myxml.OuterXml;
        }
    }
}
