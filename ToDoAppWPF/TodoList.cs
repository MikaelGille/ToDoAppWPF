using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoAppWPF
{
    public class TodoList
    {
        private List<string> tasks = new List<string>();

        public bool AddTask(string task)
        {
            if (string.IsNullOrWhiteSpace(task))
            {
                return false;
            }
            tasks.Add(task);
            return true;
        }

        public bool RemoveTask(int index)
        {
            if (index >= 0 && index < tasks.Count)
            {
                tasks.RemoveAt(index);
                return true;
            }
            return false;
        }

        public List<string> GetAllTasks()
        {
            return new List<string>(tasks);
        }
    }
}
