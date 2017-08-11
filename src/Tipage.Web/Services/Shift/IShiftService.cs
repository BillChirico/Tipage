namespace Tipage.Web.Services.Shift
{
    public interface IShiftService
    {
        decimal GetTipout(Models.Shift shift, int percentage = 10);

        double GetHoursWorked(Models.Shift shift);

        decimal GetHourlyWage(Models.Shift shift);
    }
}