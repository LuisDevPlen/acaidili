using Microsoft.AspNetCore.Mvc;

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
            ViewData["Title"] = "Recheadinhos";
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
            ViewData["Title"] = "Casadinho";
            return View();
        }
    }
}
