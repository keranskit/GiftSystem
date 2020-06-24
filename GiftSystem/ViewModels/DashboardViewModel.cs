namespace GiftSystem.ViewModels
{
    using Data.Models;

    using System.Collections.Generic;

    public class DashboardViewModel
    {
        public IEnumerable<Transfer> Received { get; set; }
        public IEnumerable<Transfer> Sent { get; set; }
    }
}
