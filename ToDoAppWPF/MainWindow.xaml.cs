using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ToDoAppWPF;

namespace TodoAppWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private TodoList todoList;

        /// <summary>
        /// Initialiserar huvudfönster och TodoList instans
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            todoList = new TodoList();
        }

        /// <summary>
        /// Hanterar klickhändelse för "Lägg till uppgift"
        /// Lägger till ny uppgift om texten inte är tom
        /// </summary>
        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            string task = TaskTextBox.Text;

            if (todoList.AddTask(task))
            {
                UpdateTaskList();
                TaskTextBox.Clear();
            }
            else
            {
                MessageBox.Show("Uppgiften kan inte vara tom eller innehålla endast blanksteg.", "Fel", 
                    MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        /// <summary>
        /// Hämtar uppgifter ifrån TodoList och uppdaterar ListBox
        /// </summary>
        private void UpdateTaskList()
        {
            TasksListBox.Items.Clear();
            foreach (var task in todoList.GetAllTasks())
            {
                TasksListBox.Items.Add(task);
            }
        }

        /// <summary>
        /// Hanterar klickhändelse för "Ta bort uppgift"
        /// Tar bort den markerade uppgiften ifrån listan
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveButton_Click(object sender, RoutedEventArgs e)
        {
            int selectedIndex = TasksListBox.SelectedIndex;

            if (todoList.RemoveTask(selectedIndex))
            {
                UpdateTaskList();
            }
            else
            {
                MessageBox.Show("Ingen uppgift vald för borttagning.", "Fel", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}