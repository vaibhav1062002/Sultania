namespace SultaniaOil.Models
{
    public class DailyProductionEntity
    {

        public int? Id { get; set; }
        public DateTime? Date { get; set; } = DateTime.Today;

        // Manual Section
        public string? ManualDayNight { get; set; }
        public string? ManualNoOfBags { get; set; }
        public string ManualPoRed { get; set; }
        public string ManualGreen { get; set; }
        public string ManualRducerCons { get; set; }
        public string? ManualNoOfBagsTotal { get; set; }
        public string? ManualPoRedTotal { get; set; }
        public string? ManualGreenTotal { get; set; }
        public string? ManualRducerConsTotal { get; set; }

        // BCS Printing Section
        public string BcsDayNight { get; set; }
        public string Bcs1 { get; set; }
        public string Bcs2 { get; set; }
        public string? Bcs1Total { get; set; }
        public string? Bcs2Total { get; set; }

        // Flexo Printing Section
        public string FlexoDayNight { get; set; }
        public string FlexoMeter { get; set; }
        public string FlexoInkConsRed { get; set; }
        public string FlexoInkConsBlack { get; set; }
        public string FlexoReducerCons { get; set; }
        public string? FlexoBCSMeterTotal { get; set; }
        public string? FlexoInkConsRedTotal { get; set; }
        public string? FlexoInkConsBlackTotal { get; set; }
        public string? FlexoReducerConsTotal { get; set; }

        // Loom Wastage Section
        public string LoomWastageShiftA { get; set; }
        public string LoomWastageShiftB { get; set; }
        public string? LoomWastageTotal { get; set; }

        // Plant Wastage Section
        public string PlantWastageShiftA { get; set; }
        public string PlantWastageShiftB { get; set; }
        public string? PlantWastageTotal { get; set; }

        // Total Wastage Section
        public string? QuntityWastage { get; set; }
        public string? CalciumDusting { get; set; }
        public string? LaminationWastage { get; set; }
        public string? SlittingWastage { get; set; }
        public string? TotalWastage { get; set; }



    }
}
