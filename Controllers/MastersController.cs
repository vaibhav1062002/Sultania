using Microsoft.AspNetCore.Mvc;
using MySqlX.XDevAPI.Common;
using SultaniaOil.Data;
using SultaniaOil.Models;

namespace SultaniaOil.Controllers
{

    public class MastersController : Controller
    {


        private IWebHostEnvironment _hostingEnvironment;


        public MastersController(IWebHostEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;

        }       

      

        MastersReposetory _DB = new MastersReposetory();


        //all masters  retrive  start ***************************************************
        public IActionResult Bagtype() // view color bagtype
        {
            List<MastersEntity> result = new List<MastersEntity>();
            result = _DB.GetBagType();
            return View("Bagtype",result);
        }

        public IActionResult ColorDetails() // view color Details
        {
            List<ColorEntity> result = new List<ColorEntity>();
            result = _DB.GetColorDetails();
            return View("ColorDetails",result);
        }


        public IActionResult TapeQLT() //view tape qnt
        {
            List<TypeQLTEntity> result = new List<TypeQLTEntity>();
            result = _DB.GetTapeQLT();
            return View("TapeQLT", result);
        }


        public IActionResult Vendor() // view vendor
        {
            List<VendorEntity> result = new List<VendorEntity>();
            result = _DB.RetriveVendor();
            return View("Vendor", result);
        }


        public IActionResult Product() //view Product
        {
            List<ProductEntity> result = new List<ProductEntity>();
            result = _DB.RetriveProduct();
            return View("Product", result);
        }


        public IActionResult Grade() // view Grade
        {
            List<GradeEntity> result = new List<GradeEntity>();
            result = _DB.RetriveGrade();
            return View("Grade", result);
        }



        public IActionResult Loom() // view Grade
        {
            List<LoomEntity> result = new List<LoomEntity>();
            result = _DB.RetriveLoom();
            return View("Loom", result);
        }


        public IActionResult Bobbin() // view Bobbin
        {
            List<BobbinEntity> result = new List<BobbinEntity>();
            result = _DB.RetriveBobbin();
            return View("Bobbin", result);
        }



        public IActionResult JobCode() // view JobCode
        {
            List<JobCodeEntity> result = new List<JobCodeEntity>();
            result = _DB.RetriveJobCode();
            return View("JobCode", result);
        }


        //all masters  retrive  end *************************************************** 











        //all masters  retrive  insert ***************************************************

        public IActionResult InsertBagType(MastersEntity BagtypeEntity) // insert  Bagtype
        {
            List<MastersEntity> result = new List<MastersEntity>();
            try
            {
                if (ModelState.IsValid)
                {
                    TempData["BagInsert"] = "Bag Type Added Successfully..!";
                    if (_DB.InsertBagType(BagtypeEntity))
                    {
                        result = _DB.GetBagType();
                        return RedirectToAction("Bagtype", result);
                    }
                }
            }
            catch (Exception ex)
            {
            }
            result = _DB.GetBagType();
            return RedirectToAction("Bagtype", result);

        }

        public IActionResult InsertColorDetails(ColorEntity colorEntity) // insert Color details
        {
            List<ColorEntity> result = new List<ColorEntity>();
            try
            {
                if (ModelState.IsValid)
                {
                    TempData["colorInsert"] = "Color Details Added";

                    if (_DB.InsertColorDetails(colorEntity))
                    {
                        result = _DB.GetColorDetails();
                        return RedirectToAction("ColorDetails", result);
                    }
                }
            }
            catch (Exception ex)
            {
            }
            result = _DB.GetColorDetails();
            return RedirectToAction("ColorDetails", result);

        }

        public IActionResult InsertTapeQlt(TypeQLTEntity typeQLTEntity) // insert tape qlt
        {
            List<TypeQLTEntity> result = new List<TypeQLTEntity>();

            try
            {
                if (ModelState.IsValid)
                {
                    if (_DB.InsertTapeQlt(typeQLTEntity))
                    {

                        TempData["InsertTapeQlt"] = "Job Code Added Successfully";
                        result = _DB.GetTapeQLT();
                        return RedirectToAction("TapeQLT", result);
                    }
                }
            }
            catch (Exception ex)
            {
            }

            result = _DB.GetTapeQLT();
            return RedirectToAction("TapeQLT", result);
        }


        public async Task<IActionResult> InsertVendor(VendorEntity vendorEntity) // insert  Vendor
        {
            List<VendorEntity> result = new List<VendorEntity>();
            try
            {
                if (ModelState.IsValid)
                {

                    //set image to static folder 
                    if (vendorEntity.GST != null)
                    {
                        string folder = "GST/";
                        folder += Guid.NewGuid().ToString() + "_" + vendorEntity.GST.FileName;
                        string serverFolder = Path.Combine(_hostingEnvironment.WebRootPath, folder);
                        vendorEntity.GSTImage= folder;
                        await   vendorEntity.GST.CopyToAsync(new FileStream(serverFolder, FileMode.Create));
                    }


                    TempData["Vendor"] = "Vendor Added Successfully..!";
                    if (_DB.InsertVendor(vendorEntity))
                    {
                        result = _DB.RetriveVendor();
                        return RedirectToAction("Vendor", result);
                    }
                }
            }
            catch (Exception ex) {
               Content(ex.ToString()); 
            }
            result = _DB.RetriveVendor();
            return RedirectToAction("Vendor", result);
        }
      

