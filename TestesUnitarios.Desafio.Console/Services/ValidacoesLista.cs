using System;
using System.Collections.Generic;
using System.Linq;

namespace TestesUnitarios.Desafio.Console.Services
{
    public class ValidacoesLista
    {
        public List<int> RemoverNumerosNegativos(List<int> lista)
        {
            return lista.Where(x => x >= 0).ToList();
        }

        public bool ListaContemDeterminadoNumero(List<int> lista, int numero)
        {
            return lista.Contains(numero);
        }

        public List<int> MultiplicarElementosPor2(List<int> lista)
        {
            return lista.Select(x => x * 2).ToList();
        }

        public int RetornarMaiorNumeroLista(List<int> lista)
        {
            return lista.Max();
        }

        public int RetornarMenorNumeroLista(List<int> lista)
        {
            return lista.Min();
        }
    }
}
