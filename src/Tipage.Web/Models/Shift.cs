using System;

namespace Tipage.Web.Models
{
    public class Shift
    {
        /// <summary>
        /// Id of the shift.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Start of the shift.
        /// </summary>
        public DateTimeOffset Start { get; set; }

        /// <summary>
        /// End of the shift.
        /// </summary>
        public DateTimeOffset End { get; set; }

        /// <summary>
        /// Total amount of cash tips.
        /// </summary>
        public decimal CashTips { get; set; }

        /// <summary>
        /// Total amount of credit card tips.
        /// </summary>
        public decimal CreditTips { get; set; }
    }
}
