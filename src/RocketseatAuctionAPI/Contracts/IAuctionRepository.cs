using RocketseatAuctionAPI.Entities;

namespace RocketseatAuctionAPI.Contract;

public interface IAuctionRepository
{
    Auction? GetCurrent();
}
