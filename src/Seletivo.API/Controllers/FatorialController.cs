
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Seletivo.API.ConverterEntidades;
using Seletivo.API.ViewModels;
using Seletivo.Core.Interfaces.Services;
using Seletivo.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Seletivo.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class FatorialController : ControllerBase
    {
        private readonly INumeroService _numeroService;

        public FatorialController(INumeroService numeroService)
        {
            _numeroService = numeroService;
        }

        [HttpGet]
        [Route("")]
        public ActionResult<NumeroViewModel> Get()
        {
            return Ok();
        }

        [HttpGet]
        [Route("{numero:int}")]
        public ActionResult<NumeroViewModel> Get(int numero)
        {
            NumeroViewModel viewModel = new NumeroViewModel();
            viewModel.Valor = numero;

            return NumeroToNumeroViewModel.ConverterParaNumeroNumeroViewModel(
                _numeroService.CalcularFatorial(
                    NumeroViewModelToNumero.ConverterParaNumero(viewModel)
                    )
                );
        }

        [HttpPost]
        [Route("")]
        public  ActionResult<NumeroViewModel> Post(NumeroViewModel numero)
        {
            
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            return NumeroToNumeroViewModel.ConverterParaNumeroNumeroViewModel(
                _numeroService.CalcularFatorial(
                    NumeroViewModelToNumero.ConverterParaNumero(numero)
                    )
                );
        }
    }
}
