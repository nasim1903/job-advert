using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace job_advert.Dtos
{
    public class GetJobsDto
    {
        public int id { get; set; }
        public string JobTitle { get; set; } = ".NET developer";
        public string Description { get; set; } = "This is placeholder text";
        public int Salary { get; set; } = 30000;
    }
}