using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoList
{
    class Year
    {
        public List<Month> MonthList { get; set; }
        public int Jaar { get; set; }
        public Year(int jaar)
        {
            this.Jaar = jaar;
            this.MonthList = new List<Month>();
        }
    }
}
