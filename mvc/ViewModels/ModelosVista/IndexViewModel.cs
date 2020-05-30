using mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mvc.ViewModels.ModelosVista
{
    public class IndexViewModel
    {
        public Empleado Empleado { get; set; }
        public string TituloPagina { get; set; }
    }
}
