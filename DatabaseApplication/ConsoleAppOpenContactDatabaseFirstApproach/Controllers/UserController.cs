using ConsoleAppOpenContactDatabaseFirstApproach.Contexts;
using ConsoleAppOpenContactDatabaseFirstApproach.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace ConsoleAppOpenContactDatabaseFirstApproach.Controllers
{
	public class UserController : Controller
	{
		public UserController()
		{

		}

		[HttpGet]
		public async Task<List<UserViewModel>> ReadAllUsersAsync()
		{
			using (var db = new UserContext())
			{
				try
				{
					if (db.Users.Any() && db.BackendUsers.Any() && db.UserInRoles.Any() && db.Roles.Any())
					{
						//TODO: try to rewrite with as queryable async when core api would be possible
						var backendUsersDalCollection = await db.BackendUsers.ToListAsync();

						//TODO: try to rewrite with as first or default async when core api would be possible
						var joinResponse = backendUsersDalCollection.Join(db.Roles,
							backendUserDal => backendUserDal.User.UserRoles.First().RoleId,
							roleEntity => roleEntity.RoleId, (backendUserDal, roleEntity) =>
								new UserViewModel()
								{
									UserId = backendUserDal.User.UserId,
									FullName = backendUserDal.FullName,
									Login = backendUserDal.User.Login,
									Email = backendUserDal.User.Email,
									IsActivated = backendUserDal.User.IsActive,
									Role = (UserRoleEnum)roleEntity.RoleId
								}).ToList();

						return joinResponse;
					}

					return default;
				}
				catch (Exception e)
				{
					Debug.WriteLine(e);
					throw;
				}
			}
		}
	}
}
