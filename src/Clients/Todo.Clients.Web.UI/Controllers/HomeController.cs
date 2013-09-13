using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Todo.Domain.Entities;
using Todo.Domain.Services;

namespace Todo.Clients.Web.UI.Controllers {
    public class HomeController : Controller {
        protected ITaskService taskService;

        //Use IoC constructor injector
        public HomeController(ITaskService taskService) {
            this.taskService = taskService;
        }

        public ActionResult Index() {
            //taskService.Persist(new Task() { Description = "Taak 1" });
            return View();
        }

    }
}
