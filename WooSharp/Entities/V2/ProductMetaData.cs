using System.Runtime.Serialization;

namespace Bukimedia.WooSharp.Entities.WooCommerce.V2
{
    public class ProductMetaData
    {
        /// <summary>
        /// Meta ID.
        /// read-only
        /// </summary>
        [DataMember]
        public int id { get; set; }

        /// <summary>
        /// Meta key.
        /// </summary>
        [DataMember]
        public string key { get; set; }

        /// <summary>
        /// Meta value.
        /// </summary>
        [DataMember]
        public object value { get; set; }
    }
}
