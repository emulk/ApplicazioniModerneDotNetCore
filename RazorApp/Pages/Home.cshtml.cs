using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorApp.Pages
{
    public class HomeModel : PageModel
    {
        public string Name { get; set; }
        public void OnGet()
        {
            Name = "Mario Rossi";
        }
    }
}
