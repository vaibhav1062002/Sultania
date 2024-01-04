using System.ComponentModel.DataAnnotations;

namespace SultaniaOil.Models
{
    public class LoomEntity
    {

        public int? Id { get; set; }


        [Required]
        public string Loom { get; set; }


    }
}
