namespace GiftSystem.Services
{
    using System.Threading.Tasks;
    using Data.Models;

    public interface ICreditsService
    {
        Task<string> TransferCredits(ApplicationUser sender, string receiverPhone, int count, string message);
    }
}
