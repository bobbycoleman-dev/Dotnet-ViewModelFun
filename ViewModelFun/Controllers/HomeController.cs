using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ViewModelFun.Models;

namespace ViewModelFun.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }



    [HttpGet("")]
    public IActionResult Index()
    {
        Message NewMessage = new()
        {
            DisplayMessage = "This is a message to be displayed on the page"
        };
        return View(NewMessage);
    }

    [HttpGet("numbers")]
    public IActionResult Numbers()
    {
        Number NewNumber = new();
        return View(NewNumber);
    }

    [HttpGet("user")]
    public new IActionResult User()
    {
        User NewUser = new()
        {
            Name = "Bobby Coleman"
        };
        return View(NewUser);
    }

    [HttpGet("users")]
    public IActionResult Users()
    {
        List<User> UsersList = new();
        User User0 = new() { Name = "Bobby Coleman" };
        User User1 = new() { Name = "Neil Gaiman" };
        User User2 = new() { Name = "Terry Pratchet" };
        User User3 = new() { Name = "Jane Austen" };
        User User4 = new() { Name = "Stephen King" };
        User User5 = new() { Name = "Mary Shelley" };
        UsersList.Add(User0);
        UsersList.Add(User1);
        UsersList.Add(User2);
        UsersList.Add(User3);
        UsersList.Add(User4);
        UsersList.Add(User5);

        return View(UsersList);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
