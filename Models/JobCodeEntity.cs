using System.ComponentModel.DataAnnotations;

namespace SultaniaOil.Models
{
    public class JobCodeEntity
    {

        public int? Id { get; set; }


        [Required]
        public string JobCode { get; set; }

    }
}
