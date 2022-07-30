using ForceCal;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MyController : ControllerBase
    {
        private readonly ILogic _logic;

        public MyController(ILogic logic)
        {
            _logic = logic;
        }

        [HttpPost]
        public IActionResult Multiply(MultiplyViewModel model)
        {
            var reply = _logic.Multiply(model);
            return Ok(reply);
        }
        

    }
}
