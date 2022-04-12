using System.Collections.Generic;
using constructed.Models;

namespace constructed.Services
{
  public class ContractorsService
  {
    private readonly ContractorsRepository _conRepo;
    public ContractorsService(ContractorsRepository conRepo)
    {
      _conRepo = conRepo;
    }
    internal List<Contractor> GetAll()
    {
      return _conRepo.GetAll();
    }

    internal Contractor GetById(int id)
    {
      return _conRepo.GetById(id);
    }

    internal Contractor Create(Contractor conData)
    {
      return _conRepo.Create(conData);
    }

    internal string Delete(int id)
    {
      return _conRepo.Delete(id);
    }
  }
}