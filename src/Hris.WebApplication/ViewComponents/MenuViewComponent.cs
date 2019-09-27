using Hris.Infrastructure.Database.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hris.WebApplication.ViewComponents
{
    public class MenuViewComponent : ViewComponent
    {
        private readonly List<MenuItem> _menus;

        public MenuViewComponent()
        {

            _menus = new List<MenuItem>
            {
                new MenuItem { Id = Guid.NewGuid(), Position = 1, Title = "Dashboard", Url = "~/", Icon = "md md-dashboard" },
                new MenuItem { Id = Guid.NewGuid(), Position = 2, Title = "Administration", Url = "~/Adminstration", Icon = "md md-account-child" },
                new MenuItem { Id = Guid.NewGuid(), Position = 3, Title = "Attendance", Url = "~/Attendance", Icon = "md md-av-timer" },
                new MenuItem { Id = Guid.NewGuid(), Position = 4, Title = "Leaving", Url = "~/Leaving", Icon = "md md-exit-to-app" },
                new MenuItem { Id = Guid.NewGuid(), Position = 5, Title = "Medical", Url = "~/Medical", Icon = "md md-local-hospital" },
                new MenuItem { Id = Guid.NewGuid(), Position = 6, Title = "Organization", Url = "~/Organization", Icon = "md md-group" },
                new MenuItem { Id = Guid.NewGuid(), Position = 7, Title = "Payroll", Url = "~/Payroll", Icon = "md md-attach-money" },
                new MenuItem { Id = Guid.NewGuid(), Position = 8, Title = "Performance Appraisals", Url = "~/PerformanceAppraisals", Icon = "md md-trending-up" },
                new MenuItem { Id = Guid.NewGuid(), Position = 9, Title = "Recruitment", Url = "~/Recruitment", Icon = "md md-group-add" },
                new MenuItem { Id = Guid.NewGuid(), Position = 10, Title = "Training", Url = "~/Training", Icon = "md md-trending-up" },
                new MenuItem { Id = Guid.NewGuid(), Position = 11, Title = "Travelling", Url = "~/Travelling", Icon = "md md-trending-up" }
            };




        }

        public async Task<IViewComponentResult> InvokeAsync()
        {           
            return await Task.FromResult((IViewComponentResult)View("Default", _menus));
        }
    }
}
