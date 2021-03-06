﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Tipage.Web.Models.ViewModels
{
    public class StatisticsViewModel
    {
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
        
        /// <summary>
        /// The average of all tips daily.
        /// </summary>
        [Display(Name = "Average Daily Tips")]
        [DataType(DataType.Currency)]
        public decimal AverageTips { get; set; }
    }
}