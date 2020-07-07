using Microsoft.Extensions.Logging;
using Npf.ProcessoSelecao.Application.Models;
using System;
using System.Collections.Generic;

namespace Npf.ProcessoSelecao.Application.Commands
{
    public class MultipleElevenCommands : IMultipleElevenCommands
    {
        private readonly ILogger<MultipleElevenCommands> logger;

        public MultipleElevenCommands(ILogger<MultipleElevenCommands> logger)
        {
            this.logger = logger;
        }

        public List<ResultModel> CalculateMultipleEleven(MultipleElevenModel multipleEleven)
        {
            logger.LogInformation(
                        "MultipleElevenQueries.CalculateMultipleEleven called. Message: {Numbers}",
                        multipleEleven.Numbers);

            List<ResultModel> results = new List<ResultModel>();

            try
            {
                Array.ForEach(multipleEleven.Numbers, (number) =>
                {
                    results.Add(new ResultModel()
                    {
                        IsMultiple = Recursividade(number),
                        Number = number
                    });
                });
            }
            catch (Exception ex)
            {
                logger.LogError(
                            "MultipleElevenQueries.CalculateMultipleEleven throw exception. Message: {Message}",
                            ex.Message);

                throw ex;
            }

            return results;
        }

        private bool Recursividade(string numero)
        {
            if ((numero.Length < 2) || (numero.Length > int.MaxValue)) return false;

            if (numero.Equals("11")) return true;

            if (numero.Length == 2) return (numero[0] == numero[1]);

            return Recursividade((Convert.ToInt32(numero.Substring(0, numero.Length - 1)) - Convert.ToInt16(numero.Substring(numero.Length - 1))).ToString());
        }
    }
}
