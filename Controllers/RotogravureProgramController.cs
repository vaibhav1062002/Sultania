using Microsoft.AspNetCore.Mvc;
using SultaniaOil.Data;
using SultaniaOil.Models;

namespace SultaniaOil.Controllers
{
    public class RotogravureProgramController : Controller
    {
        public IActionResult Rotogravure() // retrive rotogravure
        {
            RotogravureReposetory _DB = new RotogravureReposetory();

            List<RotogravureEntity> result = new List<RotogravureEntity>();


            result = _DB.GetRotogravure();
            return View("Rotogravure", result);
        }



        public IActionResult InsertRotogravure(RotogravureEntity rotogravureEntity) // insert  rotogravure
        {
            RotogravureReposetory _DB = new RotogravureReposetory();

            List<RotogravureEntity> result = new List<RotogravureEntity>();
            try
            {
                if (ModelState.IsValid)
                {
                    TempData["InsertRotogravure"] = "Data Added Successfully..!";
                    if (_DB.InsertRotogravure(rotogravureEntity))
                    {

                        result = _DB.GetRotogravure();
                        return RedirectToAction("Rotogravure", result);
                    }
                }
            }
            catch (Exception ex)
            {
            }
            result = _DB.GetRotogravure();
            return RedirectToAction("Rotogravure", result);

        }


    }
}
