using RocketseatAuctionAPI.Entities;

namespace RocketseatAuctionAPI.Contracts;

public interface IUserRepository
{
    bool ExistUserWithEmail(string email);
    User GetUserByEmail(string email);
}
