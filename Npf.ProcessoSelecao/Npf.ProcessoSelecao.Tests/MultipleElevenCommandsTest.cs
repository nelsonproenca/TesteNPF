using Npf.ProcessoSelecao.Application.Commands;
using Npf.ProcessoSelecao.Application.Models;
using System;
using Xunit;

namespace Npf.ProcessoSelecao.Tests
{
    public class MultipleElevenCommandsTest
    {
        [Fact]
        public void CalculateMultipleElevenTest()
        {
            MultipleElevenModel multipleElevenModel = new MultipleElevenModel() { Numbers = new string[] { "286", "30800", "112233" } };

            MultipleElevenCommands multipleElevenCommands = this.GetCommand();

            var result = multipleElevenCommands.CalculateMultipleEleven(multipleElevenModel);

            Assert.True(result.Count > 0);
        }

        private MultipleElevenCommands GetCommand()
        {
            return new MultipleElevenCommands(null);
        }
    }
}
