using System.ComponentModel.DataAnnotations;

namespace Ramon_Lopez_AP1_P1.Models;

public class Aportes
{
    [Key]
    public int AporteId { get; set; }

    public DateTime fecha { get; set; } = DateTime.Now;

    [Required(ErrorMessage = "El campo Monto es obligatorio.")]
    [Range(1.00, 1000000.00, ErrorMessage = "El monto debe ser mayor que cero.")]
    public decimal Monto { get; set; }

    [Required(ErrorMessage = "El campo Nombre es obligatorio.")]
    [StringLength(100, ErrorMessage = "El nombre no puede exceder los 100 caracteres.")]
    public string Nombre { get; set; } = string.Empty;
}
