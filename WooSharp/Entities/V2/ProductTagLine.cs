using System.Runtime.Serialization;

namespace Bukimedia.WooSharp.Entities.WooCommerce.V2
{
    public class ProductTagLine
    {
        /// <summary>
        /// Tag ID.
        /// </summary>
        [DataMember]
        public int? id { get; set; }

        /// <summary>
        /// Tag name. 
        /// read-only
        /// </summary>
        [DataMember]
        public string name { get; set; }

        /// <summary>
        /// Tag slug. 
        /// read-only
        /// </summary>
        [DataMember]
        public string slug { get; set; }
    }
}
