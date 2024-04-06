using AccountingStudentAcademicPerformance.Data;
using AccountingStudentAcademicPerformance.Models;
using Microsoft.AspNetCore.Mvc;


namespace AccountingStudentAcademicPerformance.Controllers
{
    public class StudentsController : Controller
    {
		private readonly AppDbContext _context;

		public StudentsController(AppDbContext context)
		{
			_context = context;
		}

		public IActionResult Index()
		{
			var students = _context.Students;
			return View("Index", students);
		}

		[HttpPost]
		public IActionResult AddStudent(Student student)
		{
			if (ModelState.IsValid)
			{
				_context.Students.Add(student);
				_context.SaveChanges();
				return RedirectToAction("Index");
			}
			return View("Index", student);
		}
	}
}
