using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Tipage.Web.Models.ViewModels
{
    public class ShiftListViewModel
    {
        public List<Shift> Shifts { get; set; }
        
        /// <summary>
        /// Total amount of tips made all time.
        /// </summary>
        [Display(Name = "Total")]
        [DataType(DataType.Currency)]
        public decimal TotalTips { get; set; }
        
        /// <summary>
        /// The average of all of the shifts hourly wage.
        /// </summary>
        [Display(Name = "Average Hourly Wage")]
        [DataType(DataType.Currency)]
        public decimal AverageHourlyWage { get; set; }
    }
}