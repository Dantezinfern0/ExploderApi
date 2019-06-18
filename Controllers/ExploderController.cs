using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace exploderapi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ExploderController : ControllerBase
  {
    // GET api/values
    [HttpGet("{s}")]
    public ActionResult<string> GetExploded(string s)
    {
      return string.Join("", s.Select(c => new String(c, int.Parse(c.ToString()))));
    }

  }
}
