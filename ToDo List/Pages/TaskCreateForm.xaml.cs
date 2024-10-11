using System.Windows;
using System.Windows.Controls;


namespace ToDo_List.Pages
{
    public partial class TaskCreateForm : Page
    {
        public TaskCreateForm()
        {
            InitializeComponent();
        }

        private void TaskCreateBackButton_OnClick(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new TaskOverview());
        }
    }
}