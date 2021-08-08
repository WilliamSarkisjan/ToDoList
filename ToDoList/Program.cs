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
        public Dictionary<string, int> DayAmountPerMonth;
        static void Main(string[] args)
        {
            var JSONoptions = new JsonSerializerOptions
            {
                WriteIndented = true,
            };

            Year tweeduizendeenentwintig = new Year(2021);
            Day Daag = new Day("Maandag", 2);
            tweeduizendeenentwintig.MonthList.Add(new Month("Januari"));
            tweeduizendeenentwintig.MonthList.Add(new Month("Februari"));
            tweeduizendeenentwintig.MonthList[0].DayList.Add(Daag);
            tweeduizendeenentwintig.MonthList[1].DayList.Add(Daag);
            File.WriteAllText("Testje.json", JsonSerializer.Serialize(tweeduizendeenentwintig, JSONoptions));
            Daag.ShowDayTasks();
        }
    }
}
/* (dagVanWeek, beginDag){
    (datum - begindatum ) % 7

} formatstring: dd/mm/jj */ 