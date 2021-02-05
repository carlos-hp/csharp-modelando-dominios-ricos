﻿using NerdStore.Core.DomainObjects;

namespace NerdStore.Catalogo.Domain
{
    public class Dimensoes
    {
        public decimal Altura { get; private set; }
        public decimal Largura { get; private set; }
        public decimal Profundidade { get; private set; }

        public Dimensoes(decimal altura, decimal largura, decimal profundidade)
        {
            Altura = altura;
            Largura = largura;
            Profundidade = profundidade;

            Validar();
        }

        private void Validar()
        {
            Validacoes.ValidarSeMenorQue(Altura, 1, "O campo Altura deve ser no minimo maior ou igual a 1!");
            Validacoes.ValidarSeMenorQue(Largura, 1, "O campo Largura deve ser no minimo maior ou igual a 1!");
            Validacoes.ValidarSeMenorQue(Profundidade, 1, "O campo Profundidade deve ser no minimo maior ou igual a 1!");
        }

        public string DescricaoFormatada()
        {
            return $"LxAxP: {Largura} x {Altura} x {Profundidade}";
        }

        public override string ToString()
        {
            return DescricaoFormatada();
        }
    }
}