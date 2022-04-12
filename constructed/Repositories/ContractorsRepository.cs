using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using constructed.Models;
using Dapper;

namespace constructed.Services
{
  public class ContractorsRepository
  {
    private readonly IDbConnection _db;
    public ContractorsRepository(IDbConnection db)
    {
      _db = db;
    }





    internal List<Contractor> GetAll()
    {
      string sql = @"
      SELECT * FROM contractors;";
      return _db.Query<Contractor>(sql).ToList();
    }

    internal Contractor GetById(int id)
    {
      string sql = @"
      SELECT * FROM contractors
      WHERE id = @id;";
      return _db.Query<Contractor>(sql, new { id }).FirstOrDefault();
    }

    internal string Delete(int id)
    {
      string sql = @"
      DELETE FROM contractors
      WHERE id = @id;
      ";
      int rowsAffected = _db.Execute(sql, new { id });
      if (rowsAffected > 0)
      {
        return "deleted";
      }
      throw new Exception("couldn't delete");
    }

    internal Contractor Create(Contractor conData)
    {
      string sql = @"
      INSERT INTO contractors
      (name)
      VALUES 
      (@Name);
      SELECT LAST_INSERT_ID();";
      int id = _db.ExecuteScalar<int>(sql, conData);
      conData.Id = id;
      return conData;
    }
  }
}