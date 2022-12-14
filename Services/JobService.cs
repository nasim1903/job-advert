using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;

namespace job_advert.Services
{
    public class JobService : iJobService
    {
        private readonly IMapper _mapper;
        public JobService(IMapper mapper)
        {
            _mapper = mapper;
            
        }
        private static List<Job> jobs = new List<Job>(){
            new Job(),
            new Job{JobTitle = "Front end developer", Description = "Must have knowledge in React", Location = "London", Salary = 40000 }
        };
        public async Task<List<Job>> GetAll()
        {
            return jobs;
        }

        public async Task<List<Job>> GetLocation(string location)
        {
            return jobs.Where(c => c.Location.ToLower() == location.ToLower()).ToList();
        }

        public async Task<List<Job>> GetName(string title)
        {
            return jobs.Where(c => c.JobTitle.ToLower() == title.ToLower()).ToList();
        }

        public async Task<List<Job>> PostJob(string title, string location)
        {
            var newJob = new Job{JobTitle = title, Location = location};
            jobs.Add(newJob);
            return jobs;
        }
    }
}