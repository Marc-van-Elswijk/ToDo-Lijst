using System.Windows;
using System.Windows.Controls;
using ToDo_List.Classes;
using Task = ToDo_List.Classes.Task;


namespace ToDo_List.Pages
{
    public partial class TaskOverview : Page
    {
        public TaskOverview()
        {
            InitializeComponent();
            List<Board> items = new List<Board>();
            
            items.Add(new Board("Test Board 1", []));
            items.Add(new Board("Test Board 2", []));
            items.Add(new Board("Test Board 3", []));
            items.Add(new Board("Test Board 4", []));
            
            BoardListView.ItemsSource = items;
        }

        private void NewTaskButton_OnClick(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new TaskCreateForm());
        }
    }
}