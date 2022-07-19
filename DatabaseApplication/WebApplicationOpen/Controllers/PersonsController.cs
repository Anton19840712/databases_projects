using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplicationOpen.Contexts;
using WebApplicationOpen.Models;

namespace WebApplicationOpen.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class PersonsController : ControllerBase
	{
		private static ApplicationContext _context;
		public PersonsController(ApplicationContext context)
		{
			_context = context;
		}

		[HttpGet]
		public string Get()
		{
			return "Hello, world";
		}

		[HttpGet]
		[Route("all")]
		public async Task<List<Person>>GetAllPersons()
		{
			return await _context.Persons.ToListAsync();
		}
	}
}
