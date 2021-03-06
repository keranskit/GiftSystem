﻿namespace GiftSystem.Services
{
    using Data;
    using Data.Models;

    using System;
    using System.Threading.Tasks;

    using Microsoft.EntityFrameworkCore;

    public class CreditsService : ICreditsService
    {
        private readonly ApplicationDbContext db;

        public CreditsService(ApplicationDbContext db)
        {
            this.db = db;
        }

        public async Task<string> TransferCredits(ApplicationUser sender, string receiverPhone, int count, string message)
        {
            var sendingUser = await this.db.Users.FindAsync(sender.Id);
            var receivingUser = await this.db.Users.FirstOrDefaultAsync(x => x.PhoneNumber == receiverPhone);

            if (receivingUser == null)
            {
                return "Receiving user not found";
            }
            if (sendingUser.Credits <= count)
            {
                return "Not enough credits";
            }

            sendingUser.Credits -= count;
            receivingUser.Credits += count;
            this.db.Users.Update(sendingUser);
            this.db.Users.Update(receivingUser);

            var transfer = new Transfer
            {
                Id = Guid.NewGuid().ToString(),
                Message = message,
                SenderId = sender.Id,
                ReceiverId = receivingUser.Id,
                Credits = count
            };
            await this.db.Transfers.AddAsync(transfer);
            await this.db.SaveChangesAsync();

            return "Successful";
        }
    }
}
