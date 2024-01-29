using System;
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

        public static string GetJalaliMonthName(DateTime date)
        {
            //if-else/switch/array/pattern matching

            var pc = new PersianCalendar();
            var month = pc.GetMonth(date);
            //switch (month)
            //{
            //    case 1: return "فروردین";
            //    case 2:return "اردیبهشت";
            //    case 3:
            //        return "خرداد";
            //    case 4:
            //        return "تیر";
            //    case 5:
            //        return "مرداد";
            //    case 6:
            //        return "شهریور";
            //    case 7:
            //        return "مهر";
            //    case 8:
            //        return "آبان";
            //    case 9:
            //        return "آذر";
            //    case 10:
            //        return "دی";
            //    case 11:
            //        return "بهمن";
            //    case 12:
            //        return "اسفند";
            //    default: throw new Exception("Wrong DATE!!");
            //}


            return month switch
            {
                1 => "فروردین",
                2 => "اردیبهشت",
                3 => "خرداد",
                4 => "تیر",
                5 => "مرداد",
                6 => "شهریور",
                7 => "مهر",
                8 => "آبان",
                9 => "آذر",
                10 => "دی",
                11 => "بهمن",
                12 => "اسفند",
                _ => throw new Exception("Wrong DATE!!"),
            };
        }

        public static string GetJalaliMonthName_array(DateTime date)
        {

            var pc = new PersianCalendar();
            var month = pc.GetMonth(date);
            var monthNames = new List<string>() {
                "فروردین", "اردیبهشت", "خرداد",
                "تیر", "مرداد",  "شهریور",
                "مهر", "آبان", "آذر",
                "دی", "بهمن", "اسفند"
            };
            return monthNames[month - 1];
        }

        public static string GetJalaliSeasonName(DateTime date)
        {
            //if-else/switch/array/pattern matching
            var pc = new PersianCalendar();
            var month = pc.GetMonth(date);
            //switch (month)
            //{
            //    case 1:
            //    case 2:
            //    case 3: return "بهار";
            //    case 4:
            //    case 5:
            //    case 6: return "تابستان";
            //    case 7:
            //    case 8:
            //    case 9: return "پاییز";
            //    case 10:
            //    case 11:
            //    case 12: return "زمستان";
            //    default: throw new Exception("Wrong DATE!!");
            //}

            //switch (month)
            //{
            //    case 1:
            //    case 2:
            //    case 3: return "بهار";
            //    case 4:
            //    case 5:
            //    case 6: return "تابستان";
            //    case 7:
            //    case 8:
            //    case 9: return "پاییز";        
            //    default: return "زمستان";
            //}




            //return month switch
            //{
            //    1 => "بهار",
            //    2 => "بهار",
            //    3 => "بهار",
            //    4 => "تابستان",
            //    5 => "تابستان",
            //    6 => "تابستان",
            //    7 => "پاییز",
            //    8 => "پاییز",
            //    9 => "پاییز",
            //    _ => "زمستان",
            //};

            //pattern
            //return month switch
            //{
            //    1 or 2 or 3 => "بهار",
            //    4 or 5 or 6 => "تابستان",
            //    7 or 8 or 9 => "پاییز",
            //    _ => "زمستان",
            //};

            return month switch
            {
                var m when m <= 3 => "بهار",
                var m when m <= 6 => "تابستان",
                var m when m <= 9 => "پاییز",
                _ => "زمستان",
            };
        }

        public static DateTime JalaliToMilaldi(string date)
        {
            // 1402/11/09
            var parts = date.Split('/'); // ["1402", "11", "09"]

            var year = Convert.ToInt32(parts[0]);
            var month = Convert.ToInt32(parts[1]);
            var day = Convert.ToInt32(parts[2]);

            //linq
            //["1402", "11", "09"] -> [1402, 11, 09]
            var newParts = parts.Select(x => Convert.ToInt32(x)).ToList();
            var year2 =newParts[0];
            var month2 = newParts[1];
            var day2 =newParts[2];

            return new DateTime(year, month, day, new PersianCalendar());
        }
    }
}
