using Bukimedia.WooSharp.Entities.WooCommerce.V3;

namespace Bukimedia.WooSharp.Factories.WooCommerce.V3
{
    public class ProductAttributeTermFactory : SubFactory<ProductAttributeTerm>
    {
        protected override string entityName { get { return "terms"; } }

        protected override string parentEntityName { get { return "products/attributes"; } }

        public ProductAttributeTermFactory(string BaseUrl, string CustomerSecret, string CustomerKey)
            : base(BaseUrl, CustomerSecret, CustomerKey)
        {
        }
    }
}
