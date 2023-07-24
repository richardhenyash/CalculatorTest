using Microsoft.AspNetCore.Mvc;
using CalculatorDomain;

namespace Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : ControllerBase
    {
        [HttpGet("Add/({left}/{right})")]
        public int Get(int left, int right)
        {
            var calculator = new Calculator();
            return calculator.Sum(left, right);
        }
    }
}