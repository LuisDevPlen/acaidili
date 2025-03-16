using Microsoft.AspNetCore.Mvc;
using ProjectTest.Models;

namespace ProjectTest.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Página Inicial";
            return View();
        }

        public IActionResult Acai()
        {
            ViewData["Title"] = "Açaí";
            return View();
        }

        public IActionResult Bebidas()
        {
            ViewData["Title"] = "Bebidas";
            return View();
        }

        public IActionResult Tapiocas()
        {
            ViewData["Title"] = "Tapiocas";
            return View();
        }

        public IActionResult TapiocasDoces()
        {
            ViewData["Title"] = "Tapiocas Doces";
            return View();
        }

        public IActionResult Omeletes()
        {
            ViewData["Title"] = "Omeletes";
            return View();
        }

        public IActionResult Smothies()
        {
            ViewData["Title"] = "Smoothies";
            return View();
        }

        public IActionResult Massas()
        {
            ViewData["Title"] = "Massas";
            return View();
        }

        public IActionResult Wrap()
        {
            ViewData["Title"] = "Wrap";
            return View();
        }

        public IActionResult WrapDoce()
        {
            ViewData["Title"] = "Wrap Doce";
            return View();
        }

        public IActionResult Recheadinhos()
        {
            ViewData["Title"] = "Açaí-Recheadinhos";
            return View();
        }

        public IActionResult CombosEspeciais()
        {
            ViewData["Title"] = "Combos Especiais";
            return View();
        }

        public IActionResult LanchesDelight()
        {
            ViewData["Title"] = "Lanches Delight";
            return View();
        }

        public IActionResult Iogurtes()
        {
            ViewData["Title"] = "Iogurtes";
            return View();
        }

        public IActionResult Acaibatido()
        {
            ViewData["Title"] = "Açaí Batido";
            return View();
        }

        public IActionResult Panquecas()
        {
            ViewData["Title"] = "Panquecas";
            return View();
        }

        public IActionResult Casadinho()
        {
            ViewData["Title"] = "Açai-Casadinho";
            return View();
        }


        public IActionResult MilkShakeAcai()
        {
            ViewData["Title"] = "Açai-MilkShake";
            return View();
        }

        public IActionResult Catalogo()
        {
            ViewData["Title"] = "Catalogo";
            return View();
        }

        public IActionResult ListaAdicional()
        {
            var adicionais = new List<AdicionalModel>
    {
        new AdicionalModel { Nome = "Amendoim", Preco = 2.15M },
        new AdicionalModel { Nome = "Aveia com flocos finos", Preco = 2.00M },
        new AdicionalModel { Nome = "Banana", Preco = 2.50M },
        new AdicionalModel { Nome = "Brigadeiro tradicional artesanal com granulado de chocolate", Preco = 7.00M },
        new AdicionalModel { Nome = "Brigadeiro Fit Delight", Preco = 6.00M },
        new AdicionalModel { Nome = "Bis chocolate branco", Preco = 3.00M },
        new AdicionalModel { Nome = "Bis chocolate", Preco = 3.00M },
        new AdicionalModel { Nome = "Castanha", Preco = 2.90M },
        new AdicionalModel { Nome = "Chantilly tradicional", Preco = 2.50M },
        new AdicionalModel { Nome = "ChocoBall", Preco = 2.50M },
        new AdicionalModel { Nome = "Creme de avelã", Preco = 5.00M },
        new AdicionalModel { Nome = "Creme ninho fit Delight", Preco = 5.00M },
        new AdicionalModel { Nome = "Creme ninho tradicional", Preco = 4.00M },
        new AdicionalModel { Nome = "Creme de morango", Preco = 5.00M },
        new AdicionalModel { Nome = "Creme de Prestígio artesanal", Preco = 7.00M },
        new AdicionalModel { Nome = "Doce de leite", Preco = 3.00M },
        new AdicionalModel { Nome = "Farinha Láctea", Preco = 2.50M },
        new AdicionalModel { Nome = "Granola, quinoa com castanha sem glúten", Preco = 4.50M },
        new AdicionalModel { Nome = "Granola tradicional", Preco = 3.00M },
        new AdicionalModel { Nome = "Paçoca", Preco = 3.00M },
        new AdicionalModel { Nome = "Leite Condensado", Preco = 2.50M },
        new AdicionalModel { Nome = "Leite em pó - ninho", Preco = 3.00M },
        new AdicionalModel { Nome = "Leite em pó zero - ninho", Preco = 4.50M },
        new AdicionalModel { Nome = "Mel", Preco = 2.20M },
        new AdicionalModel { Nome = "Ouro branco(03un)", Preco = 5.50M },
        new AdicionalModel { Nome = "Sonho de valsa(03un)", Preco = 5.50M },
        new AdicionalModel { Nome = "Pessego em calda", Preco = 4.50M },
        new AdicionalModel { Nome = "Morango", Preco = 3.50M },
        new AdicionalModel { Nome = "Nutella", Preco = 7.00M },
        new AdicionalModel { Nome = "Whey Protein de chocolate. (Growth)", Preco = 8.50M },
        new AdicionalModel { Nome = "Whey Protein de Morango. (Growth)", Preco = 8.50M }
    };

            return View(adicionais);
        }



    }
}
