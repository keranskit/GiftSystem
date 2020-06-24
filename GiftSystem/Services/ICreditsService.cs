namespace GiftSystem.Services
{
    using Data.Models;

    using System.Threading.Tasks;

    public interface ICreditsService
    {
        Task<string> TransferCredits(ApplicationUser sender, string receiverPhone, int count, string message);
    }
}
