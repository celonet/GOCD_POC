using System;
using System.Collections.Generic;
using GoCD_Poc.Api.Controllers;
using Microsoft.AspNetCore.Mvc;
using Xunit;

namespace GoCD_Poc.Test
{
    public class ValuesControllerTest
    {
        private readonly ValuesController _controller;

        public ValuesControllerTest() => _controller = new ValuesController();

        [Fact]
        public void Get()
        {
            var result = _controller.Get();

            var lst = (IList<string>)result.Value;

            Assert.NotNull(lst);
            Assert.Equal(2, lst.Count);
        }

        [Fact]
        public void GetById()
        {
            var result = _controller.Get(1);

            Assert.NotNull(result.Value);
            Assert.Equal("value", result.Value);
        }

        [Fact]
        public void Post()
        {
            _controller.Post("value");
        }

        [Fact]
        public void Put()
        {
            _controller.Put(1, "value");
        }

        [Fact]
        public void Delete()
        {
            _controller.Delete(1);
        }
    }
}
