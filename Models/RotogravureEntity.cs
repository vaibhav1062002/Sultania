namespace SultaniaOil.Models
{
    public class RotogravureEntity
    {

        public int? Id { get; set; }

        public string JobName { get; set; }

        public DateTime Date { get; set; }

        public string Shift { get; set; }

        public string ProNumber { get; set; }

        public string NoOfCylender { get; set; }

        public string? MeterToBePrinted { get; set; }

        public string Color { get; set; }


            // Plain BOPP Roll properties
            public string PlainBoppRollNo { get; set; }
            public string PlainMeter { get; set; }
            public string PlainNetWeight { get; set; }
            public string PlainAvgWeight { get; set; }

            // Printed BOPP Roll properties
            public string PrintedBoppRollNo { get; set; }
            public string PrintedMeter { get; set; }
            public string PrintedNetWeight { get; set; }
            public string PrintedAvgWeight { get; set; }

            // Slitted BOPP Roll properties
            public string SlittedBoppRollNo { get; set; }
            public string SlittedMeter { get; set; }
            public string SlittedNetWeight { get; set; }
            public string SlittedAvgWeight { get; set; }

        // Fresh Ink properties
        public string FreshInkColor { get; set; }
        public string FreshIssued { get; set; }
        public string FreshReturned { get; set; }
        public string FreshActConsuption { get; set; }

        // Mix Ink properties
        public string MixInkColor { get; set; }
        public string MixIssued { get; set; }
        public string MixReturned { get; set; }
        public string MixActConsuption { get; set; }

        // Chemical properties
        public string ChemicalParticulars { get; set; }
        public string ChemicalIssued { get; set; }
        public string ChemicalReturned { get; set; }
        public string ChemicalActConsuption { get; set; }

    }
}
