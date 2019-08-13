using System;
using Xunit;
using WebApi.Controllers;
using FluentAssertions;
namespace webApiTest
{
    public class HelloHiDisplay
    {
        ValuesController valuesController = new ValuesController();
        [Fact]
        public void GetHelloAndDisplayHi()
        {
           
            var response = valuesController.Get("hello");
            Assert.Equal("hi",response.Value);

            response = valuesController.Get("Hello");
            Assert.Equal("hi", response.Value);

            response = valuesController.Get("HELlo");
            Assert.Equal("hi", response.Value);

            response = valuesController.Get("HellO");
            Assert.Equal("hi", response.Value);



        }

        [Fact]
        public void GetHiAndDisplayHello()
        {
            

            var response = valuesController.Get("hi");
            Assert.Equal("hello", response.Value);

            response = valuesController.Get("Hi");
            Assert.Equal("hello", response.Value);

            response = valuesController.Get("HI");
            Assert.Equal("hello", response.Value);



        }


        public void GetInvalidData()
        {
           

            var response = valuesController.Get("Helllllo");
            Assert.Equal("Invalid Data", response.Value);

            response = valuesController.Get("Hey");
            Assert.Equal("Invalid Data", response.Value);

            response = valuesController.Get("hmm");
            Assert.Equal("Invalid Data", response.Value);



        }


    }
}
