using Newtonsoft.Json;
using Npf.ProcessoSelecao.Application.Models;
using System.Collections.Generic;

namespace Npf.ProcessoSelecao.Application.Queries
{
    public class MultipleElevenQueries : IMultipleElevenQueries
    {
        public MultipleElevenQueries()
        {
        }

        public string TransformToJson(List<ResultModel> results) => JsonConvert.SerializeObject(results); 
    }
}
