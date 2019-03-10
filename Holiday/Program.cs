using System;

namespace Holiday
{
    public static class Program
    {
        public static void Main()
        {
            DateTime vacationDate = new DateTime(2019, 3, 17);
            DayReturning(vacationDate, 12);
            Console.ReadLine();
        }

        public static string DayReturning(DateTime date, int daysGone)
        {
            DateTime returningDate = date.AddDays(daysGone);

            return returningDate.DayOfWeek.ToString();
        }

        // TODO: Create a method that takes the day
        //you are leaving on vacation and how many days you will be
        //gone and return the name of the day of the week you will return.
    }
}