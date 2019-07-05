using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace exploderapi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class MumblingController : ControllerBase
  {
    // GET api/values
    [HttpGet("{s}")]
    public ActionResult<string> GetMumbledWords(string s)
    {
      string result = "";
      char[] stringArray;
      stringArray = s.ToCharArray();
      string abacaba = "";
      for (int i = 0; i < stringArray.Length; i++)
      {
        abacaba += stringArray[i] + abacaba;
        char.ToLower(stringArray[i]);
        for (int j = 0; j <= i; j++)
        {
          if (j == 0)
          {
            result = result + char.ToUpper(stringArray[i]);
          }
          else
          {
            result = result + char.ToLower(stringArray[i]);
          }
        }
        if (i != stringArray.Length - 1)
        {
          result = result + '-';
        }
      }
      return abacaba;
    }
  }

}

