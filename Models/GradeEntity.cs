using System.ComponentModel.DataAnnotations;

namespace SultaniaOil.Models
{
    public class GradeEntity
    {
        public int? Id { get; set; }


        [Required]
        public string Grade { get; set; }
    }
}
