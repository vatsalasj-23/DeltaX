using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieSystem.Models
{
	public class User
	{
		public int ID { get; set; }

		public String UserName { get; set; }
		public String FirstName { get; set; }
		public String LastName { get; set; }
		public String City { get; set; }
		public String State { get; set; }
		public String Country { get; set; }
	}
}
