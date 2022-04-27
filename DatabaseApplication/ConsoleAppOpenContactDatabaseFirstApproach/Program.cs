using ConsoleAppOpenContactDatabaseFirstApproach.Contexts;
using ConsoleAppOpenContactDatabaseFirstApproach.Models;
using System;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleAppOpenContactDatabaseFirstApproach
{
	class Program
	{
		static async Task Main()
		{
			using (var db = new UserContext())
			{
				try
				{
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

					joinResponse.ForEach(x => Console.WriteLine(x.Email));

					Console.ReadLine();

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
