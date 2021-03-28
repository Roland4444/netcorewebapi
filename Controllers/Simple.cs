using System;
using Microsoft.AspNetCore.Mvc;

namespace react.Controllers
{
    [ApiController]
    [Route("abrams")]
    public class Simple2 : ControllerBase
    {

       

        public Simple2()
        {
           
        }

        [HttpGet]

     public String Get()
        {
            var rng = new Random();         
            return $"True way {rng.NextDouble()}";
        }
    }
}
