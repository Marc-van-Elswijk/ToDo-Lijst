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

namespace ToDo_List
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private LoginPage loginPage;
        private UserList userList;
        private string currentUser;

        //constructor
        public MainWindow()
        {
            InitializeComponent();
            LoadingPages();
        }


        //login button onclick
        private void Loginbtn_Click(object sender, RoutedEventArgs e)
        {
            Loginbtn.Visibility = Visibility.Collapsed;
            Logoutbtn.Visibility = Visibility.Collapsed;
            NavigateToRegistration();
        }

        //loading LoginPage 
        private void LoadingPages()
        {
            loginPage = new LoginPage(userList, currentUser);
            loginPage.Visibility = Visibility.Collapsed;
            MainFrame.NavigationService.Navigate(loginPage);
        }

        //navigate to login page
        private void NavigateToRegistration()
        {
            loginPage.Visibility = Visibility.Visible;
        }

        private void Logoutbtn_Click(object sender, RoutedEventArgs e)
        {
        }
    }
}