using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoList
{
    class Month
    {
        public string Name { get; set; }
        public List<Day> DayList { get; set; }

        public Month(string name)
        {
            this.Name = name;
            this.DayList = new List<Day>();
        }
    }
}
