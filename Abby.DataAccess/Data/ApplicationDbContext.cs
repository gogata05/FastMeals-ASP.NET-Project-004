using Abby.Models;
using Abby.Models.Model;
using Microsoft.EntityFrameworkCore;

namespace Abby.DataAccess.Data;
public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {

    }
    public DbSet<Category> Category { get; set; }
    public DbSet<FoodType> FoodType { get; set; }
}