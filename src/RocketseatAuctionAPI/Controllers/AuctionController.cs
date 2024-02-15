using Microsoft.AspNetCore.Mvc;
using RocketseatAuctionAPI.Entities;
using RocketseatAuctionAPI.UseCases.Auctions.GetCurrent;

namespace RocketseatAuctionAPI.Controllers;

public class AuctionController : RockeatSeatAuctionBaseController
{
    [HttpGet]
    [ProducesResponseType(typeof(Auction),StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult GetActionResult([FromServices] GetCurrentAuctionUseCase useCase)
    {
        var result = useCase.Execute();

        if (result is null)
            return NoContent();

        return Ok(result);
    }
}
