using RocketseatAuctionAPI.Contract;
using RocketseatAuctionAPI.Entities;

namespace RocketseatAuctionAPI.UseCases.Auctions.GetCurrent;

public class GetCurrentAuctionUseCase
{
    private readonly IAuctionRepository _repository;
    public GetCurrentAuctionUseCase(IAuctionRepository repository) => _repository = repository;
    public Auction? Execute() => _repository.GetCurrent();
    
}
