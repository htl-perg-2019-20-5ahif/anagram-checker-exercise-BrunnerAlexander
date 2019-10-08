using AnagramChecker.Models;
using AnagramChecker.Services;
using AnagramCheckerWeg.Services;
using Microsoft.AspNetCore.Mvc;

namespace AnagramCheckerWeg.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AnagramController : ControllerBase
    {

        [HttpGet]
        public IActionResult Get([FromBody] AnagramStrings values)
        {
            var awc = new AnagramWordsChecker();

            if (awc.Check(values.w1, values.w2))
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpGet("getKnownAnagrams")]
        public IActionResult Get([FromQuery] string w)
        {
            var dfr = new DictionaryFileReader();
            Dictionary d = dfr.Read();
            var result = dfr.GetKnown(d, w);

            if(result == null)
            {
                return BadRequest();
            }
            else
            {
                return Ok(result.ToArray());
            }
        }
    }
}
