namespace GiftSystem.Services
{
    using System.Collections.Generic;
    using System.Linq;
    using Data;
    using Data.Models;
    using Microsoft.EntityFrameworkCore;

    public class TransfersService : ITransfersService
    {
        private readonly ApplicationDbContext dbContext;

        public TransfersService(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }


        public IEnumerable<Transfer> GetBySenderId(string id)
        {
            return this.dbContext.Transfers.Where(x => x.SenderId == id).Include(x => x.Receiver).ToList();
        }

        public IEnumerable<Transfer> GetByReceiverId(string id)
        {
            return this.dbContext.Transfers.Where(x => x.ReceiverId == id).Include(x => x.Sender).ToList();
        }

        public IEnumerable<Transfer> GetAll()
        {
            return this.dbContext.Transfers.ToList();
        }
    }
}
