using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using mvc.Models;
using mvc.Resources;
using mvc.ViewModels.ModelosVista;

namespace mvc.Controllers
{
    public class ModelosVistaController : Controller
    {
        private IEmpleadoRepository _empleadoRepository;

        public ModelosVistaController(IEmpleadoRepository empleadoRepository)
        {
            _empleadoRepository = empleadoRepository;
        }
        public IActionResult Index()
        {
            Empleado empleado = _empleadoRepository.GetEmpleado(2);
            var modelo = new IndexViewModel
            {
                Empleado = empleado,
                TituloPagina = "Detalle Empleado"
            };

            return View(modelo);
        }

        public IActionResult Empleados()
        {
            
            var modelo = new EmpleadosViewModel
            {
                Empleados = _empleadoRepository.GetAll(),
                TituloPagina = "",
                Subtitulo = ""
            };
            
            return View(modelo);
        }
    }
}
