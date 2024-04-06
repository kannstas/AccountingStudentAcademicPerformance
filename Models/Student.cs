using System.ComponentModel.DataAnnotations;

namespace AccountingStudentAcademicPerformance.Models
{
	public class Student
	{
		public int Id { get; set; }

		[Required]
		public string Name { get; set; }

		[Required]
		public int Score { get; set; }
	}
}
