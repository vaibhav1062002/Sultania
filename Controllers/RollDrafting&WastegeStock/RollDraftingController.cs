using Microsoft.AspNetCore.Mvc;
using SultaniaOil.Data;
using SultaniaOil.Models;

namespace SultaniaOil.Controllers.RollDrafting_WastegeStock
{
    public class RollDraftingController : Controller
    {
       

        public IActionResult UnusedRollStock() //unused  roll stock retrive 
        {
            RollDraftingAndStockWastegeReposetory _DB = new RollDraftingAndStockWastegeReposetory();

            List<UnusedRollStockEntity> result = new List<UnusedRollStockEntity>();
            result = _DB.GetUnusedRollstock();
            return View("UnusedRollStock", result);
        }



        public IActionResult InsertUnusedRollstock(UnusedRollStockEntity unusedRollStock) // insert  rotogravure
        {
            RollDraftingAndStockWastegeReposetory _DB = new RollDraftingAndStockWastegeReposetory();

            List<UnusedRollStockEntity> result = new List<UnusedRollStockEntity>();
            try
            {
                if (ModelState.IsValid)
                {
                    TempData["unused"] = "Data Added Successfully..!"; 
                    if (_DB.InsertUnusedRollstock(unusedRollStock))
                    {
                        result = _DB.GetUnusedRollstock();
                        return RedirectToAction("UnusedRollStock", result);
                    }
                }
            }
            catch (Exception ex)
            {
            }
            result = _DB.GetUnusedRollstock();
            return RedirectToAction("UnusedRollStock", result);

        }



        //*************19 inches to 30 inches start **********************************************

        public IActionResult Inches19()   // retrive 19 
        {
            RollDraftingAndStockWastegeReposetory _DB = new RollDraftingAndStockWastegeReposetory();

            List<Inches19Entity> result = new List<Inches19Entity>();
            result = _DB.RetrieveInches19();
            return View("19Inches",result);
        }
        



     public IActionResult InsertInches19(Inches19Entity inches19Entity) // insert  26
        {
            RollDraftingAndStockWastegeReposetory _DB = new RollDraftingAndStockWastegeReposetory();

            List<Inches19Entity> result = new List<Inches19Entity>();
            try
            {
                if (ModelState.IsValid)
                {
                    TempData["inches19"] = "Data Added Successfully..!";
                    if (_DB.InsertInches19(inches19Entity))
                    {
                        result = _DB.RetrieveInches19();
                        return RedirectToAction("19Inches", result);
                    }
                }
            }
            catch (Exception ex)
            {
            }
            result = _DB.RetrieveInches19();
            return View("19Inches", result);
        }





        public IActionResult Inches26()   // retrive 26
        {
            RollDraftingAndStockWastegeReposetory _DB = new RollDraftingAndStockWastegeReposetory();

            List<Inches26Entity> result = new List<Inches26Entity>();
            result = _DB.RetrieveInches26();
            return View("Inches26", result);
        }




        public IActionResult InsertInches26(Inches26Entity inches26Entity) // insert  26
        {
            RollDraftingAndStockWastegeReposetory _DB = new RollDraftingAndStockWastegeReposetory();

            List<Inches26Entity> result = new List<Inches26Entity>();
            try
            {
                if (ModelState.IsValid)
                {
                    TempData["inches26"] = "Data Added Successfully..!";
                    if (_DB.InsertInches26(inches26Entity))
                    {
                        result = _DB.RetrieveInches26();
                        return RedirectToAction("Inches26", result);
                    }
                }
            }
            catch (Exception ex)
            {
            }
            result = _DB.RetrieveInches26();
            return RedirectToAction("Inches26", result);
        }





        public IActionResult Inches28()   // retrive 28
        {
            RollDraftingAndStockWastegeReposetory _DB = new RollDraftingAndStockWastegeReposetory();

            List<Inches28Entity> result = new List<Inches28Entity>();
            result = _DB.RetrieveInches28();
            return View("Inches28", result);
        }




        public IActionResult InsertInches28(Inches28Entity inches28Entity) // insert  28
        {
            RollDraftingAndStockWastegeReposetory _DB = new RollDraftingAndStockWastegeReposetory();

            List<Inches28Entity> result = new List<Inches28Entity>();
            try
            {
                if (ModelState.IsValid)
                {
                    TempData["inches28"] = "Data Added Successfully..!";
                    if (_DB.InsertInches28(inches28Entity))
                    {
                        result = _DB.RetrieveInches28();
                        return RedirectToAction("Inches28", result);
                    }
                }
            }
            catch (Exception ex)
            {
            }
            result = _DB.RetrieveInches28();
            return RedirectToAction("Inches28", result);
        }
 








    public IActionResult Inches30()   //retrive 30
    {
        RollDraftingAndStockWastegeReposetory _DB = new RollDraftingAndStockWastegeReposetory();

        List<Inches30Entity> result = new List<Inches30Entity>();
        result = _DB.RetrieveInches30();
        return View("Inches30", result);
    }




