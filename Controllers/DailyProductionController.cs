using Microsoft.AspNetCore.Mvc;
using SultaniaOil.Data;
using SultaniaOil.Models;

namespace SultaniaOil.Controllers
{
    public class DailyProductionController : Controller
    {



        
        public IActionResult DailyProduction() //retrive daily product
        {
            DailyProductionReposetory _DB = new DailyProductionReposetory();

            List<DailyProductionEntity> result = new List<DailyProductionEntity>();
            result = _DB.GetDailyProduct(); 
            return View("DailyProduction", result);
        }



        public IActionResult InsertDailyProduction(DailyProductionEntity dailyProductionEntity) // insert  daily product
        {
            DailyProductionReposetory _DB = new DailyProductionReposetory();

            List<DailyProductionEntity> result = new List<DailyProductionEntity>();
            try
            {
                if (ModelState.IsValid)
                {
                    TempData["InsertRotogravure"] = "Data Added Successfully..!";
                    if (_DB.InsertDailyProduct(dailyProductionEntity))
                    {

                        result = _DB.GetDailyProduct();                                 
                        return RedirectToAction("DailyProduction", result);
                    }
                }
            }
            catch (Exception ex)
            {
            }
            result = _DB.GetDailyProduct();
            return RedirectToAction("DailyProduction", result);

        }
    }
}
