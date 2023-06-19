using Dapr;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Contracts;

namespace DaprShop.Recommendation.API.Controllers
{
    [ApiController]
    [Route("api/recommendations")]
    public class RecommondetionController : ControllerBase
    {
        private const string PubsubName = "pubsub";
        private const string TopicNameOfShoppingCartItems = "daprshop.shoppingcart.items";

        [Topic(PubsubName, TopicNameOfShoppingCartItems)]
        [Route("products")]
        [HttpPost]
        public ActionResult AddProduct(Contracts.ProductItemAddedToShoppingCartEvent productItemAddedToShoppingCartEvent)
        {
            Console.WriteLine($"New product has been added into shopping cart. Product Id: {productItemAddedToShoppingCartEvent.ProductId} User Id: {productItemAddedToShoppingCartEvent.UserId}");

            return Ok();
        }
    }
}
