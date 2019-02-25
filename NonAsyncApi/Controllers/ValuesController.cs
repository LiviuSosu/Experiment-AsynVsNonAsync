using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL;
using Microsoft.AspNetCore.Mvc;

namespace NonAsyncApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            Context context = new Context();
            var customers = (from b in context.Customers
                                  orderby b.CustomerName
                                  select b).ToList();
            return new string[] { "non async 3.1", "value2" };
        }
    }
}
