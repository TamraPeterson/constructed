using System;
using constructed.Models;
using constructed.Services;
using Microsoft.AspNetCore.Mvc;

namespace constructed.Controllers
{
  [ApiController]
  [Route("api/[Controller]")]
  public class JobsController : ControllerBase
  {
    private readonly JobsService _js;
    public JobsController(JobsService js)
    {
      _js = js;
    }

    [HttpPost]
    public ActionResult<Job> Create([FromBody] Job jobData)
    {
      try
      {
        Job job = _js.Create(jobData);
        return Ok(jobData);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
  }
}