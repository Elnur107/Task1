namespace Program.Models;

class Program
{
    static void Main()
    {
        User user1 = new User("John Doe", "john.doe@example.com", "P1s@$#@!");

        user1.ShowInfo();

        string newPassword = "NewP@ssword";
        bool isValidPassword = user1.PasswordChecker(newPassword);
        Console.WriteLine($"Is the password valid? {isValidPassword}");
    }
}