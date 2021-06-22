using Seletivo.API.ViewModels;
using Seletivo.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Seletivo.API.ConverterEntidades
{
    /// <summary>
    /// Classe que tem como papel efetuar a conversão da entidade Número para NumeroViewModel 
    /// </summary>
    public class NumeroToNumeroViewModel
    {
        public static NumeroViewModel ConverterParaNumeroNumeroViewModel(Numero numero)
        {
            NumeroViewModel numeroViewModel = new NumeroViewModel();
            numeroViewModel.Id = numero.Id;
            numeroViewModel.Valor = numero.Valor;
            numeroViewModel.Resultado = numero.Resultado;
            numeroViewModel.Expressao = numero.Expressao;
            return numeroViewModel;
        }
    }
}
