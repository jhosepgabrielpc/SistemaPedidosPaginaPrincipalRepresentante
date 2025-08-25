using System.ComponentModel.DataAnnotations;

namespace SistemaPedidos.Entities
{
    public class RegistroVentasCLS
    {
        [Required(ErrorMessage = "El Número del empleado es requerido.")]
        public int Num_Empl { get; set; }

        [Required(ErrorMessage = "El Nombre del empleado es requerido.")]
        public string Nombre { get; set; } = null!;

        [Required(ErrorMessage = "La Edad del empleado es requerida.")]
        [Range(18, 100, ErrorMessage = "La Edad debe ser mayor o igual a 18.")]
        public int Edad { get; set; }

        [Required(ErrorMessage = "El Cargo del empleado es requerido.")]
        public string Cargo { get; set; } = null!;

        [Required(ErrorMessage = "La Fecha de Contrato es requerida.")]
        public DateOnly FechaDeContrato { get; set; }

        [Required(ErrorMessage = "La Cuota del empleado es requerida.")]
        [Range(0, int.MaxValue, ErrorMessage = "La Cuota debe ser un número válido.")]
        public int Cuota { get; set; }

        [Required(ErrorMessage = "Las Ventas del empleado son requeridas.")]
        [Range(0, int.MaxValue, ErrorMessage = "Las Ventas deben ser un número válido.")]
        public int Ventas { get; set; }
    }
}