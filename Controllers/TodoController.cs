using Microsoft.AspNetCore.Mvc;
using TWTodosAspNet.Contexts;
using TWTodosAspNet.Models;

namespace TWTodosAspNet.Controllers;

public class TodoController : Controller
{
    private readonly TWTodosContext _context;

    public TodoController(TWTodosContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        var todos = _context.Todos.ToList();

        return View(todos);
    }
}