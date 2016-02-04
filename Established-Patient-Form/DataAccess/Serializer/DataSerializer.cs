using System.Web.Script.Serialization;

namespace DataAccess.Serializer
{
    internal static class DataSerializer
    {
        internal static string Serialize(object data)
        {
            JavaScriptSerializer json_serializer = new JavaScriptSerializer();
            return json_serializer.Serialize(data);
        }

        internal static T Deserialize<T>(string data)
        {
            JavaScriptSerializer json_serializer = new JavaScriptSerializer();
            return json_serializer.Deserialize<T>(data);
        }
    }
}
