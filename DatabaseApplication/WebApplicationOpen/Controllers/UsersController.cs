using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplicationOpen.Contexts;
using WebApplicationOpen.Models;
using WebApplicationOpen.Models.DalModels.Users;

namespace WebApplicationOpen.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class UsersController : ControllerBase
	{

		private static ApplicationContext _context;
		public UsersController(ApplicationContext context)
		{
			_context = context;
		}

		[HttpGet]
		[Route("all")]
		public async Task<List<UserDal>> GetAllUsers()
		{
			return await _context.Users.Include(x=>x.Clients).ToListAsync();
		}
	}
}
