using System;
using System.Collections.Generic;
using constructed.Models;
using constructed.Services;
using Microsoft.AspNetCore.Mvc;

namespace constructed.Controllers
{
  [ApiController]
  [Route("api/[Controller]")]
  public class ContractorsController : ControllerBase
  {
    private readonly ContractorsService _conService;
    public ContractorsController(ContractorsService conService)
    {
      _conService = conService;
    }

    [HttpGet]
    public ActionResult<List<Contractor>> GetAll()
    {
      try
      {
        List<Contractor> contractors = _conService.GetAll();
        return Ok(contractors);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    [HttpGet("{id}")]
    public ActionResult<Contractor> GetById(int id)
    {
      try
      {
        Contractor contractor = _conService.GetById(id);
        return Ok(contractor);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    [HttpPost]
    public ActionResult<Contractor> Create([FromBody] Contractor conData)
    {
      try
      {
        Contractor contractor = _conService.Create(conData);
        return Ok(conData);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    [HttpDelete("{id}")]
    public ActionResult<string> Delete(int id)
    {
      try
      {
        _conService.Delete(id);
        return Ok("delorted bruv");
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }

  }
}