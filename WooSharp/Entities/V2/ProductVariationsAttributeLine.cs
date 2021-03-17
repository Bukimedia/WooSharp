
/* Unmerged change from project 'WooSharp (net452)'
Before:
using System.Collections.Generic;
using System;
After:
using System;
using System.Collections.Generic;
*/
using System.Runtime.Serialization;

namespace Bukimedia.WooSharp.Entities.WooCommerce.V2
{
    public class ProductVariationsAttributeLine
    {
        /// <summary>
        /// Attribute ID.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public int? id { get; set; }

        /// <summary>
        /// Attribute name.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string name { get; set; }

        /// <summary>
        /// Selected attribute term name.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string option { get; set; }
    }
}
