using RocketseatAuctionAPI.Contracts;
using RocketseatAuctionAPI.Entities;

namespace RocketseatAuctionAPI.Repositories.DataAccess;

public class OfferRepository: IOfferRepository
{
    private readonly RocketseatAuctionDbContext _dbContext;
    public OfferRepository(RocketseatAuctionDbContext dbContext) => _dbContext = dbContext;
    public void Add(Offer offers)
    {
        _dbContext.Offers.Add(offers);

        _dbContext.SaveChanges();
    }
}
