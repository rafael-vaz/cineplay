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

        public IActionResult FilmeVingadores()
        {
            return View();
        }

         public IActionResult FilmeCoringa()
        {
            return View();
        }

        public IActionResult FilmeGladiador(){

            return View();
        }

         public IActionResult FilmeDetonaRalph(){

            return View();
        }

          public IActionResult FilmeReiLeao(){

            return View();
        }

         public IActionResult FilmeAvatar(){

            return View();
        }

        
         public IActionResult FilmeMadMax(){

            return View();
        }

          public IActionResult FilmeLigadaJustica(){

            return View();
        }

        
          public IActionResult FilmeXmen(){

            return View();
        }

        
          public IActionResult FilmeET(){

            return View();
        }

          public IActionResult FilmeGuardioesDaGalaxia(){

            return View();
        }

         public IActionResult FilmePulpFiction(){

            return View();
        }

          public IActionResult FilmeTron(){

            return View();
        }
        
          public IActionResult FilmeDeVoltaParaOFuturo(){

            return View();
        }
        
         public IActionResult FilmeAlien(){

            return View();
        }

          public IActionResult FilmeVelozeseFuriosos(){

            return View();
        }

         public IActionResult FilmeOSenhorDosAneis(){

            return View();
        }

         public IActionResult FilmeSonic(){

            return View();
        }

           public IActionResult FilmeOsFantasmasSeDivertem(){

            return View();
        }

          public IActionResult FilmeOPoderosoChefao(){

            return View();
        }

        
          public IActionResult FilmeFriday(){

            return View();
        }

          public IActionResult FilmeAlice(){

            return View();
        }

        
          public IActionResult FilmePiratasDoCaribe(){

            return View();
        }

           public IActionResult FilmeOResgateDoSoldadoRyan(){

            return View();
        }

           public IActionResult FilmeJurassicWorld(){

            return View();
        }

        public IActionResult FilmeAFantasticaFabricaDeChocolate(){

            return View();
        }

        public IActionResult FilmeJohnCarter(){

            return View();
        }

        public IActionResult FilmeJumanji(){

            return View();
        }

        public IActionResult SerieTodoMundoOdeiaOChris(){

            return View();
        }

        public IActionResult SerieUmMalucoNoPedaco(){

            return View();
        }

          public IActionResult SerieVikings(){

            return View();
        }

          public IActionResult SerieMandaloriano(){

            return View();
        }

          public IActionResult SerieBrooklyn99(){

            return View();
        }

        public IActionResult SerieLaCasaDePapel(){

            return View();
        }

        public IActionResult SerieFallingSkies(){

            return View();
        }

          public IActionResult SerieFriends(){

            return View();
        }

          public IActionResult SerieDemolidor(){

            return View();
        }

         public IActionResult SerieFrontier(){

            return View();
        }

         public IActionResult SerieHowIMetYourMother(){

            return View();
        }

        public IActionResult SerieSobrenatural(){

            return View();
        }

          public IActionResult SeriePunhoDeFerro(){

            return View();
        }

         public IActionResult SerieLukeCage(){

            return View();
        }

         public IActionResult SerieBoardwalkEmpire(){

            return View();
        }
   
         public IActionResult SerieBreakingBad(){

            return View();
        }

         public IActionResult SerieEuaPatroaeasCriancas(){

            return View();
        }

           public IActionResult SerieHellOnWheels(){

            return View();
        }

           public IActionResult SerieLost(){

            return View();
        }

           public IActionResult SerieKenaneKel(){

            return View();
        }

        public IActionResult SerieNarcos(){

            return View();
        }

         public IActionResult SeriePrisonBreak(){

            return View();
        }

        public IActionResult SerieSonsOfAnarchy(){

            return View();
        }

        public IActionResult SerieSpartacus(){

            return View();
        }

          public IActionResult SerieStarTrek(){

            return View();
        }

         public IActionResult SerieStrangerThings(){

            return View();
        }

        public IActionResult SerieTheBigBangTheory(){

            return View();
        }

         public IActionResult SerieTheWalkingDead(){

            return View();
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
