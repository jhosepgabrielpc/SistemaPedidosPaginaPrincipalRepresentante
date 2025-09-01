using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace SistemaPedidos.Entities
{
    public class RegistroVentasCLS
    {
        public int Num_Empl { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "La edad es obligatoria")]
        [Range(18, 90, ErrorMessage = "La edad debe estar entre 18 y 90")]
        public int Edad { get; set; }

        [Required(ErrorMessage = "El cargo es obligatorio")]
        public string Cargo { get; set; }

        [Required(ErrorMessage = "La fecha de contrato es obligatoria")]
        [CustomValidation(typeof(RegistroVentasCLS), "ValidarFechaContrato")]
        public DateOnly FechaDeContrato { get; set; }

        public static ValidationResult ValidarFechaContrato(DateOnly fecha, ValidationContext context)
        {
            if (fecha > DateOnly.FromDateTime(DateTime.Now))
            {
                return new ValidationResult("La fecha de contratación no puede ser una fecha futura.", new[] { context.MemberName });
            }
            if (fecha.Year < 1900)
            {
                return new ValidationResult("La fecha de contratación no puede ser anterior a 1900.", new[] { context.MemberName });
            }
            return ValidationResult.Success;
        }

        [Required(ErrorMessage = "La cuota es obligatoria")]
        public int Cuota { get; set; }

        [Required(ErrorMessage = "Las ventas son obligatorias")]
        public int Ventas { get; set; }
    }
}