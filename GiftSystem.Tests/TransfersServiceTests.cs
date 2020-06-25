namespace GiftSystem.Tests
{
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Data.Models;
    using Xunit;
    using GiftSystem.Data;
    using Services;

    public class TransfersServiceTests
    {
        [Fact]
        public async Task TestMultipleTask()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString()).Options;
            var dbContext = new ApplicationDbContext(options);
            var service = new TransfersService(dbContext);

            await dbContext.Transfers.AddAsync(new Transfer { Credits = 5, ReceiverId = "pesho", SenderId = "gosho", Id = "transfer1", Message = "helloWorld" });
            await dbContext.Transfers.AddAsync(new Transfer { Credits = 5, ReceiverId = "misho", SenderId = "mitko", Id = "transfer2", Message = "helloWorld2" });
            await dbContext.Transfers.AddAsync(new Transfer { Credits = 5, ReceiverId = "ivan", SenderId = "dragan", Id = "transfer3", Message = "helloWorld3" });
            await dbContext.SaveChangesAsync();

            Assert.Equal(3, service.GetAll().Count());
            Assert.IsAssignableFrom<IEnumerable<Transfer>>(service.GetAll());
            Assert.IsType<List<Transfer>>(service.GetByReceiverId("gosho"));
            Assert.IsType<List<Transfer>>(service.GetBySenderId("pesho"));
            Assert.Empty(service.GetByReceiverId("hh"));
        }
    }
}
