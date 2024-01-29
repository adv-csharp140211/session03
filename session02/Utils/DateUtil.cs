using System.Globalization;
using System.Text;

namespace session02.Utils
{
    public static class DateUtil
    {
        public static string MiladiToJalai(DateTime date)
        {
            var result = "";
            var pc = new PersianCalendar();
            var year = pc.GetYear(date);
            var month = pc.GetMonth(date);
            var day = pc.GetDayOfMonth(date);

            //String concat
            result = year + "/" + month + "/" + day;

            //string format
            result = String.Format("{0}/{1}/{2}", year, month, day);

            //string template / string interpolation
            result = $"{year}/{month}/{day}";


            //String builder
            var sb = new StringBuilder();
            sb.Append(year);
            sb.Append("/");
            sb.Append(month.ToString("0#"));
            sb.Append("/");
            sb.Append(day.ToString("0#"));
            result = sb.ToString();

            return result;
        }
    }
}
