using Abby.Models;

namespace Abby.DataAccess.Repository.IRepository
{
	public interface IOrderDetailRepository : IRepository<OrderDetails>
	{
		void Update(OrderDetails obj);

	}
}