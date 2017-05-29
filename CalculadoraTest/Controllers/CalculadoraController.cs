using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CalculadoraTest.Controllers
{
    public class CalculadoraController : ApiController
    {


     
      public string Getone()
        {
            return "xxxxx";

        }

        public string Get(string id)
        {
            id = "1";

            return id;

        }



    }
}
