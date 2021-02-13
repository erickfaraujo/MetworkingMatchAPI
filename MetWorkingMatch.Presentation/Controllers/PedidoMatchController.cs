﻿using Microsoft.AspNetCore.Mvc;
using MetWorkingMatch.Application.Pedido.Queries;
using System;
using System.Threading.Tasks;
using MetWorkingMatch.Infra.Persistence;

namespace MetWorkingMatch.Presentation.Controllers
{
    [Route("api/v1/[controller]")]
    public class PedidoMatchController : BaseController
    {

        [HttpGet("enviados/{id}")]
        public async Task<IActionResult> GetPedidosEnviados(Guid id)
        {
            var query = new GetPedidosEnviadosByIdQuery(id);
            var result = await Mediator.Send(query);

            return Ok(result);
        }


        [HttpGet("recebidos/{id}")]
        public async Task<IActionResult> GetPedidosRecebidos(Guid id)
        {
            var query = "";
            var result = id;

            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> CreatePedido()
        {
            var command = "";
            var result = "";

            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> UpdatePedido(string pedido, int action)
        {
            var command = "";
            var result = "";

            return Ok(result);
        }

        [HttpDelete]
        public async Task<IActionResult> DeletePedido()
        {
            var command = "";
            var result = "";

            return Ok(result);
        }
    }
}
