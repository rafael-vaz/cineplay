using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using projeto_cineplay.Models;

namespace projeto_cineplay.Controllers
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
            return View();
        }

        public IActionResult Filmes()
        {
            return View();
        }

        public IActionResult Series(){

            return View();
        }

        public IActionResult Pedidos(){
            Repositorio r = new Repositorio();
            List<Pedidos> pedidos = r.Retorna_Pedidos();  
            return View(pedidos);
        }
        
        [HttpPost]
        public IActionResult Pedidos(Pedidos p){
            
            Repositorio r = new Repositorio();
            r.Inserir_Pedidos(p);
            ViewBag.Pedidos = "Pedido realizado com sucesso!";
            return RedirectToAction("Pedidos");
        }

        public IActionResult Cadastro(){

            return View();
        }
        
        [HttpPost]
         public IActionResult Cadastro(Usuarios u){
            
            Repositorio r = new Repositorio();
            r.Inserir_Usuario(u);
            ViewBag.Cadastro = "Cadastro realizado com sucesso!";
            return View();
        }


         public IActionResult Login(){

            return View();
        }
        
        [HttpPost]
           public IActionResult Login(Usuarios usuario){
           
           Repositorio r = new Repositorio();
           Usuarios u = r.Login(usuario);
           
           if(u != null){
            
            HttpContext.Session.SetInt32("id_usuarios", u.id);
            HttpContext.Session.SetString("nome", u.nome);
            HttpContext.Session.SetString("login", u.login);
            HttpContext.Session.SetString("senha", u.senha);

            ViewBag.Login = "Login realizado com sucesso!"; 
            return RedirectToAction("Index");
            
            } 
            
            else {
            
               ViewBag.Login = "Falha no login!";  
            
            }
            return View();
        }
        
         public IActionResult Logout(){
               
            HttpContext.Session.Clear();
            return View("Index");
        }


    }
}
