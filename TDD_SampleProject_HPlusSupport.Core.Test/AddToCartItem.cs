namespace TDD_SampleProject_HPlusSupport.Core
{
    public class AddToCartItem
    {
        public AddToCartItem()
        {
        }

        public int ArticleId { get; set; }
        public int Quantity { get; set; }
        public AddToCartItem Item { get; internal set; }
    }
}