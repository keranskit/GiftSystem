namespace GiftSystem.Services
{
    using System.Threading.Tasks;
    using Data.Models;

    public interface ICreditsService
    {
        Task<string> TransferCredits(ApplicationUser sender, ApplicationUser receiver, int count, string message);
    }
}
