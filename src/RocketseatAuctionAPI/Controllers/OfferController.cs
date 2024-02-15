using Microsoft.AspNetCore.Mvc;
using RocketseatAuctionAPI.Communications.Requests;
using RocketseatAuctionAPI.Filters;
using RocketseatAuctionAPI.UseCases.Offers.CreateOffer;

namespace RocketseatAuctionAPI.Controllers;

[ServiceFilter(typeof(AuthenticationUserAttribute))]
public class OfferController: RockeatSeatAuctionBaseController
{
    [HttpPost]
    [Route("{itemId}")]
    public IActionResult CreateOffer(
        [FromRoute]int itemId,
        [FromBody] RequestCreateOfferJson request,
        [FromServices] CreateOfferUseCase useCase)
    {

        var id = useCase.Execute(itemId,request);

        return Created(string.Empty, id);
    }
}
