﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mvc.Models
{
    public interface IEmpleadoRepository
    {
        Empleado GetEmpleado(int id);

        /// <summary>
        /// Obtiene todos los empleados.
        /// </summary>
        /// <returns>Lista de empleados.</returns>
        IEnumerable<Empleado> GetAll();
    }
}
