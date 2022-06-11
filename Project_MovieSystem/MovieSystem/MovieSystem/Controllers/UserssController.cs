using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MovieSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserssController : ControllerBase
    {
		[HttpGet("GetUsers")]
		public IActionResult Get()
		{
			return Ok();
		}

		[HttpPost("CreateUser")]
		public IActionResult Create([FromBody] MovieSystem.Models.User request)
		{
			return Ok();
		}

		[HttpPut("UpdateUser")]
		public IActionResult Update([FromBody] MovieSystem.Models.User request)
		{
			return Ok();
		}

		[HttpDelete("DeleteUser/{Id}")]
		public IActionResult Delete(int Id)
		{
			return Ok();
		}
		/*
		private List<MovieSystem.Models.User> GetUsers()
		{
			return List< MovieSystem.Models.User>{
				new Models.User { UserName = "Vatsala SJ", FirstName = "Vatsala" },
				new Models.User { UserName = "Darshu SJ", FirstName = "Darshu" },
				new Models.User { UserName = "Pavan", FirstName = "Pavan" }

			};
		}
		*/

	}
}