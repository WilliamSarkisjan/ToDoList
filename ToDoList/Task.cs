using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoList
{
    class Task
    {
        private string Name;
        private string Description;
        private bool Finished;
        public Task(string name, string description)
        {
            Name = name;
            Description = description;
            //Finished = false;
        }

        public string TaskInfo() => $"{this.Name}, {this.Finished}";
        
        public void EditTask() 
        { 
            /* 
            Edit task
            - Task name         (index 0)
            - Task Description  (index 1)
             
             
             
            */


        }
        public void RemoveTask() { }

        public void CompleteTask() => this.Finished = true;
    }
}
