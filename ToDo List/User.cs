public class User
{
    public string RegisteredUsername { get; private set; }
    private string RegisteredPassword { get; set; }

    public User(string registeredUsername, string registeredPassword)
    {
        RegisteredUsername = registeredUsername ?? throw new ArgumentNullException(nameof(registeredUsername));
        RegisteredPassword = registeredPassword ?? throw new ArgumentNullException(nameof(registeredPassword));
    }

    public bool Authenticate(string enteredPassword)
    {
        return RegisteredPassword == enteredPassword;
    }
}