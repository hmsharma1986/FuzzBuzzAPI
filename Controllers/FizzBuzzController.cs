using Microsoft.AspNetCore.Mvc;
using FizzBuzzApi.Services;

namespace FizzBuzzApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FizzBuzzController : ControllerBase
    {
        private readonly IFizzBuzzServiceFactory _fizzBuzzServiceFactory;

        public FizzBuzzController(IFizzBuzzServiceFactory fizzBuzzServiceFactory)
        {
            _fizzBuzzServiceFactory = fizzBuzzServiceFactory;
        }

        [HttpPost]
        public IActionResult ProcessValues([FromBody] string[] values)
        {
            var fizzBuzzService = _fizzBuzzServiceFactory.Create();
            var (results, divisions) = fizzBuzzService.ProcessValues(values);
            return Ok(new { Results = results, Divisions = divisions });
        }
    }
}
