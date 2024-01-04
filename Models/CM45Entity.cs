namespace SultaniaOil.Models
{
    public class CM45Entity
    {


        public int? Id { get; set; }

        // First set of fields
        public DateTime Date { get; set; }
        public string RollNumber { get; set; }
        public string Size { get; set; }
        public string WidthInMM { get; set; }
        public string LoomNumber { get; set; }
        public string MTRS { get; set; } // Note: Changed from MTRS to MTRS1 to avoid naming conflict
        public string GWeight { get; set; }
        public string CWeight { get; set; }
        public string NWeight { get; set; }
        public string Average { get; set; }

        // Second set of fields
        public DateTime Date2 { get; set; }
        public string Sales { get; set; }
        public string IssueOfLamination { get; set; }

        // Third set of fields (Issue For BCS)
        public string IssueMTRS { get; set; } // Note: Changed from MTRS to MTRS2 to avoid naming conflict
        public string IssueNetWeight { get; set; }

        // Fourth set of fields (Total)
        public string Total1 { get; set; }
        public string Total2 { get; set; }

        // Fifth set of fields (Balance Weight)
        public string BalanceMTRS { get; set; }
        public string BalanceNetWeight { get; set; }

    }
}
