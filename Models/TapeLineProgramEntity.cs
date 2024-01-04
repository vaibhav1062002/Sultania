using System.ComponentModel.DataAnnotations;

namespace SultaniaOil.Models
{
    public class TapeLineProgramEntity
    {
        public int? Id { get; set; }

        // Granules Table
        //public string PPPurcentage { get; set; }
        //public string PPGranules { get; set; }
        //public string PPSpecification { get; set; }

        //public string CalciumPurcentage { get; set; }
        //public string CalciumGranules { get; set; }
        //public string CalciumSpecification { get; set; }

        //public string ModifierPurcentage { get; set; }
        //public string ModifierGranules { get; set; }
        //public string ModifierSpecification { get; set; }

        //public string MasterbatchPurcentage { get; set; }
        //public string MasterbatchGranules { get; set; }
        //public string MasterbatchSpecification { get; set; }

        //public string UVPurcentage { get; set; }
        //public string UVGranules { get; set; }
        //public string UVSpecification { get; set; }

        //public string LLPurcentage { get; set; }
        //public string LLGranules { get; set; }
        //public string LLSpecification { get; set; }


        //all garnual array 
        public string GranualData { get; set; }


        // Actual Granual Consumption Table
        public string ActualGranual1 { get; set; }
            public string ActualGranual2 { get; set; }
            public string ActualGranual3 { get; set; }
            public string ActualGranual4 { get; set; }
            public string ActualGranual5 { get; set; }
            public string ActualGranual6 { get; set; }
            public string ActualGranual7 { get; set; }
            public string ActualGranual8 { get; set; }
            public string ActualGranual9 { get; set; }
            public string ActualGranual10 { get; set; }
            public string ActualGranual11 { get; set; }
            public string ActualGranual12 { get; set; }

            // Div inside TD
            public DateTime Date { get; set; }
            public string ProgrameNo { get; set; }
            public string JobCode { get; set; }
            public string CreateColor { get; set; }
            public string Bobin { get; set; }


        //

        public string DenierRequired { get; set; }
        public string DenierActual { get; set; }
        public string DenierRemarks { get; set; }

        public string TapeWidthRequired { get; set; }
        public string TapeWidthActual { get; set; }
        public string TapeWidthRemarks { get; set; }

        public string StrenghtRequired { get; set; }
        public string StrenghtActual { get; set; }
        public string StrenghtRemarks { get; set; }

        public string ElongationRequired { get; set; }
        public string ElongationActual { get; set; }
        public string ElongationRemarks { get; set; }

        public string KGSRequired { get; set; }
        public string KGSActual { get; set; }
        public string KGSRemarks { get; set; }




    }
}
