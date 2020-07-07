using Npf.ProcessoSelecao.Application.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Npf.ProcessoSelecao.Application.Commands
{
    public interface IMultipleElevenCommands
    {
        List<ResultModel> CalculateMultipleEleven(MultipleElevenModel multipleEleven);
    }
}
