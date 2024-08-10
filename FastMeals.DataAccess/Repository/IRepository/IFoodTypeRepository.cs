using FastMeals.Models;

namespace FastMeals.DataAccess.Repository.IRepository
{
    public interface IFoodTypeRepository : IRepository<FoodType>
    {
        void Update(FoodType obj);

    }
}