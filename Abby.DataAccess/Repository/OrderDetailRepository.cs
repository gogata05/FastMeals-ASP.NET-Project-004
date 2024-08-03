using Abby.DataAccess.Data;
using Abby.DataAccess.Repository.IRepository;
using Abby.Models;

namespace Abby.DataAccess.Repository
{
	public class OrderDetailRepository : Repository<OrderDetails>, IOrderDetailRepository
	{
		private readonly ApplicationDbContext _db;

		public OrderDetailRepository(ApplicationDbContext db) : base(db)
		{
			_db = db;
		}

		public void Update(OrderDetails obj)
		{
			_db.OrderDetails.Update(obj);
		}
	}
}