using System;
using System.Collections.Generic;
using constructed.Models;
using constructed.Services;
using Microsoft.AspNetCore.Mvc;

namespace constructed.Controllers
{
  [ApiController]
  [Route("api/[Controller]")]
  public class CompaniesController : ControllerBase
  {
    private readonly CompaniesService _coService;
    private readonly JobsService _js;

    public CompaniesController(CompaniesService coService, JobsService js)
    {
      _coService = coService;
      _js = js;
    }


    [HttpGet]
    public ActionResult<List<Company>> GetAll()
    {
      try
      {
        List<Company> companies = _coService.GetAll();
        return Ok(companies);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    [HttpGet("{id}")]
    public ActionResult<Company> GetById(int id)
    {
      try
      {
        Company company = _coService.GetById(id);
        return Ok(company);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    [HttpPost]
    public ActionResult<Company> Create([FromBody] Company coData)
    {
      try
      {
        Company company = _coService.Create(coData);
        return Ok(coData);
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
        _coService.Delete(id);
        return Ok("delorted bruv");
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    // CompanyJobs
    [HttpGet("{id}/jobs")]
    public ActionResult<List<Job>> GetAllCompanyJobs(int id)
    {
      try
      {
        List<Job> coJobs = _js.GetAllCompanyJobs(id);
        return Ok(coJobs);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
  }
}