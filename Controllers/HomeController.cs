using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


using Gerenciamento_Clientes.Models;

namespace Gerenciamento_Clientes.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }



    public IActionResult Index()
    {
        using (var context = new DemoDbContext())
        {
            var resultado = context.Clientes.FromSqlInterpolated($"EXEC dbo.Selecionar").ToList();
            return View(resultado);
        }
        // return View();
    }

    public ActionResult Editar(int id)
    {
        DemoDbContext service = new DemoDbContext();
        //Cliente clienteEncontrado = service.acharCliente(id);

        var clienteEncontrado = service.Clientes.FirstOrDefault(c => c.ClienteId.Equals(id));
        return PartialView(clienteEncontrado);
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}