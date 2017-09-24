using GreetingsProgram.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GreetingsProgram.Controllers
{
    public class HiController : ApiController
    {
        private IGreeter _model;
        public HiController(IGreeter model)
        {
            _model = model;
        }
        [HttpGet]
        [Route("Hi")]
        public string Hi()
        {
            return _model.SayHello();
        }
    }
}
