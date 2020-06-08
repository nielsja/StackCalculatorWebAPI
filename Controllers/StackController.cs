using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace StackCalculatorWebAPI.Controllers
{
    [ApiController]
    public class StackController : ControllerBase
    {
        static Stack<decimal> stack = new Stack<decimal>();

        [HttpGet]
        [Route("api/Test")]
        public string Test()
        {
            return "Success";
        }

        [HttpPost]
        [Route("api/Push")]
        public void Push([FromBody]decimal number)

        {
            stack.Push(number);
        }

        [HttpPost]
        [Route("api/PushQuery")]
        public void PushQuery(decimal number)
        {
            stack.Push(number);
        }

        [HttpPost]
        [Route("api/Print")]
        public decimal Print()
        {
            return stack.Peek();
        }
    }
}