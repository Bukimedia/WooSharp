using System.Runtime.Serialization;

namespace Bukimedia.WooSharp.Entities.WooCommerce.V2
{
    public class ProductDefaultAttributeLine
    {
        /// <summary>
        /// Attribute ID.
        /// </summary>
        [DataMember]
        public int? id { get; set; }

        /// <summary>
        /// Attribute name.
        /// </summary>
        [DataMember]
        public string name { get; set; }

        /// <summary>
        /// Selected attribute term name.
        /// </summary>
        [DataMember]
        public string option { get; set; }
    }
}
