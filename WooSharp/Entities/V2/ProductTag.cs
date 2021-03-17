using System.Runtime.Serialization;

namespace Bukimedia.WooSharp.Entities.WooCommerce.V2
{
    public class ProductTag : WooCommerceEntity, IWooCommerceFactoryEntity
    {
        /// <summary>
        /// Unique identifier for the resource. 
        /// read-only
        /// </summary>
        [DataMember]
        public int? id { get; set; }

        /// <summary>
        /// Tag name. 
        /// mandatory
        /// </summary>
        [DataMember]
        public string name { get; set; }

        /// <summary>
        /// An alphanumeric identifier for the resource unique to its type.
        /// </summary>
        [DataMember]
        public string slug { get; set; }

        /// <summary>
        /// HTML description of the resource.
        /// </summary>
        [DataMember]
        public string description { get; set; }

        /// <summary>
        /// Number of published products for the resource. 
        /// read-only
        /// </summary>
        [DataMember]
        public int? count { get; set; }
    }
}
