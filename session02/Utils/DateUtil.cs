using System;
using System.Globalization;
using System.Text;

namespace session02.Utils
{
    public static class DateUtil
    {
        public static string MiladiToJalai(DateTime date, string seperator = "/")
        {
            //1402/11/09
            //1402-11-09
            var result = "";
            var pc = new PersianCalendar();
            var year = pc.GetYear(date);
            var month = pc.GetMonth(date);
            var day = pc.GetDayOfMonth(date);

            //String concat
            result = year + seperator + month + seperator + day;

            //string format
            result = String.Format("{0}{3}{1}{3}{2}", year, month, day, seperator);

            //string template / string interpolation
            result = $"{year}{seperator}{month}{seperator}{day}"; 


            //String builder
            var sb = new StringBuilder();
            sb.Append(year);
            sb.Append(seperator);
            sb.Append(month.ToString("0#"));
            sb.Append(seperator);
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

        public static DateTime JalaliToMilaldi(string date, string seperator = "/")
        {
            // 1402/11/09
            var parts = date.Split(seperator); // ["1402", "11", "09"]

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

        /*
         *  out
                MUST: in function : value set beshe
            ref:
                OPTIONAL: in function : value set beshe ya nashe
         */

        //touple

        public static string ToJalaliAndDays_out(DateTime date, out double days)
        {
            //SOLID Principles
            /*
                The Single-responsibility principle: "There should never be more than one reason for a class to change."[5] In other words, every class should have only one responsibility.[6]
                The Open–closed principle: "Software entities ... should be open for extension, but closed for modification."[7]
                The Liskov substitution principle: "Functions that use pointers or references to base classes must be able to use objects of derived classes without knowing it."[8] See also design by contract.[8]
                The Interface segregation principle: "Clients should not be forced to depend upon interfaces that they do not use."[9][4]
                The Dependency inversion principle: "Depend upon abstractions, [not] concretes."[10][4]
             */


            var result = "";
            var pc = new PersianCalendar();
            var year = pc.GetYear(date);
            var month = pc.GetMonth(date);
            var day = pc.GetDayOfMonth(date);

            var diff = DateTime.Now - date;
            days = Math.Floor(diff.TotalDays);

            result = $"{year}/{month}/{day}";
            return result;
        }

        public static string ToJalaliAndDays_ref(DateTime date, ref double days)
        {
            var pc = new PersianCalendar();
            var year = pc.GetYear(date);
            var month = pc.GetMonth(date);
            var day = pc.GetDayOfMonth(date);

            var diff = DateTime.Now - date;
            days = Math.Floor(diff.TotalDays);

            return $"{year}/{month}/{day}";
        }
    }
}
