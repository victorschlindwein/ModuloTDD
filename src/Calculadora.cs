using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace src
{
    public class Calculadora
    {
        private List<string> listaHistorico;
        public Calculadora()
        {
            listaHistorico = new List<string>();
        }

        public int Somar(int num1, int num2)
        {
            var result = num1 + num2;
            listaHistorico.Insert(0, result.ToString());
            return result;
        }

        public int Subtrair(int num1, int num2)
        {
            var result = num1 - num2;
            listaHistorico.Insert(0, result.ToString());
            return result;
        }

        public int Multiplicar(int num1, int num2)
        {
            var result = num1 * num2;
            listaHistorico.Insert(0, result.ToString());
            return result;
        }

        public int Dividir(int num1, int num2)
        {
            var result = num1 / num2;
            listaHistorico.Insert(0, result.ToString());
            return result;
        }

        public List<string> ListarHistorico(int qtdOperacoes)
        {
            listaHistorico.RemoveRange(qtdOperacoes, listaHistorico.Count - qtdOperacoes);
            return listaHistorico;
        }
    }
}