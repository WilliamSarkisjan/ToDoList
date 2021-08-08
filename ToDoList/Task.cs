using System;
using System.Collections.Generic;
using System.Text;
using static ToDoList.Program; 


namespace ToDoList
{
    class Task
    {
        private List<string> TaskCredentials = new List<string>();
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Finished { get; set; }
        public Task(string name, string description)
        {
            Name = name;
            Description = description;
            //Finished = false;
            TaskCredentials.Add($"Name: {name}");
            TaskCredentials.Add($"Description: {description}");
        }

        public string TaskInfo() => $"{this.Name}, {this.Finished}";
        
        public void EditTask() 
        {
            int indexY = 0;
            while (indexY >= 0)
            {
                Console.Clear();
                Console.WriteLine(ShowSelectedListItem(indexY, TaskCredentials, x => x + ""));
                ConsoleKey userInput = Console.ReadKey().Key;
                indexY = InputController(userInput, indexY, x => Console.Write(""), TaskCredentials);
            }
        }
        public void RemoveTask() { }

        public void CompleteTask() => this.Finished = true;
    }
}
