using Bukimedia.WooSharp.Entities.WooCommerce.V3;

namespace Bukimedia.WooSharp.Factories.WooCommerce.V3
{
    public class ProductVariationsFactory : SubFactory<ProductVariations>
    {
        protected override string entityName { get { return "variations"; } }
        protected override string parentEntityName { get { return "products"; } }

        public ProductVariationsFactory(string BaseUrl, string CustomerSecret, string CustomerKey)
            : base(BaseUrl, CustomerSecret, CustomerKey)
        {
        }
    }
}
