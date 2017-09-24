using GreetingsProgram.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GreetingsProgram.Controllers
{
    public class HelloController : ApiController
    {
        private IGreeter _model;
        public HelloController(IGreeter model)
        {
            _model = model;
        }
        [HttpGet]
        [Route("Hello")]
        public string Hello()
        {
            return _model.SayHello();
        }
    }
}
