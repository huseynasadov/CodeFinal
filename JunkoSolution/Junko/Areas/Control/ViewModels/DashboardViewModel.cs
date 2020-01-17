using Junko.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Junko.Areas.Control.ViewModels
{
    public class DashboardViewModel
    {
        public List<Product> Products { get; set; }
        public List<OrderProduct> OrderProducts { get; set; }
        public decimal AmountMonthly { get; set; }
        public decimal TotalAmount { get; set; }
        public int UsersCount { get; set; }
        public int OnlineUsersCount { get; set; }
        public int BlogsCount { get; set; }
    }
}
