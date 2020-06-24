namespace GiftSystem.ViewModels
{
    using System.Collections.Generic;
    using Data.Models;

    public class DashboardViewModel
    {
        public IEnumerable<Transfer> Received { get; set; }
        public IEnumerable<Transfer> Sent { get; set; }
    }
}
