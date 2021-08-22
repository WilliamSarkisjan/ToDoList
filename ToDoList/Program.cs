using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.Json;
using System.IO;

namespace ToDoList
{
    class Program
    {
        public TODOLIST ToDoList;
        static public int[] DayAmountPerMonth = new int[12];
        static public string[] DaysOfTheWeek = new string[7];

        public static string ShowSelectedListItem<T>(int index, List<T> List, Func<T, string> f) //Needs to be placed in a better spot
        {
            string returnString = "";
            for (int i = 0; i < List.Count; i++)
            {
                if (index == i)
                    returnString += $"[ {f(List[i])} ]\n";
                else
                    returnString += $"{f(List[i])}\n";
            }
            return returnString;
        }

        public static int InputController<T>(ConsoleKey input, int index, Action<T> f, List<T> list)
        {
            switch (input)
            {
                case ConsoleKey.UpArrow:
                    if (index > 0)
                        return --index;
                    break;
                case ConsoleKey.DownArrow:
                    if (index < list.Count - 1)
                        return ++index;
                    break;
                case ConsoleKey.Enter:
                    f(list[index]);
                    break;
                case ConsoleKey.Backspace:
                    return -1;
            }
            return index;
        }
        static void Main(string[] args)
        {
            DayAmountPerMonth[0] = 31;
            DayAmountPerMonth[1] = 28;
            DayAmountPerMonth[2] = 31;
            DayAmountPerMonth[3] = 30;
            DayAmountPerMonth[4] = 31;
            DayAmountPerMonth[5] = 30;
            DayAmountPerMonth[6] = 31;
            DayAmountPerMonth[7] = 31;
            DayAmountPerMonth[8] = 30;
            DayAmountPerMonth[9] = 31;
            DayAmountPerMonth[10] = 30;
            DayAmountPerMonth[11] = 31;

            DaysOfTheWeek[0] = "Monday";
            DaysOfTheWeek[1] = "Tuesday";
            DaysOfTheWeek[2] = "Wednesday";
            DaysOfTheWeek[3] = "Thursday";
            DaysOfTheWeek[4] = "Friday";
            DaysOfTheWeek[5] = "Saturday";
            DaysOfTheWeek[6] = "Sunday";

            Day Daag = new Day("Maandag", 2);

            //Hier kan je een datum invullen en zien welke dag van de week dat is.
            var testDag = whichDayOfTheWeek(22, 8, 2021);
            Console.WriteLine("Break point");

            //Year tweeduizendeenentwintig = new Year(2021);
            //tweeduizendeenentwintig.MonthList.Add(new Month("Januari"));
            //tweeduizendeenentwintig.MonthList.Add(new Month("Februari"));
            //tweeduizendeenentwintig.MonthList[0].DayList.Add(Daag);
            //tweeduizendeenentwintig.MonthList[1].DayList.Add(Daag);
            //File.WriteAllText("Testje.json", JsonSerializer.Serialize(tweeduizendeenentwintig));
            Daag.ShowDayTasks();
        }

        /// <summary>
        /// A year is said to be leap year if the year is exactly divisible by 4 but not divisible by 100. 
        /// Year is also a leap year if it is exactly divisible by 400.
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        public static bool isLeap(int year)
        {
            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
                return true;
            return false;
        }

        public static string whichDayOfTheWeek(int day, int month, int year)
        {
            var endMonth = 11;
            var totalDays = 0;
            for (int j = 2001; j <= year; j++)
            {
                if (j == year)
                    endMonth = month - 1;
                else
                    endMonth = 11;

                for (int i = 0; i <= endMonth; i++) //Startdate used to calculate all other dates is Monday: 1 - January - 2001.
                {
                    if (i == endMonth && j == year)
                        totalDays = totalDays + day;
                    else if (isLeap(j) && i == 1)
                        totalDays = totalDays + 29;
                    else
                        totalDays = totalDays + DayAmountPerMonth[i];
                }
            }
            totalDays--;
            return DaysOfTheWeek[totalDays % 7];
        }
    }
}
/* (dagVanWeek, beginDag){
    (datum - begindatum ) % 7

} formatstring: dd/mm/jj */ 