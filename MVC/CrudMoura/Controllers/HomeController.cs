using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CrudMoura.Models;

namespace CrudMoura.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

 //acao padrao inicial
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult MinhaAcao()
    {
        return View();// retorne a pagina MinhaAcao.cshtml
    }

    public IActionResult ListarNomes()
    {   
        //Cria um array de nomes ja preenchido
        string[] nomes = {"Ellen", "Rafaela", "Luisa", "Victor", "Eder", "Rosa"};
         ViewBag.Teste = "Olá, eu vim através da Viewbag";
         ViewBag.nomes = nomes;//guarda os nomes na viewbag

        return View();
    }
    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
