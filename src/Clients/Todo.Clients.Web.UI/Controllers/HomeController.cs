using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Todo.Domain.Entities;
using Todo.Domain.Services;

namespace Todo.Clients.Web.UI.Controllers {
    public class HomeController : BaseController {
        protected ITaskService taskService;

        //Use IoC constructor injector
        public HomeController(ITaskService taskService)
        {
            this.taskService = taskService;
        }

        public ActionResult Index()
        {
            var tasks = taskService.GetAll();
            return View(tasks);
        }

    }
}
