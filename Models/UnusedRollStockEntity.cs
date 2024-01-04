using System.ComponentModel.DataAnnotations;

namespace SultaniaOil.Models
{
    public class UnusedRollStockEntity
    {

        public int? Id { get; set; }

        public string SizeAndDenier { get; set; }

        public int Meter { get; set; }

        public int Weight { get; set; }

        public int Average { get; set; }

        public int Quantity { get; set; }

        public int NoOfRolls { get; set; }

        public DateTime Date { get; set; }

    }
}
