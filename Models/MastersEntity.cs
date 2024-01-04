namespace SultaniaOil.Models
{
    public class MastersEntity
    {
        public int Id { get; set; }

        public string Bagtype { get; set; }

        public DateTime? DATE { get; set;}
    }
     

    public class ColorEntity
    {
        public int Id { get; set; }

        public string Color { get; set; }

        public string ColorCode { get; set; }

        public DateTime? DATE { get; set; }

    }


    public class TypeQLTEntity
    {
        public int Id { get; set; }

        public string Jobcode { get; set; }

        public DateTime? DATE { get; set; }

    }

}
