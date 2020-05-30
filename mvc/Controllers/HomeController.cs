using Microsoft.AspNetCore.Mvc;
using mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mvc.Controllers
{
    public class HomeController : Controller
    {
        private IEmpleadoRepository _empleadoRepository;

        public HomeController(IEmpleadoRepository empleadoRepository)
        {
            _empleadoRepository = empleadoRepository;
        }

        public string Index(string id)
        {
            
            if (!string.IsNullOrWhiteSpace(id))
            {
                
                return $"Hola {TempData["Usuario"]} : MVC .Net! {id}";
            }
            else
            {
                //Empleado empleado = new MockEmpleadoRepository().GetEmpleado(1);
                Empleado empleado = _empleadoRepository.GetEmpleado(1);
                return empleado.Nombre;
            }
        }

        public string LoQueSea()
        {
            return "ejemplo de otra acción en el controlador";
        }

        [HttpGet]
        public JsonResult JsonPrueba()
        {
            return Json(new { nombre = "Samuel", apellido = "Colmenares" });
        }

        [HttpGet]
        public IActionResult IndexEstilos()
        {
            ViewBag.Subtitulo = "Index con estilos";
            return View();
        }

        [HttpPost]
        public IActionResult IndexEstilos(string usuario)
        {
            if(!string.IsNullOrWhiteSpace(usuario) && usuario.ToLowerInvariant() == "samuel")
            {
                ViewBag.Subtitulo = "Index con estilos";
                TempData["Usuario"] = usuario;
                return RedirectToAction("Index", new { id = "viene de index estilos" });
            }
            else
            {
                ViewBag.Subtitulo = "Index con estilos Post";
                ViewBag.Detalle = "Nombre No Valido";
                return View("IndexEstilos",  usuario );
            }
        }

        public IActionResult RedireccionAccion(string id)
        {
            if(!string.IsNullOrWhiteSpace(id) && id == "loquesea")
            {
                //ViewBag.Subtitulo = "VistaRobada 2";
                
                return RedirectToAction("VistaRobada");
            }
            else
            {
                return RedirectToAction("Index", new { id = "viene de lo que sea" });
                
            }
        }

        public IActionResult VistaRobada()
        {
            //ViewBag.Subtitulo = "VistaRobada";
            ViewData["Subtitulo"] = "vista Robada view data";
            return View("IndexEstilos");
        }
    }
}
