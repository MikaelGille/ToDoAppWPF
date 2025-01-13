using ToDoAppWPF;
namespace TestingToDoList
{
    public class TodoListTests
    {
        private TodoList todoList = new TodoList();

        [Fact]
        // Testar att en giltig uppgift läggs till i listan
        public void AddTask_AddValidTask()
        {
            todoList.AddTask("Task");
            Assert.Contains("Task", todoList.GetAllTasks());
        }

        [Fact]
        // Testar att tomma värden inte läggs till i listan
        public void AddTask_DoesNotAddEmptyOrNullTasks()
        {
            todoList.AddTask("");
            todoList.AddTask(null);
            Assert.Empty(todoList.GetAllTasks());
        }

        [Fact]
        // Testar att en uppgift tas bort från listan vid giltigt index
        public void RemoveTask_RemovesTaskAtValidIndex()
        {
            todoList.AddTask("Task to remove");
            todoList.RemoveTask(0);
            Assert.Empty(todoList.GetAllTasks());
        }

        [Fact]
        // Testar att programmet ignorerar ett ogiltigt index
        public void RemoveTask_IgnoresInvalidIndex()
        {
            todoList.AddTask("Valid Task");
            todoList.RemoveTask(10);
            Assert.Contains("Valid Task", todoList.GetAllTasks());
        }

        [Fact]
        // Testar att alla uppgifter returneras ifrån listan
        public void GetAllTasks_ReturnsAllTasks()
        {
            todoList.AddTask("Task 1");
            todoList.AddTask("Task 2");
            Assert.Equal(2, todoList.GetAllTasks().Count);
        }
    }
}