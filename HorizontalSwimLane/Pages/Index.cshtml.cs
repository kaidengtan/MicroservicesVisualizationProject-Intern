using HorizontalSwimLane.Model;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HorizontalSwimLane.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly ServiceContext _serviceContext;

        // Property to hold the retrieved data
        public List<Service> Services { get; private set; }

        public IndexModel(ILogger<IndexModel> logger, ServiceContext serviceContext)
        {
            _logger = logger;
            _serviceContext = serviceContext;
        }

        public void OnGet()
        {
            // Retrieve data from the database using Entity Framework Core
            Services = _serviceContext.Services.ToList();
        }
    }
}
