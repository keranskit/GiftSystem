namespace GiftSystem.Controllers
{
    using Data.Models;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using Services;

    [Authorize]
    public class TransfersController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ICreditsService _creditsService;

        public TransfersController(
            UserManager<ApplicationUser> userManager, 
            ICreditsService creditsService)
        {
            this._userManager = userManager;
            this._creditsService = creditsService;
        }

        public IActionResult Index()
        {
            return this.View();
        }
    }
}
