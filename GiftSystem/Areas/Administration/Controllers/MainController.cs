namespace GiftSystem.Areas.Administration.Controllers
{
    using Data.Models;
    using Services;
    using ViewModels;

    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;

    using System.Linq;

    public class MainController : AdministrationController
    {
        private readonly ITransfersService transfersService;
        private readonly UserManager<ApplicationUser> userManager;

        public MainController(
            ITransfersService transfersService, 
            UserManager<ApplicationUser> userManager)
        {
            this.transfersService = transfersService;
            this.userManager = userManager;
        }

        public IActionResult Index()
        {
            var viewModel = new AdminViewModel
            {
                Transfers = this.transfersService.GetAll(),
                Users = this.userManager.Users.ToList(),
            };
            return this.View(viewModel);
        }
    }
}
