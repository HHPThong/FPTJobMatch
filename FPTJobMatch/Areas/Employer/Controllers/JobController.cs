﻿using Microsoft.AspNetCore.Mvc;

namespace FPTJobMatch.Areas.Administrator.Controllers
{
	public class JobController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
