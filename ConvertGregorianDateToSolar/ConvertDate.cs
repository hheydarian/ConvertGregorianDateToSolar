using System.Globalization;
namespace ConvertGregorianDateToSolar;
public class ConvertDate
{
    public string ToShamsiDate(DateTime date)
    {
        PersianCalendar pc = new();
        var year = pc.GetYear(date);
        var month = pc.GetMonth(date);
        var day = pc.GetDayOfMonth(date);
        return $"{year}/{month}/{day}";
    }
}
