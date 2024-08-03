using Abby.DataAccess.Data;
using Abby.DataAccess.Repository.IRepository;
using Abby.Models;

namespace Abby.DataAccess.Repository
{
	public class ApplicationUserRepository : Repository<ApplicationUser>, IApplicationUserRepository
	{
		private readonly ApplicationDbContext _db;

		public ApplicationUserRepository(ApplicationDbContext db) : base(db)
		{
			_db = db;
		}

	}
}