﻿using mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mvc.ViewModels.ModelosVista
{
    public class EmpleadosViewModel
    {
        public IEnumerable<Empleado> Empleados { get; set; }
        public string TituloPagina { get; set; }
        public string Subtitulo { get; set; }
    }
}
