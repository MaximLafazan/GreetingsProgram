using GreetingsProgram.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GreetingsProgram.Models
{
    public class Hello: IGreeter
    {
        public string SayHello()
        {
            return "Hi everyone!";
        }
    }
}