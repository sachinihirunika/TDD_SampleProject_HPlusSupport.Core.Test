using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDD_SampleProject_HPlusSupport.Core.Test;

namespace TDD_SampleProject_HPlusSupport.Core
{
    class ShoppingCartTest
    {
        [SetUp]
        public void SetUp() { }

        [Test]
        public void ShouldReturnsArticalAddedToCart() {
            var item = new AddToCartItem()
            {
                ArticleId = 42,
                Quantity = 5
            };
            var request = new AddToCartItem()
            {
                Item = item
            };

            var mockManager = new Mock<IShoppingCartManager>();
            //var manager = new ShoppingCartManager();
            //AddToCartItemResponse response = manager.AddToCart(request);
            mockManager.Setup(manager => manager.AddToCart(It.IsAny<AddToCartItem>())).Returns((AddToCartItem request)=> new AddToCartRespose(){
                Item = new AddToCartItem[] { request.Item }}
            );

            AddToCartItemResponse response = mockManager.Object.AddToCart(request);
            Assert.IsNotNull(response);
            Assert.Contains(item, response.Items);
        }

        [Test]
        public void ShouldReturnsCombinedArticlesAddedToCart()
        {
            var item = new AddToCartItem()
            {
                ArticleId = 42,
                Quantity = 5
            };
            var request = new AddToCartItem()
            {
                Item = item
            };
            var item2 = new AddToCartItem()
            {
                ArticleId = 40,
                Quantity = 6
            };
            var request2 = new AddToCartItem()
            {
                Item = item2
            };
            var manager = new ShoppingCartManager();

            AddToCartItemResponse response = manager.AddToCart(request);
            Assert.IsNotNull(response);
            Assert.That(Array.Exists(response.Items, item => item.ArticleId == 42 && item.Quantity == 15));
        }
        [Test]
        public void ShouldReturnsArticlesAddedToCart()
        {
            var item = new AddToCartItem()
            {
                ArticleId = 42,
                Quantity = 5
            };
            var request = new AddToCartItem()
            {
                Item = item
            };
            var item2 = new AddToCartItem()
            {
                ArticleId = 40,
                Quantity = 6
            };
            var request2 = new AddToCartItem()
            {
                Item = item2
            };
            var manager = new ShoppingCartManager();

            AddToCartItemResponse response = manager.AddToCart(request);
            Assert.IsNotNull(response);
            Assert.Contains(item, response.Items);
        }


    }
}
