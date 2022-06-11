using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MovieSystem.Models
{
	public class Producer
	{
		public int ID { get; set; }

		[Required]
		[StringLength(60, MinimumLength = 3)]
		public String Producer_Name { get; set; }

		[Required]
		[StringLength(60, MinimumLength = 3)]
		public String Bio { get; set; }

		[Required]
		[StringLength(60, MinimumLength = 3)]
		public String Company { get; set; }


		[Required]
		[DataType(DataType.Date)]
		public String DOB { get; set; }

		[Required]
		public String Gender { get; set; }
	}
}
