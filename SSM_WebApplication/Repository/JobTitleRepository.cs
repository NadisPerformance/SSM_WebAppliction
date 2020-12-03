using SSM_WebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SSM_WebApplication.Repository
{
    public class JobTitleRepository : IJobTitleRepository
    {
        private readonly AppDbContext _appDbContext;
        public JobTitleRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<JobTitle> GetAllJobTitle()
        {
            return _appDbContext.JobTitles;
        }

        public JobTitle GetJobTitleById(int Id)
        {
            return _appDbContext.JobTitles.FirstOrDefault(j => j.JobId==Id);
        }
    }
}
