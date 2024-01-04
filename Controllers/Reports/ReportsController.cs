using Microsoft.AspNetCore.Mvc;
using SultaniaOil.Data;
using SultaniaOil.ViewModels;

namespace SultaniaOil.Controllers.Reports
{
    public class ReportsController : Controller
    {
        MastersReposetory _DB = new MastersReposetory();
        RawMateirialsReposetory _Repository = new RawMateirialsReposetory();

        public IActionResult RawMaterilas()
        {
            PartyGradeProductViewModel MyModel = new PartyGradeProductViewModel();
            MyModel.GradeEntitys = _DB.RetriveGrade();
            MyModel.VendorEntities = _DB.RetriveVendor();
            MyModel.ProductEntities = _DB.RetriveProduct();
            MyModel.RawMaterials = _Repository.RetrivePurches();
            return View("RawMaterilas", MyModel);

        }
    }
}
