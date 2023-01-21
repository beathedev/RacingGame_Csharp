// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace RacingGame
{
    class Program
    {
         static void Main(string[] args)
        {

            Corredor c1 = new Corredor();
            c1.Nome = "Beatriz";

            Corredor c2 = new Corredor();
            c2.Nome = "CPU";

            Boolean ganhou = false;
            Pista pista1 = new Pista(100, c1);
            Pista pista2 = new Pista(100, c2);
            Boolean flag = false;

            while (ganhou == false)
            {
                Console.Clear();
                if (pista1.AtualizarCorrida() == true) ganhou = true;
                if (pista2.AtualizarCorrida() == true) ganhou = true;
                pista1.ExibirPista();
                pista2.ExibirPista();
                Console.ReadKey();
            }
         }
    }
}
