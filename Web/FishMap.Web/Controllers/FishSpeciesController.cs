﻿namespace FishMap.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Mvc;

    public class FishSpeciesController : Controller
    {
        public IActionResult All()
        {
            return this.View();
        }
    }
}