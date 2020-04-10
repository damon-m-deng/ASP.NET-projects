using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BodyBuilding.Models;
using Microsoft.AspNetCore.Mvc;

namespace BodyBuilding.Controllers
{
    public class WeightTrainingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Route("WeightTraining")]
        [HttpGet]
        public IActionResult CreateWeightTraining()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateWeightTraining2(WeightTraining wt)
        {
            if (!ModelState.IsValid)
                return View("CreateWeightTraining", wt);
            else
                return View("CreateWeightTraining2", wt);
        }
    }
}