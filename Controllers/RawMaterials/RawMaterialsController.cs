using Microsoft.AspNetCore.Mvc;
using SultaniaOil.Data;
using SultaniaOil.Models;
using SultaniaOil.ViewModels;
using SultaniaOil.Data;

namespace sultania.Controllers.RawMaterials
{
    public class RawMaterialsController : Controller
    {

        MastersReposetory _DB = new MastersReposetory();
        RawMateirialsReposetory _Repository = new RawMateirialsReposetory();


        public IActionResult Purches() //retrive purches 
        {

            PartyGradeProductViewModel MyModel = new PartyGradeProductViewModel();
            MyModel.GradeEntitys = _DB.RetriveGrade();
            MyModel.VendorEntities = _DB.RetriveVendor();
            MyModel.ProductEntities = _DB.RetriveProduct();
            MyModel.RawMaterials = _Repository.RetrivePurches();
            return View("Purches", MyModel);
        }




        public IActionResult InsertProduct(RawMaterialEntity rawMaterialEntity) // insert purchase
        {
            try
            {
                if (ModelState.IsValid)
                {
                    TempData["Purches"] = "Purchase Added Successfully..!";
                    if (_Repository.InsertRawMaterial(rawMaterialEntity))
                    {
                        // Retrieve the complete model data and return to the "Purches" view
                        PartyGradeProductViewModel MyModel = new PartyGradeProductViewModel
                        {
                            GradeEntitys = _DB.RetriveGrade(),
                            VendorEntities = _DB.RetriveVendor(),
                            ProductEntities = _DB.RetriveProduct(),
                            RawMaterials = _Repository.RetrivePurches()
                        };

                        return RedirectToAction("Purches", MyModel);
                    }
                }
            }
            catch (Exception ex){}

            PartyGradeProductViewModel mymodel = new PartyGradeProductViewModel
            {
                GradeEntitys = _DB.RetriveGrade(),
                VendorEntities = _DB.RetriveVendor(),
                ProductEntities = _DB.RetriveProduct(),
                RawMaterials = _Repository.RetrivePurches()
            };

            return RedirectToAction("Purches", mymodel);
        }



        public IActionResult DeletePurchase(int id)
        {
            if (_Repository.Daletepurchase(id))
            {
                List<RawMaterialEntity> result = new List<RawMaterialEntity>();
                return Json(result);
            }
            return RedirectToAction();
        }

    }
}
