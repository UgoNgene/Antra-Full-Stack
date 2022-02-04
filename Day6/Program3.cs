using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithMethods
{
    class Program3
    {
        public static HashSet<int> holidays = new HashSet<int>();
        static void populateHolidays()
        {
            holidays.Add(new DateTime(2001, 1, 1).DayOfYear);
            holidays.Add(new DateTime(2001, 1, 18).DayOfYear);
            holidays.Add(new DateTime(2001, 1, 20).DayOfYear);
            holidays.Add(new DateTime(2001, 2, 15).DayOfYear);
            holidays.Add(new DateTime(2001, 5, 31).DayOfYear);
            holidays.Add(new DateTime(2001, 6, 18).DayOfYear);
            holidays.Add(new DateTime(2001, 7, 5).DayOfYear);
            holidays.Add(new DateTime(2001, 8, 6).DayOfYear);
            holidays.Add(new DateTime(2001, 10, 11).DayOfYear);
            holidays.Add(new DateTime(2001, 11, 11).DayOfYear);
            holidays.Add(new DateTime(2001, 11, 25).DayOfYear);
            holidays.Add(new DateTime(2001, 12, 24).DayOfYear);
        }

        static bool IsLeap(int year)
        {
            return (year % 4 == 0 && year % 100 != 0) || year % 400 == 0;
        }

        static int[] DateToInt(String s_date)
        {
            s_date = s_date.Trim('/');
            string[] dates = s_date.Split("-");
            int[] dateNums = new int[3];

            for (int i = 0; i<dates.Length; i++) {
                dateNums[i] = int.Parse(dates[i]);
            }

            return dateNums;
        }

        static void GetWorkDays(DateTime start, DateTime end)
        {
            populateHolidays();
            int totalDays = 0;
            DateTime temp = start;

            for ( var date = start; date <= end; date = date.AddDays(1))
            {
                                
                if(date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
                {
                    continue;
                }
                
                if (holidays.Contains(date.DayOfYear))
                {
                    continue;
                }
                totalDays++;
            }

            if (IsLeap(start.Year) && start.Date > new DateTime(start.Year,2,28)) { totalDays++; }
            if (IsLeap(end.Year) && end.Date < new DateTime(end.Year, 2, 29)) { totalDays--; }

            Console.WriteLine("Total: "+ totalDays + " Workdays");
        }
        
        static void Main(string[] args)
        {
            
            int[] dateFrom =  DateToInt("/4-20-2022/");
            DateTime start = new DateTime(dateFrom[2], dateFrom[0], dateFrom[1]);

            int[] dateTo = DateToInt("/1-23-2023/");
            DateTime end = new DateTime(dateTo[2], dateTo[0], dateTo[1]);

            GetWorkDays(start, end);

        }
    }
}
