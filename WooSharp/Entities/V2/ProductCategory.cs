using System.Runtime.Serialization;

namespace Bukimedia.WooSharp.Entities.WooCommerce.V2
{
    public class ProductCategory : WooCommerceEntity, IWooCommerceFactoryEntity
    {
        /// <summary>
        /// Unique identifier for the resource. 
        /// read-only
        /// </summary>
        [DataMember]
        public int? id { get; set; }

        /// <summary>
        /// Category name. 
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
        /// The ID for the parent of the resource.
        /// </summary>
        [DataMember]
        public int? parent { get; set; }

        /// <summary>
        /// HTML description of the resource.
        /// </summary>
        [DataMember]
        public string description { get; set; }

        /// <summary>
        /// Category archive display type. Options: default, products, subcategories and both. Default is default.
        /// </summary>
        [DataMember]
        public string display { get; set; }

        /// <summary>
        /// Image data. See Product category - Image properties
        /// </summary>
        [DataMember]
        public ProductImage image { get; set; }

        /// <summary>
        /// Menu order, used to custom sort the resource.
        /// </summary>
        [DataMember]
        public int? menu_order { get; set; }

        /// <summary>
        /// Number of published products for the resource. 
        /// read-only
        /// </summary>
        [DataMember]
        public int? count { get; set; }
    }
}
