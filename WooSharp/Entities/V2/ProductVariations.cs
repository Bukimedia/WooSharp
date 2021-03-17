using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Bukimedia.WooSharp.Entities.WooCommerce.V2
{
    public class ProductVariations : WooCommerceEntity, IWooCommerceFactoryEntity
    {
        /// <summary>
        /// Unique identifier for the resource. 
        /// read-only
        /// </summary>
        [DataMember]
        public int? id { get; set; }

        /// <summary>
        /// The date the variation was created, in the site’s timezone. 
        /// read-only
        /// </summary>
        [DataMember]
        public DateTime? date_created { get; set; }

        /// <summary>
        /// The date the variation was last modified, in the site’s timezone. 
        /// read-only
        /// </summary>
        [DataMember]
        public DateTime? date_modified { get; set; }

        /// <summary>
        /// Variation description.
        /// </summary>
        [DataMember]
        public string description { get; set; }

        /// <summary>
        /// Variation URL. 
        /// read-only
        /// </summary>
        [DataMember]
        public string permalink { get; set; }

        /// <summary>
        /// Unique identifier.
        /// </summary>
        [DataMember]
        public string sku { get; set; }

        [DataMember(EmitDefaultValue = false, Name = "price")]
        protected object priceValue { get; set; }
        /// <summary>
        /// Current variation price. 
        /// read-only
        /// </summary>
        public decimal? price { get; set; }

        [DataMember(EmitDefaultValue = false, Name = "regular_price")]
        protected object regular_priceValue { get; set; }
        /// <summary>
        /// Variation regular price.
        /// </summary>
        public decimal? regular_price { get; set; }

        [DataMember(EmitDefaultValue = false, Name = "sale_price")]
        protected object sale_priceValue { get; set; }
        /// <summary>
        /// Variation sale price.
        /// </summary>
        public decimal? sale_price { get; set; }

        /// <summary>
        /// Start date of sale price, in the site’s timezone.
        /// </summary>
        [DataMember]
        public DateTime? date_on_sale_from { get; set; }

        /// <summary>
        /// Start date of sale price, as GMT.
        /// </summary>
        [DataMember]
        public DateTime? date_on_sale_from_gmt { get; set; }

        /// <summary>
        /// End date of sale price, in the site’s timezone.
        /// </summary>
        [DataMember]
        public DateTime? date_on_sale_to { get; set; }

        /// <summary>
        /// End date of sale price, in the site’s timezone.
        /// </summary>
        [DataMember]
        public DateTime? date_on_sale_to_gmt { get; set; }

        /// <summary>
        /// Shows if the variation is on sale. 
        /// read-only
        /// </summary>
        [DataMember]
        public bool? on_sale { get; set; }

        /// <summary>
        /// Define if the attribute is visible on the “Additional information” tab in the product’s page. Default is true.
        /// </summary>
        [DataMember]
        public bool? visible { get; set; }

        /// <summary>
        /// Shows if the variation can be bought. 
        /// read-only
        /// </summary>
        [DataMember]
        public bool? purchasable { get; set; }

        /// <summary>
        /// If the variation is virtual. Default is false.
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "virtual")]
        public bool? _virtual { get; set; }

        /// <summary>
        /// If the variation is downloadable. Default is false.
        /// </summary>
        [DataMember]
        public bool? downloadable { get; set; }

        /// <summary>
        /// List of downloadable files. See Product variation - Downloads properties
        /// </summary>
        [DataMember]
        public List<ProductDownloadLine> downloads { get; set; }

        /// <summary>
        /// Number of times downloadable files can be downloaded after purchase. Default is -1.
        /// </summary>
        [DataMember]
        public int? download_limit { get; set; }

        /// <summary>
        /// Number of days until access to downloadable files expires. Default is -1.
        /// </summary>
        [DataMember]
        public int? download_expiry { get; set; }

        /// <summary>
        /// Tax status. Options: taxable, shipping and none. Default is taxable.
        /// </summary>
        [DataMember]
        public string tax_status { get; set; }

        /// <summary>
        /// Tax class.
        /// </summary>
        [DataMember]
        public string tax_class { get; set; }

        /// <summary>
        /// Stock management at variation level. Default is false.
        /// When Manage stock is checked, string value "parent" will be given, otherwise, it will be bool value false.
        /// </summary>
        [DataMember]
        public object manage_stock { get; set; }

        [DataMember(EmitDefaultValue = false, Name = "stock_quantity")]
        protected object stock_quantityValue { get; set; }
        /// <summary>
        /// Stock quantity.
        /// </summary>
        public int? stock_quantity { get; set; }

        /// <summary>
        /// Controls whether or not the variation is listed as “in stock” or “out of stock” on the frontend. Default is true.
        /// </summary>
        [DataMember]
        public bool? in_stock { get; set; }

        /// <summary>
        /// If managing stock, this controls if backorders are allowed. Options: no, notify and yes. Default is no.
        /// </summary>
        [DataMember]
        public string backorders { get; set; }

        /// <summary>
        /// Shows if backorders are allowed. 
        /// read-only
        /// </summary>
        [DataMember]
        public bool? backorders_allowed { get; set; }

        /// <summary>
        /// Shows if the variation is on backordered. 
        /// read-only
        /// </summary>
        [DataMember]
        public bool? backordered { get; set; }

        [DataMember(EmitDefaultValue = false, Name = "weight")]
        protected object weightValue { get; set; }
        /// <summary>
        /// Variation weight (kg).
        /// </summary>
        public decimal? weight { get; set; }

        /// <summary>
        /// Variation dimensions. See Product variation - Dimensions properties
        /// </summary>
        [DataMember]
        public ProductDimensionLine dimensions { get; set; }

        /// <summary>
        /// Shipping class slug.
        /// </summary>
        [DataMember]
        public string shipping_class { get; set; }

        /// <summary>
        /// Shipping class ID. 
        /// read-only
        /// </summary>
        [DataMember]
        public string shipping_class_id { get; set; }

        /// <summary>
        /// Variation image data. See Product variation - Image properties
        /// </summary>
        [DataMember]
        public ProductImage image { get; set; }

        /// <summary>
        /// List of attributes. See Product variation - Attributes properties
        /// </summary>
        [DataMember]
        public List<ProductVariationsAttributeLine> attributes { get; set; }

        /// <summary>
        /// Menu order, used to custom sort products.
        /// </summary>
        [DataMember]
        public int menu_order { get; set; }

        /// <summary>
        /// Meta data. See Product variation - Meta data properties
        /// </summary>
        [DataMember]
        public List<ProductVariationsAttributeLine> meta_data { get; set; }
    }
}
