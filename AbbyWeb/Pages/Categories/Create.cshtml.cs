using AbbyWeb.Model;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AbbyWeb.Pages.Categories;

public class CreateModel : PageModel
{
    public Category Category { get; set; }
    public void OnGet()
    {
    }
}