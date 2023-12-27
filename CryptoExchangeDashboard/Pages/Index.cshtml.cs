using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CryptoExchangeDashboard.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }

        public string GetTime()
        {
            return DateTime.Now.ToString("dd/MM/yyyy HH:mm");
        }


    }
}