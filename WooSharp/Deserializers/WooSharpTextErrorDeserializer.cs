using RestSharp;
using RestSharp.Serialization.Xml;
using System;

namespace Bukimedia.WooSharp.Deserializers
{
    public class WooSharpTextErrorDeserializer : IXmlDeserializer
    {
        public T Deserialize<T>(IRestResponse response)
        {
            throw new Exception("Prestashop failed to serve XML response instead got text: " + response.Content);
        }

        public string RootElement { get; set; }
        public string Namespace { get; set; }
        public string DateFormat { get; set; }
    }
}