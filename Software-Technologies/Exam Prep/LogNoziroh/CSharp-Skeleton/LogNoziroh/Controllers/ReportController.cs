namespace LogNoziroh.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Models;
    using System.Linq;

    public class ReportController : Controller
    {
        private readonly LogNozirohDbContext dbContext;

        public ReportController(LogNozirohDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            var reports = this.dbContext.Reports.ToList();

            return View(reports);
        }

        [HttpGet]
        [Route("details/{id}")]
        public IActionResult Details(int id)
        {
            var film = this.dbContext.Reports.Find(id);

            return View(film);
        }

        [HttpGet]
        [Route("create")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route("create")]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Report report)
        {
            if (ModelState.IsValid)
            {
                this.dbContext.Reports.Add(report);

                this.dbContext.SaveChanges();
                return Redirect("/");
            }
            return View();
        }

        [HttpGet]
        [Route("delete/{id}")]
        public IActionResult Delete(int id)
        {
            var film = this.dbContext.Reports.Find(id);
            return View(film);
        }

        [HttpPost]
        [Route("delete/{id}")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirm(Report reportModel)
        {
            this.dbContext.Reports.Remove(reportModel);
            this.dbContext.SaveChanges();
            return Redirect("/");
        }
    }
}
