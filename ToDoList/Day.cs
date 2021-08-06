using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoList
{
    class Day
    {
        private List<Task> TaskList = new List<Task>(){ new Task("Lopen", "Lekker wandelen"), new Task("YouTube kijken", "ff kijken")};
        private string Name; //Maandag
        private int Number;
        private int indexY; //Current Y position, 0 default

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
                DayTasksDisplayer(indexY);
                indexY = Program.InputController(Console.ReadKey().Key, indexY, x => x.EditTask(), TaskList);
            }
        }
        public void AddTask() 
        {
            TaskList.Add(new Task("lol", "hihi"));
        }
        public void RemoveTask(Task item) => TaskList.Remove(item);

        private void DayInputController(ConsoleKey input)
        {
            switch (input)
            {
                case ConsoleKey.UpArrow:
                    if (indexY > 0)
                        indexY--;
                    break;
                case ConsoleKey.DownArrow:
                    if (indexY < TaskList.Count - 1)
                        indexY++;
                    break;
                case ConsoleKey.Enter:
                    TaskList[indexY].EditTask();
                    break;
            }
        }
        private void DayTasksDisplayer(int indexY)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("< Day  Week  Month  Year >", Console.ForegroundColor);
            Console.WriteLine($"< Yesterday  {this.Name}  Tomorrow >\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(Program.ShowSelectedListItem(indexY, TaskList, x => x.TaskInfo()));
        }
    }
}
