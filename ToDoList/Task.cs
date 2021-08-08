using System;
using System.Collections.Generic;
using System.Text;
using static ToDoList.Program; 


namespace ToDoList
{
    class Task
    {
        private List<string> TaskCredentials
        {
            get
            {
                var nieuwLijst = new List<string>();
                nieuwLijst.Add($"Name: {Name}");
                nieuwLijst.Add($"Description: {Description}");
                return nieuwLijst;
            }
        }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Finished { get; set; }
        public Task(string name, string description)
        {
            Name = name;
            Description = description;
            //Finished = false;
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
                indexY = InputController(userInput, indexY, x => EditAttribute(x), TaskCredentials);
            }
        }
        public void RemoveTask() { }

        public void CompleteTask() => this.Finished = true;

        public void EditAttribute(string x)
        {
            bool goOn = true;
            while (goOn)
            {
                Console.Clear();
                if(x.Contains("Name: "))
                    Console.WriteLine($"Enter the new name of the task: {Name}");
                if (x.Contains("Description: "))
                    Console.WriteLine($"Enter the new description of the task: {Name}");
                var newAttribute = Console.ReadLine();

                if (x.Contains("Name: "))
                    Name = newAttribute;
                if (x.Contains("Description: "))
                    Description = newAttribute;
                goOn = false;
            }
        }
    }
}
