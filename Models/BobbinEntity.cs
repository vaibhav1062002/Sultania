using System.ComponentModel.DataAnnotations;

namespace SultaniaOil.Models
{
    public class BobbinEntity
    {


        public int? Id { get; set; }


        [Required]
        public string Bobbin { get; set; }
    }
}
