using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace job_advert.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class JobController : ControllerBase
    {

        private static List<Job> jobs = new List<Job>(){
            new Job{JobTitle = ".NET Developer", Description = "This is placeholder text"}
        };

        [HttpGet]
        public ActionResult<List<Job>> get(){
            return Ok(jobs);
        }
    }
}