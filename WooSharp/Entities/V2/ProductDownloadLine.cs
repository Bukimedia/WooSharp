using System.Runtime.Serialization;

namespace Bukimedia.WooSharp.Entities.WooCommerce.V2
{
    public class ProductDownloadLine
    {
        /// <summary>
        /// File ID.
        /// </summary>
        [DataMember]
        public int id { get; set; }

        /// <summary>
        /// File name.
        /// </summary>
        [DataMember]
        public string name { get; set; }

        /// <summary>
        /// File URL.
        /// </summary>
        [DataMember]
        public string file { get; set; }
    }
}
