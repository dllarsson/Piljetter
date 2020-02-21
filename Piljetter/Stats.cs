using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piljetter
{
    public class Stats
    {
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public int TotalPrice { get; set; }
        public int TotalTickets { get; set; }
        public decimal Profits { get; set; }
        public decimal Income { get; set; }
        public decimal VenueCost { get; set; }
        public decimal Pesetas { get; set; }
        public int NumberOfTicketsToSellToBreakEven { get; set; }
        public int TicketsSold { get; set; }

    }
}
