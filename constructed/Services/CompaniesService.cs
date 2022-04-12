
using System.Collections.Generic;
using constructed.Models;
using constructed.Repositories;

namespace constructed.Services
{
  public class CompaniesService
  {
    private readonly CompaniesRepository _coRepo;
    public CompaniesService(CompaniesRepository coRepo)
    {
      _coRepo = coRepo;
    }
    internal List<Company> GetAll()
    {
      return _coRepo.GetAll();
    }

    internal Company GetById(int id)
    {
      return _coRepo.GetById(id);
    }

    internal Company Create(Company conData)
    {
      return _coRepo.Create(conData);
    }

    internal string Delete(int id)
    {
      return _coRepo.Delete(id);
    }
  }
}