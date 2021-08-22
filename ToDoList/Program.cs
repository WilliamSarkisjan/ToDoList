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
        static public Dictionary<string, int> DayAmountPerMonth = new Dictionary<string, int>();
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
            DayAmountPerMonth.Add("January", 31);
            DayAmountPerMonth.Add("February", 28);
            DayAmountPerMonth.Add("March", 31);
            DayAmountPerMonth.Add("April", 30);
            DayAmountPerMonth.Add("May", 31);
            DayAmountPerMonth.Add("June", 30);
            DayAmountPerMonth.Add("July", 31);
            DayAmountPerMonth.Add("August", 31);
            DayAmountPerMonth.Add("September", 30);
            DayAmountPerMonth.Add("October", 31);
            DayAmountPerMonth.Add("November", 30);
            DayAmountPerMonth.Add("December", 31);

            DaysOfTheWeek[0] = "Monday";
            DaysOfTheWeek[1] = "Tuesday";
            DaysOfTheWeek[2] = "Wednesday";
            DaysOfTheWeek[3] = "Thursday";
            DaysOfTheWeek[4] = "Friday";
            DaysOfTheWeek[5] = "Saturday";
            DaysOfTheWeek[6] = "Sunday";

            Day Daag = new Day("Maandag", 2);
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
    }
}
/* (dagVanWeek, beginDag){
    (datum - begindatum ) % 7

} formatstring: dd/mm/jj */ 