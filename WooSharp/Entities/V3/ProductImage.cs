using System;
using System.Runtime.Serialization;

namespace Bukimedia.WooSharp.Entities.WooCommerce.V3
{
    public class ProductImage
    {
        /// <summary>
        /// Image ID.
        /// </summary>
        [DataMember]
        public int? id { get; set; }

        /// <summary>
        /// The date the image was created, in the site’s timezone. 
        /// read-only
        /// </summary>
        [DataMember]
        public DateTime? date_created { get; set; }

        /// <summary>
        /// The date the image was created, as GMT. 
        /// read-only
        /// </summary>
        [DataMember]
        public DateTime? date_created_gmt { get; set; }

        /// <summary>
        /// The date the image was last modified, in the site’s timezone. 
        /// read-only
        /// </summary>
        [DataMember]
        public DateTime? date_modified { get; set; }

        /// <summary>
        /// The date the image was last modified, as GMT. 
        /// read-only
        /// </summary>
        [DataMember]
        public DateTime? date_modified_gmt { get; set; }

        /// <summary>
        /// Image URL.
        /// </summary>
        [DataMember]
        public string src { get; set; }

        /// <summary>
        /// Image name.
        /// </summary>
        [DataMember]
        public string name { get; set; }

        /// <summary>
        /// Image alternative text.
        /// </summary>
        [DataMember]
        public string alt { get; set; }
    }
}
