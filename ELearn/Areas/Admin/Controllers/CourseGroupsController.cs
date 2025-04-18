using ELearn.Core.Interfaces;
using ELearn.DataLayer.DTOS.CourseGroupViewModels;
using ELearn.DataLayer.Entities;
using Microsoft.AspNetCore.Mvc;


            List<CourseGroup> courseGroups = _courseGroupServices.GetCourseGroups().ToList();
            return View(courseGroups);
        }

        [HttpGet]
        public IActionResult CreateCourseGroup()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateCourseGroup(CreateCourseGroupViewModel createModel)
        {
            if (!ModelState.IsValid)
            {
                return View(createModel);
            }
            CourseGroup courseGroup = new CourseGroup
            {
                CourseGroupName = createModel.CourseGroupName,

            };
            if (!await _courseGroupServices.CreateCourseGroup(courseGroup))
            {
                TempData["Error"] = "عملیات با موفقیت شکست خورد !";
                return RedirectToAction("index");
            }
            TempData["Success"] = "عملیات با موفقیت پیروز شد !";
            return RedirectToAction("index");

        }
    }
}
