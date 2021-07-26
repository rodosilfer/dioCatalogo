﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiCatalogoJogos.InputModel;
using ApiCatalogoJogos.Services;
using ApiCatalogoJogos.ViewModel;

namespace ApiCatalogoJogos.Controllers.V1
{
    [Route("api/V1/[controller]")]
    [ApiController]

  
    public class JogosController : ControllerBase
    {
     

        private readonly IJogosService _jogosService; 
       
        public JogosController(IJogosService jogoService)
        {
            _jogosService = jogoService;
        }

        [HttpGet] 
       
        public async Task<ActionResult<List<JogoViewModel>>> Obter() 
        {
            var result = await _jogosService.Obter(1, 5); 
            return Ok(result);
        }

     

        [HttpGet("{idJogo:guid}")] 
        public async Task<ActionResult<JogoViewModel>> Obter(Guid idJogo)
        {
            return Ok();
        }

        [HttpPost] //inserir jogo
        public async Task<ActionResult<JogoViewModel>> InserirJogo(JogoInputModel jogo)
        {
            return Ok();
        }

        [HttpPut("{idJogo:guid}")] 
        public async Task<ActionResult> AtualizarJogo(Guid idJogo, JogoInputModel jogo)
        {
            return Ok();
        }

        [HttpPatch("{idJogo:guid}/preco/{preco:double}")] 
        public async Task<ActionResult> AtualizarJogo(Guid idJogo, double preco)
        {
            return Ok();
        }

        [HttpDelete("{idJogo:guid}")]
        public async Task<ActionResult> ApagarJogo(Guid idJogo)
        {
            return Ok();
        }
    }
}
