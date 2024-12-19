using System;
using System.Collections.Generic;

namespace MyWebApp.Models
{
    public class DashboardViewModel
    {
        public int TotalUsers { get; set; }
        public int ActiveUsers { get; set; }
        public decimal Revenue { get; set; }
        public List<RecentActivity> RecentActivities { get; set; }
    }

    public class RecentActivity
    {
        public string Description { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
