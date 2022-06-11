using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace MovieSystem.Models
{
	public class Movie
	{
		public int ID { get; set; }

		[Required]
		[StringLength(60, MinimumLength = 3)]
		public String Movie_Name { get; set; }

		[Required]
		[StringLength(60, MinimumLength = 3)]
		public String Plot { get; set; }

		[Required]
		[DataType(DataType.Date)]
		public String DateRelease{ get; set; }

		[Required]
		[StringLength(60, MinimumLength = 3)]
		public String Actors { get; set; }

		[Required]
		[StringLength(60, MinimumLength = 3)]
		public String Producers { get; set; }

		public String Poster { get; set; }

}
}
