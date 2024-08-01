using Abby.DataAccess.Repository.IRepository;
using Abby.Models.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;

namespace AbbyWeb.Pages.Admin.Categories;

[BindProperties]
public class CreateModel : PageModel
{
    private readonly IUnitOfWork _unitOfWork;

    public Category Category { get; set; }


    public CreateModel(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }
    public void OnGet()
    {
    }

    public async Task<IActionResult> OnPost()
    {
        if (Category.Name == Category.DisplayOrder.ToString())
        {
            ModelState.AddModelError("Category.Name", "The DisplayOrder cannot exactly match the Name.");
        }
        if (ModelState.IsValid)
        {
            _unitOfWork.Category.Add(Category);
            _unitOfWork.Save();
            TempData["success"] = "Category created successfully";
            return RedirectToPage("Index");
        }
        return Page();
    }
}