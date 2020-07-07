using Npf.ProcessoSelecao.Application.Models;
using System.Collections.Generic;

namespace Npf.ProcessoSelecao.Application.Queries
{
    public interface IMultipleElevenQueries
    {
        string TransformToJson(List<ResultModel> results);
    }
}
