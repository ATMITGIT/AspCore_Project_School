using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
	public class Subtopic
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int SubtopicId { get; set; }
		public string SubtopicTitle { get; set; }
		public string SubtopicBody { get; set; }
		public int SubVideoId { get; set; }
	}
}
