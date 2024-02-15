using RocketseatAuctionAPI.Entities;

namespace RocketseatAuctionAPI.Contracts;

public interface IOfferRepository
{
    void Add(Offer offer);
}
