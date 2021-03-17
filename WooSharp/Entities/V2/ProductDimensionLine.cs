using System.Runtime.Serialization;

namespace Bukimedia.WooSharp.Entities.WooCommerce.V2
{
    public class ProductDimensionLine
    {
        /// <summary>
        /// Product length.
        /// </summary>
        [DataMember]
        public string length { get; set; }

        /// <summary>
        /// Product width.
        /// </summary>
        [DataMember]
        public string width { get; set; }

        /// <summary>
        /// Product height.
        /// </summary>
        [DataMember]
        public string height { get; set; }
    }
}
