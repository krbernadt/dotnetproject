using Microsoft.AspNetCore.Mvc;
using MyWebApp.Models;

namespace MyWebApp.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            var viewModel = new DashboardViewModel
            {
                TotalUsers = 100,
                ActiveUsers = 50,
                Revenue = 10000,
                RecentActivities = new List<RecentActivity>
                {
                    new RecentActivity { Description = "New user registered", Timestamp = DateTime.Now },
                    new RecentActivity { Description = "New order placed", Timestamp = DateTime.Now.AddHours(-1) }
                }
            };
            return View(viewModel);
        }
    }
}
