using ToDoAppWPF;
namespace TestingToDoList
{
    public class TodoListTests
    {
        private TodoList todoList = new TodoList();

        [Fact]
        public void AddTask_AddValidTask()
        {
            todoList.AddTask("Task");
            Assert.Contains("Task", todoList.GetAllTasks());
        }

        [Fact]
        public void AddTask_DoesNotAddEmptyOrNullTasks()
        {
            todoList.AddTask("");
            todoList.AddTask(null);
            Assert.Empty(todoList.GetAllTasks());
        }

        [Fact]
        public void RemoveTask_RemovesTaskAtValidIndex()
        {
            todoList.AddTask("Task to remove");
            todoList.RemoveTask(0);
            Assert.Empty(todoList.GetAllTasks());
        }

        [Fact]
        public void RemoveTask_IgnoresInvalidIndex()
        {
            todoList.AddTask("Valid Task");
            todoList.RemoveTask(10);
            Assert.Contains("Valid Task", todoList.GetAllTasks());
        }

        [Fact]
        public void GetAllTasks_ReturnsAllTasks()
        {
            todoList.AddTask("Task 1");
            todoList.AddTask("Task 2");
            Assert.Equal(2, todoList.GetAllTasks().Count);
        }
    }
}