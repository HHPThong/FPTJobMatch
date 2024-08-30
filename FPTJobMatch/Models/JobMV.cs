﻿using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FPTJobMatch.Models
{
	public class JobMV
	{
		public Job job { get; set; }
		[ValidateNever]
		public IEnumerable<SelectListItem> TimeWork { get; set; }
	}
}