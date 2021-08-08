using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoList
{
    class Day
    {
        private List<Task> TaskList = new List<Task>(){ new Task("Lopen", "Lekker wandelen"), new Task("YouTube kijken", "ff kijken")};
        public string Name { get; set; }
        public int Number { get; set; }

        public Day(string name, int number)
        {
            Name = name;
            Number = number;
        }

        public void ShowDayTasks() 
        {
            
            while(true)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("< Dag  Week  Maand  Jaar >", Console.ForegroundColor);
                Console.WriteLine($"< Gister  {this.Name}  Morgen >\n");
                Console.ForegroundColor = ConsoleColor.White;
                for (int i = 0; i < TaskList.Count; i++)
                    Console.WriteLine(TaskList[i].Name);
                Console.ReadKey();
            }
        }
        public void AddTask() 
        {
            TaskList.Add(new Task("lol", "hihi"));
        }
    }
}
