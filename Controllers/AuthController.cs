using Microsoft.AspNetCore.Mvc;
using ASP_Platzi.Models;
namespace ASP_Platzi.Controllers;

public class AuthController: Controller
{
    public static User user = new User();

    [HttpPost]
    public IActionResult Register(UserDto request)
    {
        string passwordHash = BCrypt.Net.BCrypt.HashPassword(request.Password);
        user.Username = request.Username;
        user.PasswordHash = passwordHash;

        return Ok(user);
    }

    public IActionResult Login(UserDto request)
    {
        if (user.Username != request.Username)
        {
            return BadRequest("User not found");
        }


        if (!BCrypt.Net.BCrypt.Verify(request.Password, user.PasswordHash))
        {
            return BadRequest("Wrong password");
        }

        return Ok(user);
    }
}