using System;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using UStart.Domain.Commands;
using UStart.Domain.Contracts.Repositories;
using UStart.Domain.Workflows;

namespace UStart.API.Controllers

{
    /// <summary>
    /// Exemplo de controller
    /// </summary>
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/imovel")]
    [Authorize]
    public class ImovelController : ControllerBase
    {
        private readonly IImovelRepository _imovelRepository;
        private readonly ImovelWorkflow _imovelWorkflow;
        public ImovelController(
            IImovelRepository imovelRepository, 
            ImovelWorkflow imovelWorkflow)
        {
            _imovelRepository = imovelRepository;
            _imovelWorkflow = imovelWorkflow;
        }

        /// <summary>
        /// Consultar todos os grupos
        /// </summary>
        /// <returns></returns>
        [HttpGet]        
        public IActionResult Get()
        {
            return Ok(_imovelRepository.RetornarTodos());
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
            return Ok(_imovelRepository.ConsultarPorId(id));
        }

        /// <summary>
        /// Adicionar (insert) um grupo
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        [HttpPost]            
        public IActionResult Adicionar([FromBody] ImovelCommand command)
        {
            _imovelWorkflow.Add(command);
            if (_imovelWorkflow.IsValid())
            {
                return Ok();
            }
            return BadRequest(_imovelWorkflow.GetErrors());
        }

        /// <summary>
        /// Atualizar (update) um grupo
        /// </summary>
        /// <param name="id"></param>
        /// <param name="command"></param>
        /// <returns></returns>
        [HttpPut] 
        [Route("{id}")]           
        public IActionResult Atualizar([FromRoute] Guid id, [FromBody] ImovelCommand command)
        {
            _imovelWorkflow.Update(id, command);
            if (_imovelWorkflow.IsValid())
            {
                return Ok();
            }
            return BadRequest(_imovelWorkflow.GetErrors());
        }

        /// <summary>
        /// Excluir um grupo por Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]            
        public IActionResult Deletar([FromRoute] Guid id)
        {
            _imovelWorkflow.Delete(id);
            if (_imovelWorkflow.IsValid())
            {
                return Ok();
            }
            return BadRequest(_imovelWorkflow.GetErrors());
        }


    }
}
