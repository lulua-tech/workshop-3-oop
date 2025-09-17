namespace forgeblade_hr_system;

public class User()
{
    private string UserId { get; } 
    private string Email { get; } 
    private string Password { get; set; } 
    
    public User(string userId, string email, string password) : this()
    {
        UserId = userId;
        Email = email;
        Password = password;
    }
    
    public override string ToString()
    {
        return $"UserId: {UserId}, Email: {Email}, Password: {Password}";
    }
    
    public void UpdatePassword(string newPassword)
    {
        Password = newPassword;
    }
}