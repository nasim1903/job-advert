using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace job_advert.Services
{
    public class JobService : iJobService
    {
        public Task<List<Job>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<List<Job>> GetLocation(string location)
        {
            throw new NotImplementedException();
        }

        public Task<List<Job>> GetName(string title)
        {
            throw new NotImplementedException();
        }
    }
}