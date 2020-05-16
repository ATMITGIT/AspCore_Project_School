using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
	public class Course
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int CourseId { get; set; }
		public string CourseImage { get; set; }
		public string CourseBody { get; set; }
		public string CourseTheme { get; set; }
		public int SubtopicId { get; set; }

	}
}
