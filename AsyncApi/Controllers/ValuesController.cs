using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AsyncApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public async Task<ActionResult<IEnumerable<string>>> Get()
        {
            Context context = new Context();
            var customers = await (from b in context.Customers
                                   orderby b.CustomerName
                                   select b).ToListAsync();

            return new string[] { "async 3.1", "value2" };
        }
    }
}
