using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using job_advert.Services;
using Microsoft.AspNetCore.Mvc;

namespace job_advert.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class JobController : ControllerBase
    {
        private readonly iJobService _jobService;

        public JobController(iJobService jobService)
        {
            _jobService = jobService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Job>>> get()
        {
            return Ok(await _jobService.GetAll());
        }

        [HttpGet("location/{location}")]
        public async Task<ActionResult<List<Job>>> getPlace(string location)
        {
            return Ok(await _jobService.GetLocation(location));
        }
        [HttpGet("title/{title}")]
        public async Task<ActionResult<List<Job>>> getName(string title)
        {
            return Ok(await _jobService.GetName(title));
        }
    }
}