using Abby.DataAccess.Repository.IRepository;
using Abby.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;

namespace AbbyWeb.Pages.Admin.MenuItems;

[BindProperties]
public class UpsertModel : PageModel
{
    private readonly IUnitOfWork _unitOfWork;

    public MenuItem MenuItem { get; set; }

    public UpsertModel(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
        MenuItem = new();
    }
    public void OnGet()
    {
    }

    public async Task<IActionResult> OnPost()
    {

        //if (ModelState.IsValid)
        //{
        //    _unitOfWork.FoodType.Add(FoodType);
        //    _unitOfWork.Save();
        //    TempData["success"] = "FoodType created successfully";
        //    return RedirectToPage("Index");
        //}
        return Page();
    }
}