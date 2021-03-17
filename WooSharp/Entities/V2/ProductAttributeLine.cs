using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Bukimedia.WooSharp.Entities.WooCommerce.V2
{
    public class ProductAttributeLine
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
        /// Attribute position.
        /// </summary>
        [DataMember]
        public int? position { get; set; }

        /// <summary>
        /// Define if the attribute is visible on the “Additional information” tab in the product’s page. Default is false.
        /// </summary>
        [DataMember]
        public bool? visible { get; set; }

        /// <summary>
        /// Define if the attribute can be used as variation. Default is false.
        /// </summary>
        [DataMember]
        public bool? variation { get; set; }

        /// <summary>
        /// List of available term names of the attribute.
        /// </summary>
        [DataMember]
        public List<string> options { get; set; }
    }
}
