﻿using CalculadoraDeJuros.Contratos.Dto;
using System.Threading.Tasks;

namespace Microservices.CalculadorasDeJuros.Services
{
    public interface ICalculadoraDeJurosServices
    {
        Task<TaxaDeJurosDto> GetAsync(decimal valorInicial, int meses);
    }
}