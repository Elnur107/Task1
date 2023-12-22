using System;

namespace Program.Models;

public interface IAccount
{
    bool PasswordChecker(string password);
    void ShowInfo();
}

public class User : IAccount
{
    private static int _idCounter = 1;

    public int Id { get; }
    public string Fullname { get; }
    public string Email { get; }
    private string Password { get; }

    public User(string fullname, string email, string password)
    {
        Id = _idCounter++;
        Fullname = fullname;
        Email = email;

        if (IsValidPassword(password))
            Password = EncryptPassword(password);
        else
            throw new ArgumentException("Invalid password");
    }

    public bool PasswordChecker(string password)
    {
        return IsValidPassword(password);
    }

    public void ShowInfo()
    {
        Console.WriteLine($"ID: {Id}\nFullname: {Fullname}\nEmail: {Email}");
    }

    private bool IsValidPassword(string password)
    {
        return password.Length >= 8 &&
               password.Any(char.IsUpper) &&
               password.Any(char.IsLower) &&
               password.Any(char.IsDigit);
    }

    private string EncryptPassword(string password)
    {
        return password;
    }
}

