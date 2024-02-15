using Bogus;
using FluentAssertions;
using Moq;
using RocketseatAuctionAPI.Communications.Requests;
using RocketseatAuctionAPI.Contract;
using RocketseatAuctionAPI.Contracts;
using RocketseatAuctionAPI.Entities;
using RocketseatAuctionAPI.Services;
using RocketseatAuctionAPI.UseCases.Auctions.GetCurrent;
using RocketseatAuctionAPI.UseCases.Offers.CreateOffer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace UseCases.Test.Offers;
public class CreateOfferUseCaseTest
{
    [Theory]
    [InlineData(1)]
    [InlineData(2)]
    [InlineData(3)]
    public void Success(int itemId)
    {
        //Arrange

        var request = new Faker<RequestCreateOfferJson>()
            .RuleFor(request => request.Price, f => f.Random.Decimal(1, 700)).Generate();



        var offerRepository = new Mock<IOfferRepository>();
        var loggedUser = new Mock<ILoggedUser>();
        loggedUser.Setup(i => i.User()).Returns(new User());
                
        var useCase = new CreateOfferUseCase(loggedUser.Object,offerRepository.Object);

        //Act
        var act = () => useCase.Execute(itemId, request);

        //Assert
        act.Should().NotThrow();

    }
}
