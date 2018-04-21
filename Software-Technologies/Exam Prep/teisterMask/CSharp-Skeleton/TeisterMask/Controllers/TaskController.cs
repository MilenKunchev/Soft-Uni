namespace TeisterMask.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Models;
    using System.Collections.Generic;
    using System.Linq;

    public class TaskController : Controller
    {
        private readonly TeisterMaskDbContext dbContext;

        public TaskController(TeisterMaskDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return null;
        }

        [HttpGet]
        [Route("/create")]
        public IActionResult Create()
        {
            return null;
        }

        [HttpPost]
        [Route("/create")]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Task task)
        {
            return null;
        }

        [HttpGet]
        [Route("/edit/{id}")]
        public IActionResult Edit(int id)
        {
            return null;
        }

        [HttpPost]
        [Route("/edit/{id}")]
        [ValidateAntiForgeryToken]
        public IActionResult EditConfirm(Task taskModel)
        {
            return null;
        }
    }
}
