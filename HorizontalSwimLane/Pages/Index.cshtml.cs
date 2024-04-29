using HorizontalSwimLane.Model;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HorizontalSwimLane.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly ServiceContext _serviceContext;

        public List<string> ServiceNames { get; private set; } = new List<string>();
        public Dictionary<string, List<Service>> ServiceGroups { get; private set; } = new Dictionary<string, List<Service>>();

        public string CurrentServiceName { get; private set; } = ""; // Define CurrentServiceName property

        public IndexModel(ILogger<IndexModel> logger, ServiceContext serviceContext)
        {
            _logger = logger;
            _serviceContext = serviceContext;
        }

        public void OnGet()
        {
            // Retrieve distinct service names
            ServiceNames = _serviceContext.Services.Select(s => s.Name).Distinct().ToList();

            // Group services by service name
            foreach (var serviceName in ServiceNames)
            {
                ServiceGroups[serviceName] = _serviceContext.Services.Where(s => s.Name == serviceName).ToList();
            }

            // Set the CurrentServiceName (for example, set to the first service name)
            CurrentServiceName = ServiceNames.FirstOrDefault() ?? ""; // Set to the first service name or default value
        }
    }
}
