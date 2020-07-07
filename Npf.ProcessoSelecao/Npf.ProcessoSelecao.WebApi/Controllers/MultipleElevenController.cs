using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Npf.ProcessoSelecao.Application.Commands;
using Npf.ProcessoSelecao.Application.Models;
using Npf.ProcessoSelecao.Application.Queries;

namespace Npf.ProcessoSelecao.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MultipleElevenController : ControllerBase
    {
        private readonly IMultipleElevenCommands multipleElevenCommands;
        private readonly IMultipleElevenQueries multipleElevenQueries;

        public MultipleElevenController(IMultipleElevenCommands multipleElevenCommands, IMultipleElevenQueries multipleElevenQueries)
        {
            this.multipleElevenCommands = multipleElevenCommands;
            this.multipleElevenQueries = multipleElevenQueries;
        }

        // GET: api/MultipleEleven
        [HttpGet("{multipleEleven}")]
        public IActionResult Get(MultipleElevenModel multipleEleven)
        {
            try
            {
                var resultMultiple = multipleElevenCommands.CalculateMultipleEleven(multipleEleven);

                var resultJson = multipleElevenQueries.TransformToJson(resultMultiple);

                return Ok(resultJson);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }            
        }
    }
}
