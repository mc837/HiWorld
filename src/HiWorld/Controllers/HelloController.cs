﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace HiWorld.Controllers
{
    [Route("api/[controller]")]
    public class HelloController : Controller
    {
        // GET: api/values
        [HttpGet("{word}")]
        public string Get(string word)
        {
            return "Hello " + word;
        }
    }
}
