namespace GiftSystem.Controllers
{
    using System.Threading.Tasks;
    using Data.Models;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using Services;
    using ViewModels;

    [Authorize]
    public class DashboardController : Controller
    {
        private readonly ITransfersService transfersService;
        private readonly UserManager<ApplicationUser> userManager;

        public DashboardController(
            ITransfersService transfersService,
            UserManager<ApplicationUser> userManager)
        {
            this.transfersService = transfersService;
            this.userManager = userManager;
        }
        public async Task<IActionResult> Index()
        {
            var userId = await this.userManager.FindByNameAsync(this.User.Identity.Name);
            var viewmodel = new DashboardViewModel
            {
                Received = this.transfersService.GetByReceiverId(userId.Id),
                Sent = this.transfersService.GetBySenderId(userId.Id),
            };
            return this.View(viewmodel);
        }
    }
}
