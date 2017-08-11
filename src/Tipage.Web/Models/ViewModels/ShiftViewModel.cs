using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tipage.Web.Models.ViewModels
{
    public class ShiftViewModel
    {
        public Shift Shift { get; set; }

        /// <summary>
        /// Amount to tipout the bussers.
        /// </summary>
        [Display(Name = "Bussers Tipout")]
        [DataType(DataType.Currency)]
        public decimal BusserTipout { get; set; }

        /// <summary>
        /// Amount to tipout the food runner.
        /// </summary>
        [Display(Name = "Runner Tipout")]
        [DataType(DataType.Currency)]
        public decimal RunnerTipout { get; set; }

        /// <summary>
        /// Amount made per hour.
        /// </summary>
        [Display(Name = "Hourly Wage")]
        [DataType(DataType.Currency)]
        public decimal HourlyWage { get; set; }
    }
}
