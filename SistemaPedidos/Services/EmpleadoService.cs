using SistemaPedidos.Entities;
using System.Collections.Generic;

namespace SistemaPedidos.Services
{
    public class EmpleadoService
    {
        private List<RegistroVentasCLS> lista;

        public EmpleadoService()
        {
            lista = new List<RegistroVentasCLS>();
            lista.Add(new RegistroVentasCLS { Num_Empl = 1, Nombre = "Juan", Edad = 30, Cargo = "Desarrollador", FechaDeContrato = new DateOnly(2022, 1, 15), Cuota = 5000, Ventas = 6000 });
            lista.Add(new RegistroVentasCLS { Num_Empl = 2, Nombre = "María", Edad = 25, Cargo = "Diseñadora", FechaDeContrato = new DateOnly(2023, 5, 20), Cuota = 4500, Ventas = 5500 });
        }

        public List<RegistroVentasCLS> listarEmpleados()
        {
            return lista;
        }

        public RegistroVentasCLS obtenerEmpleado(int numEmpl)
        {
            return lista.FirstOrDefault(e => e.Num_Empl == numEmpl);
        }

        public void eliminarEmpleado(int numEmpl)
        {
            var listaQueda = lista.Where(p => p.Num_Empl != numEmpl).ToList();
            lista = listaQueda;
        }
    }
}