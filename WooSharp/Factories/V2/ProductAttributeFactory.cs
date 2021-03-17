using Bukimedia.WooSharp.Entities.WooCommerce.V2;

namespace Bukimedia.WooSharp.Factories.WooCommerce.V2
{
    public class ProductAttributeFactory : GenericFactory<ProductAttribute>
    {
        protected override string entityName { get { return "products/attributes"; } }

        public ProductAttributeFactory(string BaseUrl, string CustomerSecret, string CustomerKey)
            : base(BaseUrl, CustomerSecret, CustomerKey)
        {
        }
    }
}
