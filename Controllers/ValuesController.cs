using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace JB.Inspection.EditorConfig.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // POST api/values
        [HttpPost]
        public void ResharperPossibleNullReferenceExceptionHighlighting([FromBody] object obj)
		{
			if (obj != null)
			{
				Console.WriteLine(obj.ToString());
			}

			Console.WriteLine(obj.GetHashCode());
		}
    }
}
