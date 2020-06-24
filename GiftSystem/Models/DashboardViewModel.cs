using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GiftSystem.Models
{
    using Data.Models;

    public class DashboardViewModel
    {
        public IEnumerable<Transfer> Received { get; set; }
        public IEnumerable<Transfer> Sent { get; set; }
    }
}
