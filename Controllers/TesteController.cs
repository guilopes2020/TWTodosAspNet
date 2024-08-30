using Microsoft.AspNetCore.Mvc;

namespace TWTodosAspNet.Controllers;

public class TesteController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Teste2()
    {
        return View();
    }
}