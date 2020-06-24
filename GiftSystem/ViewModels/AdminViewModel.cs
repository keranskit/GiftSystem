namespace GiftSystem.ViewModels
{
    using Data.Models;

    using System.Collections.Generic;

    public class AdminViewModel
    {
        public IEnumerable<Transfer> Transfers { get; set; }

        public IEnumerable<ApplicationUser> Users { get; set; }
    }
}
