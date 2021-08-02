using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoList
{
    class Task
    {
        public string Name;
        private string Description;
        private bool Finished;
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
