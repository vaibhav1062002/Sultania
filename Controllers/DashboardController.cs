using Microsoft.AspNetCore.Mvc;
using SultaniaOil.Data;
using SultaniaOil.Models;
using SultaniaOil.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Text.Json;

namespace SultaniaOil.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Dashboard() // view dashborad
        {
            return View("Dashboard");
        }


        [HttpGet]
        public IActionResult TapeLineProgramme()// view tape Line
        {
            TapeLineProgramReposetory _DB = new TapeLineProgramReposetory();
            List<TapeLineProgramEntity> result = new List<TapeLineProgramEntity>();
            MastersReposetory _MR = new MastersReposetory();

            TapeLineViewModel model = new TapeLineViewModel()
            {
                JobCodeEntities = _MR.RetriveJobCode(),
                ColorEntities = _MR.GetColorDetails(),
                BobbinEntities = _MR.RetriveBobbin(),
                productEntities = _MR.RetriveProduct(),
                TapeLineProgramEntities = _DB.GetTapeLinePro(null)
            };

            return View("TapeLineProgramme", model);
        }



        [HttpGet]
        public IActionResult viewRelatedDate(string id)// view tape Line
        {
            TapeLineProgramReposetory _DB = new TapeLineProgramReposetory();
            List<TapeLineProgramEntity> result = new List<TapeLineProgramEntity>();
            result = _DB.GetTapeLinePro(id);
            return Json(result);
        }




        public IActionResult LoomPlanReport()// retrive  loom
        {
            LoomProReposetory _DB = new LoomProReposetory();

            List<LoomProgramEntity> result = new List<LoomProgramEntity>();
            result = _DB.GetloomPlan();
            return View("LoomPlanReport", result);
        }



        [HttpPost]
        //insert tape line
        public async Task<IActionResult> InsertTapeLinePro(TapeLineProgramEntity tapeLineProgram)
        {

            try
            {

                if (ModelState.IsValid)
                {

                    TapeLineProgramReposetory _DbTapeLine = new TapeLineProgramReposetory();
                    if (_DbTapeLine.InsertTapeLinePro(tapeLineProgram))
                    {
                        TempData["TapeLineProSucc"] = "Your data has been submitted successfully!";
                        List<TapeLineProgramEntity> result2 = new List<TapeLineProgramEntity>();
                        result2 = _DbTapeLine.GetTapeLinePro(null);
                        return RedirectToAction("TapeLineProgramme", result2);
                    }
                }
            }
            catch (Exception ex)
            {
                return RedirectToAction("TapeLineProgramme", tapeLineProgram);
            }
            List<TapeLineProgramEntity> result = new List<TapeLineProgramEntity>();
            TapeLineProgramReposetory _DB = new TapeLineProgramReposetory();
            result = _DB.GetTapeLinePro(null);
            return RedirectToAction("TapeLineProgramme", result);

        }






        [HttpPost]
        public IActionResult InsertLoomPro(LoomProgramEntity loomProgramEntity) // insert  loom
        {
            LoomProReposetory _DB = new LoomProReposetory();

            List<LoomProgramEntity> result = new List<LoomProgramEntity>();
            try
            {
                if (ModelState.IsValid)
                {
                    TempData["InsertLoomPro"] = "Data Added Successfully..!";
                    if (_DB.InsertLoomPro(loomProgramEntity))
                    {

                        result = _DB.GetloomPlan();
                        return RedirectToAction("LoomPlanReport", result);
                    }
                }
            }
            catch (Exception ex) { }
            result = _DB.GetloomPlan();
            return RedirectToAction("LoomPlanReport", result);

        }


        public IActionResult DaleteTapeLine(int id)   //Delete Tape Line
        {
            TapeLineProgramReposetory _DB = new TapeLineProgramReposetory();

            if (_DB.DaleteTapeLine(id))
            {
                List<TapeLineProgramEntity> result = new List<TapeLineProgramEntity>();
                return Json(result);
            }
            return RedirectToAction();
        }

    }
}
