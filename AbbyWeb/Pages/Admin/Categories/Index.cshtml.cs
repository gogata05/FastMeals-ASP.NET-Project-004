using Abby.DataAccess.Repository.IRepository;
using Abby.Models.Model;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace AbbyWeb.Pages.Admin.Categories;

public class IndexModel : PageModel
{
    private readonly ICategoryRepository _dbCategory;

    public IEnumerable<Category> Categories { get; set; }

    public IndexModel(ICategoryRepository dbCategory)
    {
        _dbCategory = dbCategory;
    }

    public void OnGet()
    {
        Categories = _dbCategory.GetAll();
    }
}