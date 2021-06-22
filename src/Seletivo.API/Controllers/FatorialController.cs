using Microsoft.AspNetCore.Mvc;
using Seletivo.API.ConverterEntidades;
using Seletivo.API.ViewModels;
using Seletivo.Core.Interfaces.Services;

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
        [Route("{numero:int}")]
        public ActionResult<NumeroViewModel> Get(int numero)
        {
            NumeroViewModel viewModel = new NumeroViewModel();
            viewModel.Valor = numero;

            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            if (numero < 1)
            {
                return BadRequest("O mínimo valor aceito é 1");
            }

            return EfetuarConversao(viewModel);
        }

        [HttpPost]
        [Route("")]
        public  ActionResult<NumeroViewModel> Post(NumeroViewModel numero)
        {
            
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            return EfetuarConversao(numero);
        }

        /// <summary>
        /// Método utilizado para efetuar a conversão da Entidade Número para Número View  Model.
        /// </summary>
        private NumeroViewModel EfetuarConversao (NumeroViewModel numeroViewModel)
        {
            return NumeroToNumeroViewModel.ConverterParaNumeroNumeroViewModel(
                _numeroService.CalcularFatorial(
                    NumeroViewModelToNumero.ConverterParaNumero(numeroViewModel)
                    )
                );
        }
    }
}
