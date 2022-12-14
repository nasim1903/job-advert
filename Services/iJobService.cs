using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
// using job_advert.Dtos;

namespace job_advert.Services
{
    public interface iJobService
    {
        Task<List<Job>> GetAll ();
        Task<List<Job>> GetName (string title);
        Task<List<Job>> GetLocation (string location);
        Task<List<Job>> PostJob (Job job);


    }
}