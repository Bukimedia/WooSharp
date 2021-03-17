
using Bukimedia.WooSharp.Entities.WooCommerce.V2;

namespace Bukimedia.WooSharp.Factories.WooCommerce.V2
{
    public class ProductReviewFactory : GenericFactory<ProductReview>
    {
        protected override string entityName { get { return "products/reviews"; } }

        public ProductReviewFactory(string BaseUrl, string CustomerSecret, string CustomerKey)
            : base(BaseUrl, CustomerSecret, CustomerKey)
        {
        }
    }
}
