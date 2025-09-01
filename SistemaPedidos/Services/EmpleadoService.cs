using SistemaPedidos.Entities;
using System.Collections.Generic;
using System.Linq;
using System;

namespace SistemaPedidos.Services
{
    public class EmpleadoService
    {
        private static List<RegistroVentasCLS> lista = new List<RegistroVentasCLS>()
        {
            new RegistroVentasCLS() { Num_Empl = 1, Nombre = "Juan", Edad = 30, Cargo = "Desarrollador", FechaDeContrato = new DateOnly(2022, 1, 15), Cuota = 5000, Ventas = 6000 },
            new RegistroVentasCLS() { Num_Empl = 2, Nombre = "Maria", Edad = 25, Cargo = "Diseñadora", FechaDeContrato = new DateOnly(2023, 5, 20), Cuota = 4500, Ventas = 5500 }
        };

        public List<RegistroVentasCLS> listarEmpleados()
        {
            return lista;
        }

        public RegistroVentasCLS obtenerEmpleado(int numEmpl)
        {
            return lista.FirstOrDefault(e => e.Num_Empl == numEmpl);
        }

        public void agregarEmpleado(RegistroVentasCLS oRegistroVentasCLS)
        {
            oRegistroVentasCLS.Num_Empl = lista.Max(e => e.Num_Empl) + 1;
            lista.Add(oRegistroVentasCLS);
        }

        public void editarEmpleado(RegistroVentasCLS oRegistroVentasCLS)
        {
            var empleado = obtenerEmpleado(oRegistroVentasCLS.Num_Empl);
            if (empleado != null)
            {
                empleado.Nombre = oRegistroVentasCLS.Nombre;
                empleado.Edad = oRegistroVentasCLS.Edad;
                empleado.Cargo = oRegistroVentasCLS.Cargo;
                empleado.FechaDeContrato = oRegistroVentasCLS.FechaDeContrato;
                empleado.Cuota = oRegistroVentasCLS.Cuota;
                empleado.Ventas = oRegistroVentasCLS.Ventas;
            }
        }

        public void eliminarEmpleado(int numEmpl)
        {
            var empleado = obtenerEmpleado(numEmpl);
            if (empleado != null)
            {
                lista.Remove(empleado);
            }
        }
    }
}