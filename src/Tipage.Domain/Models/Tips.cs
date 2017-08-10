using System;
using System.Collections.Generic;
using System.Text;

namespace Tipage.Domain.Models
{
    public class Tips
    {
        public int Id { get; set; }

        public decimal CashTips { get; set; }

        public decimal CreditTips { get; set; }
    }
}
