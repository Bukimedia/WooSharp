using Bukimedia.WooSharp.Entities.WooCommerce.V2;

namespace Bukimedia.WooSharp.Factories.WooCommerce.V2
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
