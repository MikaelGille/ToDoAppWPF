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

        /// <summary>
        /// Använder boolean för att lägga till uppgifter i listan
        /// </summary>
        /// <param name="task">Text för uppgift</param>
        /// <returns>True om uppgiften läggs till, false om uppgiften är tom</returns>
        public bool AddTask(string task)
        {
            if (string.IsNullOrWhiteSpace(task))
            {
                return false;
            }
            tasks.Add(task);
            return true;
        }

        /// <summary>
        /// Tar bort uppgift vid angivet index om det är giltigt
        /// </summary>
        /// <param name="index">Index för uppgiften</param>
        /// <returns>True om uppgiften togs bort, false om index är ogiltigt</returns>
        public bool RemoveTask(int index)
        {
            if (index >= 0 && index < tasks.Count)
            {
                tasks.RemoveAt(index);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Hämtar en lista med alla uppgifter
        /// </summary>
        /// <returns>En ny lista med alla uppgifter</returns>
        public List<string> GetAllTasks()
        {
            return new List<string>(tasks);
        }
    }
}
