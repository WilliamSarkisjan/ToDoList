using System;
using System.Collections;
using System.Collections.Generic;

namespace ToDoList
{
    class Program
    {
        public TODOLIST ToDoList;
        static public Dictionary<string, int> DayAmountPerMonth = new Dictionary<string, int>();

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
            Day Daag = new Day("Maandag", 2);
            Daag.ShowDayTasks();
        }
    }
}
/* (dagVanWeek, beginDag){
    (datum - begindatum ) % 7

} formatstring: dd/mm/jj */ 