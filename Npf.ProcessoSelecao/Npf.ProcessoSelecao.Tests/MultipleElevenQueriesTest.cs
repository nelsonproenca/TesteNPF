using Npf.ProcessoSelecao.Application.Commands;
using Npf.ProcessoSelecao.Application.Models;
using Npf.ProcessoSelecao.Application.Queries;
using System;
using System.Collections.Generic;
using Xunit;

namespace Npf.ProcessoSelecao.Tests
{
    public class UnitTest1
    {
        /// <summary>
        /// Exists this way.
        /// [Theory]
        /// [ClassData(typeof(<className>))]
        /// </summary>
        [Fact]
        public void CalculateMultipleElevenTest()
        {
            List<ResultModel> results = new List<ResultModel>() 
            { 
                new ResultModel() { IsMultiple = true, Number = "286" },
                new ResultModel() { IsMultiple = false, Number = "123" }
            };

            MultipleElevenQueries multipleElevenQueries = this.GetQuery();

            var result = multipleElevenQueries.TransformToJson(results);

            Assert.True(result.Length > 0);
        }

        private MultipleElevenQueries GetQuery()
        {
            return new MultipleElevenQueries();
        }
    }
}
