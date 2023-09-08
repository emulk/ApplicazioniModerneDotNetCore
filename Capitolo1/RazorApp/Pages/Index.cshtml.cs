using Microsoft.AspNetCore.Mvc.RazorPages;


namespace RazorApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public List<string> items = new List<string> { "Mela", "Banana", "Arancia", "Kiwi" };

        private string UserName = "99";
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {



        }
    }
}