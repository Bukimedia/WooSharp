
using Bukimedia.WooSharp.Entities.WooCommerce.V3;

namespace Bukimedia.WooSharp.Factories.WooCommerce.V3
{
    public class ProductFactory : GenericFactory<Product>
    {
        protected override string entityName { get { return "products"; } }

        public ProductFactory(string BaseUrl, string CustomerSecret, string CustomerKey)
            : base(BaseUrl, CustomerSecret, CustomerKey)
        {
        }
    }
}
