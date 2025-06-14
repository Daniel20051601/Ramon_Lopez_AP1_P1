using System.ComponentModel.DataAnnotations;

namespace Ramon_Lopez_AP1_P1.Models;

public class Aportes
{
    [Key]
    public int AporteId { get; set; }

    public DateTime fecha { get; set; } = DateTime.Now;

    [Required(ErrorMessage = "El campo Monto es obligatorio.")]
    [Range(1.00, 1000000.00, ErrorMessage = "El monto debe ser mayor que 0 y menor que 1,000,000")]
    public decimal Monto { get; set; }

    [Required(ErrorMessage = "El campo Nombre es obligatorio.")]
    [StringLength(100, ErrorMessage = "El nombre no puede exceder los 100 caracteres.")]
    [RegularExpression(@"^(?=.*[a-zA-Z\u00C0-\u017F])[a-zA-Z\u00C0-\u017F\s.'-]+$",
                       ErrorMessage = "El nombre debe contener al menos una letra y solo puede incluir letras, espacios, apóstrofes, puntos y guiones (incluyendo acentos).")]
    public string Nombre { get; set; } = string.Empty;
}
