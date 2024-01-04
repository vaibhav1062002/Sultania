// Controllers/IdentityController.cs
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using NuGet.Protocol.Plugins;
using SultaniaOil.Models.Login;

public class IdentityController : Controller
{
    private readonly LoginRepository loginRepository;

    public IdentityController()
    {
        loginRepository = new LoginRepository();
    }

    [HttpGet]
    public IActionResult Login()
    {
        return View("Login");
    }

    [HttpPost]
    public IActionResult Login(LoginEntity login)
    {
        if (loginRepository.ValidateUser(login))
        {
            HttpContext.Session.SetString("Username", login.Email);
            return View("~/Views/Dashboard/Dashboard.cshtml");
        }
        else
        {
            ViewBag.Error = "Invalid username or password";
            return View();
        }
    }


   
    public IActionResult Logout()
    {
        HttpContext.Session.Remove("Username");
        return View("Login");
    }
}
