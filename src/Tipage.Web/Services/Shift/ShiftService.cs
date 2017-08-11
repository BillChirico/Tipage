using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tipage.Web.Services.Shift
{
    public class ShiftService : IShiftService
    {
        public decimal GetTipout(Models.Shift shift, int percentage = 10)
        {
            return Math.Round((shift.TotalTips * percentage) / 100, 2, MidpointRounding.AwayFromZero);
        }

        public double GetHoursWorked(Models.Shift shift)
        {
            return (shift.End - shift.Start).TotalHours;
        }

        public decimal GetHourlyWage(Models.Shift shift)
        {
            return shift.TotalTips / (decimal)GetHoursWorked(shift);
        }
    }
}
