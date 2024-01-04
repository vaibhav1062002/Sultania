namespace SultaniaOil.Models
{
    public class Inches28Entity
    {
        public int? Id { get; set; }

        // Properties for the first section
        public DateTime Date { get; set; }
        public string RollNumber { get; set; }
        public string Size { get; set; }
        public string WidthInMM { get; set; }
        public string LoomNumber { get; set; }
        public string MTRS { get; set; }
        public string GWeight { get; set; }
        public string CWeight { get; set; }
        public string NWeight { get; set; }
        public string Average { get; set; }
        public string Remark { get; set; }

        // Properties for the second section
        public DateTime Date2 { get; set; }
        public string Sales { get; set; }
        public string IssueOfReasion { get; set; }

        // Properties for the third section
        public string MTRSForBCS { get; set; }
        public string NetWeightForBCS { get; set; }

        // Properties for the fourth section
        public string MTRSForBalanceWeight { get; set; }
        public string NetWeightForBalanceWeight { get; set; }


    }
}
