namespace SultaniaOil.Models
{
    public class VendorEntity
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public string MobileNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string? NameOfCenter { get; set; }
        public IFormFile? GST { get; set; }

        public  string? GSTImage { get; set; }

        public string GSTNumber { get; set; }

    }
}
