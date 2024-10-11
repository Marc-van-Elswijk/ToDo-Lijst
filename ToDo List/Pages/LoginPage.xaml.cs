using System.IO.Packaging;
using System.Security.Cryptography.X509Certificates;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ToDo_List.Pages;

namespace ToDo_List
{
    /// <summary>
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        private UserList userList;
        private RegisterPage registerPage;
        private string CurrentUser;
        private TaskOverview taskOverview;


        //constructor
        public LoginPage(UserList userList, string currentUser)
        {
            InitializeComponent();
            LoadingPages();
            this.userList = userList;
            CurrentUser = currentUser;
        }

        //loading pages
        private void LoadingPages()
        {
            registerPage = new RegisterPage(userList);
            taskOverview = new TaskOverview();

            registerPage.Visibility = Visibility.Collapsed;
        }

        private void usernametxt_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        //register button onclick
        private void registerbtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new RegisterPage(userList));

        }

        //login button onclick
        private void loginbtn_Click(object sender, RoutedEventArgs e)
        {
            string enteredUsername = usernametxt.Text;
            string enteredPassword = password.Password;
            string tempEnteredUsername = enteredUsername;
            string CurrentUser = enteredUsername;
            

            if (userList == null)
            {
                MessageBox.Show("Register yourself before you login");
            }
            else
            {
                User userToLogin = userList.RegisteredUsers.FirstOrDefault(user => user.RegisteredUsername == tempEnteredUsername);

                //if username and password are correct
                if (userToLogin != null && userToLogin.Authenticate(enteredPassword))
                {
                    MessageBox.Show("Login successful!");
                    NavigationService.Navigate(new MainWindow());
                }

                //else if they are incorrect
                else
                {
                    MessageBox.Show("Invalid username or password. Please try again.");
                }
            }
        }
    }
}
