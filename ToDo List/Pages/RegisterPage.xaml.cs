
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace ToDo_List
{
    /// <summary>
    /// Interaction logic for RegisterPage.xaml
    /// </summary>
    public partial class RegisterPage : Page
    {

        private UserList userList;
        private string currentUser;

        //constructor
        public RegisterPage(UserList userList)
        {
            InitializeComponent();
            UserList userListUsers = new UserList();
            userList = userListUsers;
            this.userList = userList;
        }

        //confirm button onclick
        private void confirmbtn_Click(object sender, RoutedEventArgs e)
        {
            string username = usertxt.Text;
            string password = passwordtxt.Password;

            //check if username and password are empty
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Username and password cannot be empty.");
                return;
            }

            //check if username is taken
            if (userList.IsUsernameTaken(username))
            {
                MessageBox.Show("Username is already registered. Choose a different username.");
                return;
            }

            //create new user
            User newUser = new User(username, password);
            userList.AddUser(newUser);

            //clear textboxes
            usertxt.Text = string.Empty;
            passwordtxt.Password = string.Empty;
            passwordrtxt.Password = string.Empty;

            //navigate to login page + show message of successful registration
            MessageBox.Show("Registration successful!");
            NavigationService.Navigate(new LoginPage(userList, currentUser));
        }

        private void usertxt_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
