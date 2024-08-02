using System.Linq.Expressions;

namespace Abby.DataAccess.Repository.IRepository
{
	public interface IRepository<T> where T : class
	{
		//GET ALL, GET By ID FIRST OR DEFAULT, ADD, REMOVE, REMOVERANGE

		void Add(T entity);
		void Remove(T entity);
		void RemoveRange(IEnumerable<T> entity);
		IEnumerable<T> GetAll(string? includeProperties = null);
		T GetFirstOrDefault(Expression<Func<T, bool>>? filter = null);
	}
}