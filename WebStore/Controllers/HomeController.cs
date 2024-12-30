using Microsoft.AspNetCore.Mvc;
using WebStore.Models;

namespace WebStore.Controllers;

public class HomeController : Controller
{
    private static readonly List<Employee> _Employees = new()
    {
        new()
        {
            Id = 1,
            SurName = "Бехерев",
            FirstName = "Настойка",
            Patronymic = "Чекушкич",
            Age = 33
        },
        new()
        {
            Id = 2,
            SurName = "123",
            FirstName = "321",
            Patronymic = "213",
            Age = 44
        },
        new()
        {
            Id = 3,
            SurName = "456",
            FirstName = "654",
            Patronymic = "546",
            Age = 55
        },
    };

    public IActionResult Index()
    {
        return View(); //Content("Home controller  -  action Index");
    }

    public IActionResult SomeAction()
    {
        return View(); //Content("Home controller  -  action SomeAction");
    }


    public IActionResult Employees()
    {
        return View(_Employees);
    }

    public IActionResult Employee(int id)
    {
        var employee = _Employees.FirstOrDefault(e => e.Id == id);

        if (employee is null)
        {
            return NotFound();
        }

        return View(employee);
    }
}