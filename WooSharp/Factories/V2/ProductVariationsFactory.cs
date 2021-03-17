using Bukimedia.WooSharp.Entities.WooCommerce.V2;

namespace Bukimedia.WooSharp.Factories.WooCommerce.V2
{
    public class ProductVariationsFactory : GenericFactory<ProductVariations>
    {
        protected override string entityName { get { return "variations"; } }

        public ProductVariationsFactory(string BaseUrl, string CustomerSecret, string CustomerKey)
            : base(BaseUrl, CustomerSecret, CustomerKey)
        {
        }
    }
}
