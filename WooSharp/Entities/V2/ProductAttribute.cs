using System.Runtime.Serialization;

namespace Bukimedia.WooSharp.Entities.WooCommerce.V2
{
    public class ProductAttribute : WooCommerceEntity, IWooCommerceFactoryEntity
    {
        /// <summary>
        /// Unique identifier for the resource. 
        /// read-only
        /// </summary>
        [DataMember]
        public int? id { get; set; }

        /// <summary>
        /// Attribute name. 
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
        /// Type of attribute. Options: select and text. Default is select.
        /// </summary>
        [DataMember]
        public string type { get; set; }

        /// <summary>
        /// Default sort order. Options: menu_order, name, name_num and id. Default is menu_order.
        /// </summary>
        [DataMember]
        public string order_by { get; set; }

        /// <summary>
        /// Enable/Disable attribute archives. Default is false.
        /// </summary>
        [DataMember]
        public bool? has_archives { get; set; }
    }
}
