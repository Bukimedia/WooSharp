using System.Runtime.Serialization;

namespace Bukimedia.WooSharp.Entities.WooCommerce.V2
{
    public class ProductCategoryLine
    {
        /// <summary>
        /// Category ID.
        /// </summary>
        [DataMember]
        public int? id { get; set; }

        /// <summary>
        /// Category name. 
        /// read-only
        /// </summary>
        [DataMember]
        public string name { get; set; }

        /// <summary>
        /// Category slug. 
        /// read-only
        /// </summary>
        [DataMember]
        public string slug { get; set; }
    }
}
