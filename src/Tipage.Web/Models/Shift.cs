using System;
using System.ComponentModel.DataAnnotations;

namespace Tipage.Web.Models
{
    public class Shift
    {
        /// <summary>
        /// Id of the shift.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// User of the shift.
        /// </summary>
        public ApplicationUser User { get; set; }

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
        [Display(Name = "Cash Tips")]
        [DataType(DataType.Currency)]
        public decimal CashTips { get; set; }

        /// <summary>
        /// Total amount of credit card tips.
        /// </summary>
        [Display(Name = "Credit Tips")]
        [DataType(DataType.Currency)]
        public decimal CreditTips { get; set; }
    }
}
