﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DnDTracker.Web.Controllers
{
    public class CreateCampaignController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}