
using Bukimedia.WooSharp.Entities.WooCommerce.V3;

namespace Bukimedia.WooSharp.Factories.WooCommerce.V3
{
    public class ProductCategoryFactory : GenericFactory<ProductCategory>
    {
        protected override string entityName { get { return "products/categories"; } }

        public ProductCategoryFactory(string BaseUrl, string CustomerSecret, string CustomerKey)
            : base(BaseUrl, CustomerSecret, CustomerKey)
        {
        }
    }
}
