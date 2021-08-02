using System;
using System.Collections;
using System.Collections.Generic;

namespace ToDoList
{
    class Program
    {
        public TODOLIST ToDoList;
        static public Dictionary<string, int> DayAmountPerMonth = new Dictionary<string, int>();
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
        }
    }
}
/* (dagVanWeek, beginDag){
    (datum - begindatum ) % 7

} formatstring: dd/mm/jj */ 