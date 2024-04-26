using AppTerceiro.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AppTerceiro.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            Fisica fisica = new Fisica
            {
                Id = 10,
                Nome = " Thallya Eduarda ", 
                Sexo = 'F',
                CPF = 12345678910,
                RG= 12345678,
                Dig_RG = '7'
            };
            return View(fisica);
        }

        public IActionResult Privacy()
        {
            Pessoa pessoa = new Pessoa
            {
                Id = 12,
                Nome = "Alexandre",
                Sexo = 'M'
            };

            ViewBag.Id = pessoa.Id;
            ViewBag.Nome = pessoa.Nome;
            ViewBag.Sexo = pessoa.Sexo;

            return View(pessoa);
        }
        public IActionResult Juridico() {
            Juridico juridica = new Juridico
            {
                Id = 1074,
                Nome = "Alexandre e Isaque",
                CNPJ = 123123123213123123,
                IE = 12321312312321312
            };
            return View(juridica);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
