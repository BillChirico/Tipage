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
    }
}