        public IActionResult InsertGrade(GradeEntity gradeEntity) // insert  Grade
        {
            List<GradeEntity> result = new List<GradeEntity>();
            try
            {
                if (ModelState.IsValid)
                {
                    TempData["Grade"] = "Grade Added Successfully..!";
                    if (_DB.InsertGrade(gradeEntity))
                    {
                        result = _DB.RetriveGrade();
                        return RedirectToAction("Grade", result);
                    }
                }
            }
            catch (Exception ex){  }
            result = _DB.RetriveGrade();
            return RedirectToAction("Grade", result);
         }


        public IActionResult InsertProduct(ProductEntity productEntity) // insert  Product
        {
            List<ProductEntity> result = new List<ProductEntity>();
            try
            {
                if (ModelState.IsValid)
                {
                    TempData["Product"] = "Grade Added Successfully..!";
                    if (_DB.InsertProduct(productEntity))
                    {
                        result = _DB.RetriveProduct();
                        return RedirectToAction("Product", result);
                    }
                }
            }
            catch (Exception ex) { }
            result = _DB.RetriveProduct();
            return RedirectToAction("Product", result);
        }



        public IActionResult InsertLoom(LoomEntity loomEntity) // insert  Loom
        {
            List<LoomEntity> result = new List<LoomEntity>();
            try
            {
                if (ModelState.IsValid)
                {
                    TempData["Loom"] = "Loom Added Successfully..!";
                    if (_DB.InsertGrade(loomEntity))
                    {
                        result = _DB.RetriveLoom();
                        return RedirectToAction("Loom", result);
                    }
                }
            }
            catch (Exception ex) { }
            result = _DB.RetriveLoom();
            return RedirectToAction("Grade", result);
        }



        public IActionResult InsertBobbin(BobbinEntity bobbinEntity) // insert  Bobbin
        {
            List<BobbinEntity> result = new List<BobbinEntity>();
            try
            {
                if (ModelState.IsValid)
                {
                    TempData["Bobbin"] = "Loom Added Successfully..!";
                    if (_DB.InsertBobbin(bobbinEntity))
                    {
                        result = _DB.RetriveBobbin();
                        return RedirectToAction("Bobbin", result);
                    }
                }
            }
            catch (Exception ex) { }
            result = _DB.RetriveBobbin();
            return RedirectToAction("Bobbin", result);
        }



        public IActionResult InsertJobCode(JobCodeEntity jobCodeEntity) // insert JobCode 
        {
            List<JobCodeEntity> result = new List<JobCodeEntity>();
            try
            {
                if (ModelState.IsValid)
                {
                    TempData["JobCode"] = "JobCode Added Successfully..!";
                    if (_DB.InsertJobCode(jobCodeEntity))
                    {
                        result = _DB.RetriveJobCode();
                        return RedirectToAction("JobCode", result);
                    }
                }
            }
            catch (Exception ex) { }
            result = _DB.RetriveJobCode();
            return RedirectToAction("JobCode", result);
        }


        //all masters  insert  end ***************************************************








        // delete functionality for all masters start********************************************************


        public IActionResult DaleteBagType(int id) // delete bag type 
        {
            if (_DB.DaleteBagType(id))
            {
                List<RawMaterialEntity> result = new List<RawMaterialEntity>();
                return Json(result);
            }
            return RedirectToAction();
        }

        public IActionResult DeleteColor(int id) // delete  color
        {
            if (_DB.DeleteColor(id))
            {
                List<RawMaterialEntity> result = new List<RawMaterialEntity>();
                return Json(result);
            }
            return RedirectToAction();
        }


        public IActionResult DeleteGrade(string id) // delete  grade
        {
            if (_DB.DaleteGrade(id))
            {
                List<RawMaterialEntity> result = new List<RawMaterialEntity>();
                return Json(result);
            }
            return RedirectToAction();
        }




        public IActionResult DeleteProduct(int id) // delete  Product
        {
            if (_DB.DaleteProduct(id))
            {
                List<RawMaterialEntity> result = new List<RawMaterialEntity>();
                return Json(result);
            }
            return RedirectToAction();
        }



        public IActionResult DeleteTapeQNT(int id) // delete  Tape qnt
        {
            if (_DB.DaleteTapeQNT(id))
            {
                List<RawMaterialEntity> result = new List<RawMaterialEntity>();
                return Json(result);
            }
            return RedirectToAction();
        }




        public IActionResult DeleteVendor(int id) // delete  vendor
        {
            if (_DB.DaleteVendor(id))
            {
                List<RawMaterialEntity> result = new List<RawMaterialEntity>();
                return Json(result);
            }
            return RedirectToAction();
        }





        public IActionResult DeleteLoom(string id) // delete  grade
        {
            if (_DB.DaleteLoom(id))
            {
                List<RawMaterialEntity> result = new List<RawMaterialEntity>();
                return Json(result);
            }
            return RedirectToAction();
        }



        public IActionResult DeleteBobbin(string id) // delete  Bobbin
        {
            if (_DB.DaleteBobbin(id))
            {
                List<BobbinEntity> result = new List<BobbinEntity>();
                return Json(result);
            }
            return RedirectToAction();
        }

        public IActionResult DeleteJobCode(string id) // delete  Bobbin
        {
            if (_DB.DaleteJobCode(id))
            {
                List<JobCodeEntity> result = new List<JobCodeEntity>();
                return Json(result);
            }
            return RedirectToAction();
        }
    }

}
