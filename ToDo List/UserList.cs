public class UserList
{
    private List<User> registeredUsers = new List<User>();

    public IReadOnlyList<User> RegisteredUsers => registeredUsers.AsReadOnly();

    public bool IsUsernameTaken(string username)
    {
        return registeredUsers.Any(user => user.RegisteredUsername == username);
    }

    public void AddUser(User user)
    {
        if (user == null)
            throw new ArgumentNullException(nameof(user));

        registeredUsers.Add(user);
    }
}