using Microsoft.AspNetCore.Mvc;
using SSM_WebApplication.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SSM_WebApplication.Controllers
{
    public class JobTitleController : Controller
    {
        private readonly IJobTitleRepository _jobTitleRepository;
        public JobTitleController(IJobTitleRepository jobTitleRepository)
        {
            _jobTitleRepository = jobTitleRepository;
        }
        public IActionResult List()
        {
            var jobTitle = _jobTitleRepository.GetAllJobTitle();
            return View(jobTitle);
        }
        public IActionResult Detail(int idJobTitle)
        {
            var jobTitle = _jobTitleRepository.GetJobTitleById(idJobTitle);
            if (jobTitle == null)
                return NotFound();
            return View(jobTitle);
        }
    }
}
