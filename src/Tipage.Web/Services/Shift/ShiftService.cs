using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tipage.Web.Data;
using Tipage.Web.Models;

namespace Tipage.Web.Services.Shift
{
    public class ShiftService : IShiftService
    {
        private readonly ApplicationDbContext _context;

        public ShiftService(ApplicationDbContext _context)
        {
            this._context = _context;
        }
        
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
            var hours = GetHoursWorked(shift);

            // Prevent division by zero.
            if (hours > 0)
            {
                return shift.TotalTips / (decimal) GetHoursWorked(shift);
            }

            // Return the total tips if there was zero hours worked.
            return shift.TotalTips;
        }

        public decimal GetAllTimeTips(ApplicationUser user)
        {
            return _context.Shifts.Where(s => s.User == user).Sum(s => s.TotalTips);
        }

        public decimal GetAverageHourlyWage(List<Models.Shift> shifts)
        {
            var average = shifts.Sum(shift => GetHourlyWage(shift));

            return average / shifts.Count;
        }

        public decimal GetAverageTips(List<Models.Shift> shifts)
        {
            var average = shifts.Sum(shift => shift.TotalTips);

            return average / shifts.Count;
        }
    }
}
