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
                new MenuItem { Id = Guid.NewGuid(), Position = 2, Title = "Master", Url = "~/Master", Icon = "md md-group" },
                new MenuItem { Id = Guid.NewGuid(), Position = 3, Title = "Administration", Url = "~/Adminstration", Icon = "md md-account-child" },                
                new MenuItem { Id = Guid.NewGuid(), Position = 4, Title = "Attendance", Url = "~/Attendance", Icon = "md md-av-timer" },
                new MenuItem { Id = Guid.NewGuid(), Position = 5, Title = "Leaving", Url = "~/Leaving", Icon = "md md-exit-to-app" },
                new MenuItem { Id = Guid.NewGuid(), Position = 6, Title = "Medical", Url = "~/Medical", Icon = "md md-local-hospital" },
                new MenuItem { Id = Guid.NewGuid(), Position = 7, Title = "Organization", Url = "~/Organization", Icon = "md md-group" },                    
                new MenuItem { Id = Guid.NewGuid(), Position = 7, Title = "Payroll", Url = "~/Payroll", Icon = "md md-attach-money" },
                new MenuItem { Id = Guid.NewGuid(), Position = 9, Title = "Appraisals", Url = "~/PerformanceAppraisals", Icon = "md md-trending-up" },
                new MenuItem { Id = Guid.NewGuid(), Position = 10, Title = "Recruitment", Url = "~/Recruitment", Icon = "md md-group-add" },
                new MenuItem { Id = Guid.NewGuid(), Position = 11, Title = "Training", Url = "~/Training", Icon = "md md-school" },
                new MenuItem { Id = Guid.NewGuid(), Position = 12, Title = "Travelling", Url = "~/Travelling", Icon = "md md-public" }
            };

            _menus.Add(new MenuItem { Id = Guid.NewGuid(), Position = 1, Title = "Branch", Url = "~/Organization/Master", Icon = "md md-account-child", Parent = _menus.Where(x => x.Title.Contains("Master")).SingleOrDefault().Id });
            _menus.Add(new MenuItem { Id = Guid.NewGuid(), Position = 2, Title = "Division", Url = "~/Organization/Master/Division", Icon = "md md-account-child", Parent = _menus.Where(x => x.Title.Contains("Master")).SingleOrDefault().Id });




        }

        public async Task<IViewComponentResult> InvokeAsync()
        {           
            return await Task.FromResult((IViewComponentResult)View("Default", _menus));
        }
    }
}
