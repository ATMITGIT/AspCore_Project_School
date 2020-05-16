using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
	public class Subvideo
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int SubVideoId { get; set; }
		public string SubVudeoTitle { get; set; }
		public string SubVideoBody { get; set; }
		public string SubVideoviemo { get; set; }
	}
}
