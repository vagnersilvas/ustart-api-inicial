using System;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using UStart.Domain.Commands;
using UStart.Domain.Contracts.Repositories;
using UStart.Domain.Workflows;

namespace UStart.API.Controllers
{

    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/cliente")]
    [Authorize]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteRepository _clienteRepository;
        private readonly ClienteWorkflow _clienteWorkflow;

        public ClienteController(IClienteRepository clienteRepository, ClienteWorkflow clienteWorkflow)
        {
            this._clienteRepository = clienteRepository;
            this._clienteWorkflow = clienteWorkflow;
        }

        /// <summary>
        /// Consultar todos os grupos
        /// </summary>
        /// <returns></returns>
        [HttpGet]
       
        public IActionResult Get([FromQuery]string pesquisa)
        {
            return Ok(_clienteRepository.Pesquisar(pesquisa));
        }
        /// <summary>
        /// Consultar apenas um grupo
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("{id}")]
        public IActionResult GetPorId([FromRoute] Guid id)
        {
            return Ok(_clienteRepository.ConsultarPorId(id));
        }


        /// <summary>
        /// Método para inserir no banco um regitro de grupo produto
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Adicionar([FromBody] ClienteCommand command)
        {
            _clienteWorkflow.Add(command);
            if (_clienteWorkflow.IsValid())
            {
                return Ok();
            }
            return BadRequest(_clienteWorkflow.GetErrors());
        }

        [HttpPut]
        [Route("{id}")]
        public IActionResult Atualizar([FromRoute] Guid id, [FromBody] ClienteCommand command)
        {
            _clienteWorkflow.Update(id, command);
            if (_clienteWorkflow.IsValid())
            {
                return Ok();
            }
            return BadRequest(_clienteWorkflow.GetErrors());
        }

        [HttpDelete("{id}")]
        public IActionResult Excluir([FromRoute] Guid id)
        {
            _clienteWorkflow.Delete(id);
            if (_clienteWorkflow.IsValid())
            {
                return Ok();
            }
            return BadRequest(_clienteWorkflow.GetErrors());
        }
    }
}
