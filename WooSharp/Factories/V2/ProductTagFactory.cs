﻿using Bukimedia.WooSharp.Entities.WooCommerce.V2;

namespace Bukimedia.WooSharp.Factories.WooCommerce.V2
{
    public class ProductTagFactory : GenericFactory<ProductTag>
    {
        protected override string entityName { get { return "products/tags"; } }

        public ProductTagFactory(string BaseUrl, string CustomerSecret, string CustomerKey)
            : base(BaseUrl, CustomerSecret, CustomerKey)
        {
        }
    }
}
