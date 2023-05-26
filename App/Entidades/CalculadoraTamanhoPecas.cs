using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wCut.App
{
    public class CalculadoraTamanhoPecas
    {
       
        public static String CalcularTamanhoPortas(int quantidade, double altura, double largura, int espessura)
        {
            int puxador = 35;
            double alturaPorta = altura - 10 - puxador;
            double larguraPorta = largura / 2 - 10;
            string resultado = quantidade + "x" + alturaPorta + "*" + larguraPorta + espessura;
            return resultado;
        }

        public static String CalcularTamanhoLateral(int quantidade, double altura, double profundidade, int espessura)
        {
            string resultado = quantidade + "x" + altura + "*" + profundidade + "*" + espessura;
            return resultado;
            
        }
    }
}
