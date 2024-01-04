using SultaniaOil.Models;

namespace SultaniaOil.ViewModels
{
    public class TapeLineViewModel
    {
        public IEnumerable<JobCodeEntity> JobCodeEntities { get; set; }

        public IEnumerable<ColorEntity> ColorEntities { get; set; }    

        public IEnumerable<BobbinEntity> BobbinEntities { get; set;}

        public IEnumerable<ProductEntity> productEntities { get; set; }

        public IEnumerable<TapeLineProgramEntity> TapeLineProgramEntities { get;set; }
    }
}