    public IActionResult InsertInches30(Inches30Entity inches30Entity) // insert 30
    {
        RollDraftingAndStockWastegeReposetory _DB = new RollDraftingAndStockWastegeReposetory();

        List<Inches30Entity> result = new List<Inches30Entity>();
        try
        {
            if (ModelState.IsValid)
            {
                TempData["inches30"] = "Data Added Successfully..!";
                if (_DB.InsertInches30(inches30Entity))
                {
                    result = _DB.RetrieveInches30();
                    return RedirectToAction("Inches30", result);
                }
            }
        }
        catch (Exception ex)
        {
            // Handle the exception
        }
        result = _DB.RetrieveInches30();
        return RedirectToAction("Inches30", result);
    }






        public IActionResult Flatesheet()   //retrive Flatesheet60Entity
        {
            RollDraftingAndStockWastegeReposetory _DB = new RollDraftingAndStockWastegeReposetory();

            List<Flatesheet60Entity> result = new List<Flatesheet60Entity>();
            result = _DB.RetrieveFlatesheet60();
            return View("Flatesheet", result);
        }




        public IActionResult InsertFlatesheet(Flatesheet60Entity flatesheet60Entity) // insert Flatesheet60Entity
        {
            RollDraftingAndStockWastegeReposetory _DB = new RollDraftingAndStockWastegeReposetory();

            List<Flatesheet60Entity> result = new List<Flatesheet60Entity>();
            try
            {
                if (ModelState.IsValid)
                {
                    TempData["Flatesheet"] = "Data Added Successfully..!";
                    if (_DB.InsertFlatesheet60(flatesheet60Entity))
                    {
                        result = _DB.RetrieveFlatesheet60();
                        return RedirectToAction("Flatesheet", result);
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle the exception
            }
            result = _DB.RetrieveFlatesheet60();
            return RedirectToAction("Flatesheet", result);
        }





        public IActionResult CM45()   //retrive cm45
        {
            RollDraftingAndStockWastegeReposetory _DB = new RollDraftingAndStockWastegeReposetory();

            List<CM45Entity> result = new List<CM45Entity>();
            result = _DB.RetrieveCM45();
            return View("CM45", result);
        }




        public IActionResult InsertCM45(CM45Entity cM45Entity) // insert CM45
        {
            RollDraftingAndStockWastegeReposetory _DB = new RollDraftingAndStockWastegeReposetory();

            List<CM45Entity> result = new List<CM45Entity>();
            try
            {
                if (ModelState.IsValid)
                {
                    TempData["CM45"] = "Data Added Successfully..!";
                    if (_DB.InsertCM45(cM45Entity))
                    {
                        result = _DB.RetrieveCM45();
                        return RedirectToAction("CM45", result);
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle the exception
            }
            result = _DB.RetrieveCM45();
            return RedirectToAction("CM45", result);
        }





        public IActionResult MM400()   //retrive MM400
        {
            RollDraftingAndStockWastegeReposetory _DB = new RollDraftingAndStockWastegeReposetory();

            List<MM400Entity> result = new List<MM400Entity>();
            result = _DB.RetrieveMM400();
            return View("MM400", result);
        }




        public IActionResult InsertMM400(MM400Entity mM400) // insert MM400
        {
            RollDraftingAndStockWastegeReposetory _DB = new RollDraftingAndStockWastegeReposetory();

            List<MM400Entity> result = new List<MM400Entity>();
            try
            {
                if (ModelState.IsValid)
                {
                    TempData["MM400"] = "Data Added Successfully..!";
                    if (_DB.InsertMM400(mM400))
                    {
                        result = _DB.RetrieveMM400();
                        return RedirectToAction("MM400", result);
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle the exception
            }
            result = _DB.RetrieveMM400();
            return RedirectToAction("MM400", result);
        }





        public IActionResult MM850()   //retrive MM850
        {
            RollDraftingAndStockWastegeReposetory _DB = new RollDraftingAndStockWastegeReposetory();

            List<MM850Entity> result = new List<MM850Entity>();
            result = _DB.RetrieveMM850();
            return View("MM850", result);
        }




        public IActionResult InsertMM850(MM850Entity mM850) // insert MM400
        {
            RollDraftingAndStockWastegeReposetory _DB = new RollDraftingAndStockWastegeReposetory();

            List<MM850Entity> result = new List<MM850Entity>();
            try
            {
                if (ModelState.IsValid)
                {
                    TempData["MM850"] = "Data Added Successfully..!";
                    if (_DB.InsertMM850(mM850))
                    {
                        result = _DB.RetrieveMM850();
                        return RedirectToAction("MM850", result);
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle the exception
            }
            result = _DB.RetrieveMM850();
            return RedirectToAction("MM850", result);
        }

    }
}
