using SSM_WebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SSM_WebApplication.Repository
{
    public interface IJobTitleRepository
    {
        IEnumerable<JobTitle> GetAllJobTitle();
        JobTitle GetJobTitleById(int Id);
    }
}
