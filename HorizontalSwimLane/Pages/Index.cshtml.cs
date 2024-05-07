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

        public List<Service> ArrangedServices { get; private set; }

        public IndexModel(ILogger<IndexModel> logger, ServiceContext serviceContext)
        {
            _logger = logger;
            _serviceContext = serviceContext;
        }

        public void OnGet()
        {
            // Retrieve data from the database using Entity Framework Core
            //Services = _serviceContext.Services.ToList();
            Services = _serviceContext.Services.Where(service => service.TraceId == "JKDAAA02").ToList();

            //List<int> dataList = Services
            //    .Where(service => service.TraceId == "JKDAAA02")
            //    .Select(service => service.Id)
            //    .ToList();
            List<Service> newOrder = new List<Service>();
            GetMainFlow(Services, newOrder);

            var serviceLookup = Services.ToDictionary(service => service.Id);

            // Populate ArrangedServices using newOrder and the serviceLookup dictionary
            ArrangedServices = newOrder.Select(service => serviceLookup.ContainsKey(service.Id) ? serviceLookup[service.Id] : null)
                                       .Where(service => service != null)
                                       .ToList();
        }

        public static void AddFirstDataToList(List<Service> dataList, List<Service> newOrder)
        {
            if (dataList.Count > 0)
            {
                newOrder.Add(dataList[0]);
                dataList.RemoveAt(0);
            }
            else
            {
                Console.WriteLine("List is empty.");
            }
        }

        public static void ReverseList(List<Service> dataList)
        {
            dataList.Reverse();
        }

        public static void GetMainFlow(List<Service> service, List<Service> newOrder)
        {
            List<Service> dataList = new List<Service>(service);
            string serviceName = dataList.FirstOrDefault()?.ServiceName;
            AddFirstDataToList(dataList, newOrder);
            ReverseList(dataList);
            List<List<Service>> listOfLists = new List<List<Service>>();
            List<Service> innerList = new List<Service>();
            for (int i = 0; i < dataList.Count; i++)
            {
                innerList.Add(dataList[i]);
                if (dataList[i].ServiceName == serviceName)
                {
                    listOfLists.Add(innerList);
                    innerList = new List<Service>();
                }
            }

            foreach (var list in listOfLists)
            {
                MoveLastToFront(list);
                foreach (var item in list)
                {
                    newOrder.Add(item);
                }
            }
        }

        public static void MoveLastToFront(List<Service> list)
        {
            if (list.Count <= 1)
            {
                return;
            }

            Service lastItem = list[list.Count - 1];
            list.RemoveAt(list.Count - 1);
            list.Insert(0, lastItem);
        }
    }
}
