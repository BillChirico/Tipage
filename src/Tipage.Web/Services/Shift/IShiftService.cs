﻿using System.Collections.Generic;
using Tipage.Web.Models;

namespace Tipage.Web.Services.Shift
{
    public interface IShiftService
    {
        decimal GetTipout(Models.Shift shift, int percentage = 10);

        double GetHoursWorked(Models.Shift shift);

        decimal GetHourlyWage(Models.Shift shift);

        decimal GetAllTimeTips(ApplicationUser user);

        decimal GetAverageHourlyWage(List<Models.Shift> shifts);

        decimal GetAverageTips(List<Models.Shift> shifts);
    }
}