﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoList
{
    class Day
    {
        private Task[] TaskList;
        private string Name; //Maandag
        private int Number;

        public Day(string name, int number)
        {
            Name = name;
            Number = number;
        }

        public void ShowDayTasks() { }
        public void AddTask() { }
    }
}