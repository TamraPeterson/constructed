using System.Collections.Generic;
using System.Data;
using System.Linq;
using constructed.Models;
using Dapper;

namespace constructed.Repositories
{
  public class JobsRepository
  {
    private readonly IDbConnection _db;
    public JobsRepository(IDbConnection db)
    {
      _db = db;
    }

    internal List<Job> GetAllCompanyJobs(int id)
    {
      string sql = @"
      SELECT * FROM jobs j
      WHERE j.companyId = @id;";
      return _db.Query<Job>(sql, new { id }).ToList();
    }
  }
}