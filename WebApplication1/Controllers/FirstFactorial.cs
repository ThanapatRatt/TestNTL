using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FirstFactorial : ControllerBase
    {
        [HttpGet]
        public int Factorial(int req)
        {
            int total = 1;
            for (int i = 1; i <= req; i++)
            {
                total *= i;
            }

            return total;
        }
    }
}
