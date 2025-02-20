using Microsoft.AspNetCore.Identity;

namespace Application.Models;

public class User : IdentityUser<Guid>
{
    public User(Guid id, string name, string email, string password)
    {
        Id = id;
        UserName = name;
        Email = email;
        
        var passwordHasher = new PasswordHasher<User>();
        PasswordHash = passwordHasher.HashPassword(this, password);
    }
    
}