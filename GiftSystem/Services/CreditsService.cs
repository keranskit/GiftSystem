namespace GiftSystem.Services
{
    using System.Threading.Tasks;
    using Data;
    using Data.Models;

    public class CreditsService : ICreditsService
    {
        private readonly ApplicationDbContext db;

        public CreditsService(ApplicationDbContext db)
        {
            this.db = db;
        }
        public async Task<string> TransferCredits(ApplicationUser sender, ApplicationUser receiver, int count, string message)
        {
            var sendingUser = await this.db.Users.FindAsync(sender);
            var receivingUser = await this.db.Users.FindAsync(receiver);

            if (sendingUser.Credits <= count)
            {
                return "Not enough credits";
            }
            if (receivingUser == null)
            {
                return "Receiving user not found";
            }

            sendingUser.Credits -= count;
            receivingUser.Credits += count;
            this.db.Users.Update(sendingUser);
            this.db.Users.Update(receivingUser);
            await this.db.SaveChangesAsync();
            return "Successful";
        }
    }
}
