using Bukimedia.WooSharp.Entities.WooCommerce.V2;

namespace Bukimedia.WooSharp.Factories.WooCommerce.V2
{
    public class ProductAttributeTermFactory : GenericFactory<ProductAttributeTerm>
    {
        protected override string entityName { get { return "terms"; } }

        public ProductAttributeTermFactory(string BaseUrl, string CustomerSecret, string CustomerKey)
            : base(BaseUrl, CustomerSecret, CustomerKey)
        {
        }
    }
}
