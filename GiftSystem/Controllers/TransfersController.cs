namespace GiftSystem.Controllers
{
    using System.Linq;
    using System.Threading.Tasks;
    using Data;
    using Data.Models;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using ViewModels;
    using Services;

    [Authorize]
    public class TransfersController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly ICreditsService creditsService;
        private readonly ApplicationDbContext dbContext;

        public TransfersController(
            UserManager<ApplicationUser> userManager, 
            ICreditsService creditsService,
            ApplicationDbContext dbContext)
        {
            this.userManager = userManager;
            this.creditsService = creditsService;
            this.dbContext = dbContext;
        }

        public async Task<IActionResult> Index()
        {
            var user = await this.userManager.FindByNameAsync(this.User.Identity.Name);
            var model = new SendCreditsViewModel {Credits = this.dbContext.Users.FirstOrDefault(x => x.Id == user.Id).Credits};
            return this.View(model);
        }

        [HttpPost]
        public async Task<string> Index(SendCreditsViewModel model)
        {
            var sender = await this.userManager.GetUserAsync(this.User);
            return await this.creditsService.TransferCredits(sender, model.ReceiverPhoneNumber, model.Credits, model.SanitizedMessage);
        }
    }
}
