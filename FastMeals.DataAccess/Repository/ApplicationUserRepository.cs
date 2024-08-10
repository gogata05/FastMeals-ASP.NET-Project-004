using FastMeals.DataAccess.Data;
using FastMeals.DataAccess.Repository.IRepository;
using FastMeals.Models;

namespace FastMeals.DataAccess.Repository
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