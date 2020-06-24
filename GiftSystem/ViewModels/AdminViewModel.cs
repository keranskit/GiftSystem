namespace GiftSystem.ViewModels
{
    using System.Collections.Generic;
    using Data.Models;

    public class AdminViewModel
    {
        public IEnumerable<Transfer> Transfers { get; set; }

        public IEnumerable<ApplicationUser> Users { get; set; }
    }
}
