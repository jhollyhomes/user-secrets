using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace SecretsWebApp.Pages
{
    public class IndexModel : PageModel
    {
        public IndexModel(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public string SecretValue { get; set; }

        public IConfiguration Configuration { get; }

        public void OnGet()
        {
            SecretValue = Configuration["MySecret"];
        }
    }
}
