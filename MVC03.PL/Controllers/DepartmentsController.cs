using Microsoft.AspNetCore.Mvc;

namespace Demo.BL.Services
{
    public class DepartmentsController(DepartmentsService departmentsService):Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            var departments=departmentsService.GetAll();
            return View(departments);
        }
        #region
        public IActionResult Create()
        {
         
            return View();
        }
        #endregion
    }
}
