using Microsoft.AspNetCore.Mvc;

namespace APBD_Task_7.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController
    {
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetCustomerRentals()
        {
            var customer = 
        }
    }
}
