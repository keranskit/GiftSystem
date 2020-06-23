namespace GiftSystem.Controllers
{
    using System.Threading.Tasks;
    using Data.Models;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using Models;
    using Services;

    [Authorize]
    public class TransfersController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly ICreditsService creditsService;

        public TransfersController(
            UserManager<ApplicationUser> userManager, 
            ICreditsService creditsService)
        {
            this.userManager = userManager;
            this.creditsService = creditsService;
        }

        public IActionResult Index()
        {
            return this.View();
        }

        [HttpPost]
        public async Task<string> Index(SendCreditsViewModel model)
        {
            var sender = await this.userManager.GetUserAsync(this.User);
            return await this.creditsService.TransferCredits(sender, model.ReceiverPhoneNumber, model.Credits, model.Message);
        }
    }
}
