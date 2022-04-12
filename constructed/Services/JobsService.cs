using System.Collections.Generic;
using constructed.Models;
using constructed.Repositories;

namespace constructed.Services
{
  public class JobsService
  {
    private readonly JobsRepository _jr;
    public JobsService(JobsRepository jr)
    {
      _jr = jr;
    }
    internal List<Job> GetAllCompanyJobs(int id)
    {
      return _jr.GetAllCompanyJobs(id);
    }
  }
}