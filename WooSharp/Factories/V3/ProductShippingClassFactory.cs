
using Bukimedia.WooSharp.Entities.WooCommerce.V3;

namespace Bukimedia.WooSharp.Factories.WooCommerce.V3
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
