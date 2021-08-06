using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoList
{
    class Task
    {
        public string Name { get; set; }
        private string Description { get; set; }
        private bool Finished { get; set; }
        public Task(string name, string description)
        {
            Name = name;
            Description = description;
            //Finished = false;
        }

        public void TaskInfo() { }
        public void EditTask() { }
        public void RemoveTask() { }
    }
}
