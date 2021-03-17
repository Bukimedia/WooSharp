using Bukimedia.WooSharp.Entities.WooCommerce.V2;

namespace Bukimedia.WooSharp.Factories.WooCommerce.V2
{
    public class ProductShippingClassFactory : GenericFactory<ProductShippingClass>
    {
        protected override string entityName { get { return "products/shipping_classes"; } }

        public ProductShippingClassFactory(string BaseUrl, string CustomerSecret, string CustomerKey)
            : base(BaseUrl, CustomerSecret, CustomerKey)
        {
        }
    }
}
