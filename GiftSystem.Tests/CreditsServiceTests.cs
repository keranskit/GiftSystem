namespace GiftSystem.Tests
{
    using System;
    using System.Threading.Tasks;
    using Data;
    using Data.Models;
    using Microsoft.EntityFrameworkCore;
    using Services;
    using Xunit;

    public class CreditsServiceTests
    {
        [Fact]
        public async Task TestMultipleTask()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString()).Options;
            var dbContext = new ApplicationDbContext(options);
            var service = new CreditsService(dbContext);

            var user1 = new ApplicationUser
                {Id = "1", Credits = 50, PhoneNumber = "123456", Email = "pesho@abv.bg"};
            var user2 = new ApplicationUser
                { Id = "2", Credits = 20, PhoneNumber = "234567", Email = "gosho@abv.bg" };
            await dbContext.Users.AddAsync(user1);
            await dbContext.Users.AddAsync(user2);
            await dbContext.SaveChangesAsync();

            Assert.IsType<string>(await service.TransferCredits(user1, "234567", 10, "hello"));
            Assert.Equal("Successful", await service.TransferCredits(user1, "234567", 10, "hello"));
            Assert.Equal("Receiving user not found", await service.TransferCredits(user1, "2345678", 10, "hello"));
            Assert.Equal("Not enough credits", await service.TransferCredits(user1, "234567", 1000, "hello"));
        }
    }
}
