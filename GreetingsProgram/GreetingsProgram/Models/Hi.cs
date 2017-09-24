using GreetingsProgram.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GreetingsProgram.Models
{
    public class Hi: IGreeter
    {
        public string SayHello()
        {
            return "Hi there!";
        }
    }
}