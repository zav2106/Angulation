using System.ComponentModel.DataAnnotations;

namespace Angulation.Domain.Angulation;

public enum TriangleType
{
    [Display(Name = "Right angle triangle")]
    Right = 1,

    [Display(Name = "Acute triangle")]
    Acute = 2,

    [Display(Name = "Obtuse triangle")]
    Obtuse = 3
}