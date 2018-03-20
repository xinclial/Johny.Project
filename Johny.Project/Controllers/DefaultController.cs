using Johny.Project.Model.EF;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Johny.Project.Controllers
{
    public class DefaultController : Controller
    {
        WorkServices DataService = new WorkServices();

        // GET: Default
        public ActionResult Index()
        {
            //var model = Service_VM_R_Base.GetByID(95368);

            var list = DataService.VM_R_BaseRepository.Get(a => a.Name.Contains("龙门")).Take(40).ToList();
            return View();
        }
    }
}