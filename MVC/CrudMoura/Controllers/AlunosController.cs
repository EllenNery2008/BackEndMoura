using Microsoft.AspNetCore.Mvc;
using CrudMoura.Models;

namespace CrudMoura.Controllers
{

    public class AlunosController : Controller
    {
        private readonly ILogger<AlunosController> _logger;

        public static List<Aluno> ListaDeAlunos = new List<Aluno>
        {
            new Aluno{Id = 1, Nome = "Camile"},
            new Aluno{Id = 2, Nome = "Isabely"},
            new Aluno{Id = 3, Nome = "Yuna"},
        };

        public AlunosController(ILogger<AlunosController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ListarAlunos()
        {
            ViewBag.Alunos = ListaDeAlunos;
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpGet]
        public IActionResult CreateAlunos()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SalvarAluno(Aluno alunoCadastrada)
        {
            alunoCadastrada.Id = ListaDeAlunos.Max(f => f.Id) + 1;

            ListaDeAlunos.Add(alunoCadastrada);

            return RedirectToAction(nameof(ListarAlunos));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}