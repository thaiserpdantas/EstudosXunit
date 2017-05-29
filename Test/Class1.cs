using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using CalculadoraTest.Controllers;
using System.Web.Http;


namespace Test
{
    public class RecursosTeste
    {

       public CalculadoraController CalculadoraTest;




        public RecursosTeste()
        {
            CalculadoraController CalculadoraTest = new CalculadoraController();

        }


    }


    public class Class1 : IClassFixture<RecursosTeste>
    {
        RecursosTeste recurso;

        public Class1(RecursosTeste recurso)
        {
            this.recurso = recurso;

        }

        [Fact]
        public void TestandoGet()
        {
            string retorno = recurso.CalculadoraTest.Getone();


        }



    }
}
