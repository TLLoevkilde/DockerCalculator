using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DockerCalculator;

public class CalculationLog
{   
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    [Required]
    public int Number1 { get; set; }
    [Required]
    public int Number2 { get; set; }
    [Required]
    public string Operation { get; set; }
    [Required]
    public int Result { get; set; }
}
