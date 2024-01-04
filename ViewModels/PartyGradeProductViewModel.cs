//this  modelView contain VendorEntity  GradeEntity ProductEntity RawMaterialEntity


using SultaniaOil.Models;

namespace SultaniaOil.ViewModels
{
    public class PartyGradeProductViewModel
    {

        public IEnumerable<VendorEntity> VendorEntities { get; set; }

        public IEnumerable<GradeEntity> GradeEntitys { get; set; }

        public IEnumerable<ProductEntity> ProductEntities { get; set; }

        public IEnumerable<RawMaterialEntity> RawMaterials { get; set; }


    }
}
