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
            int tlPista = 100;
            int posicaoC1 = 0;
            String pista = "";
            String corredorPista = "";


            Corredor c1 = new Corredor();
            c1.Nome = "D";
            posicaoC1 = c1.Correr();


            //Monta a imagem do corredor na pista
            for (int i = 0; i < tlPista; i++)
            {
                pista += "_";
                if(i == posicaoC1)
                {
                    corredorPista += c1.Nome;
                }else
                {
                    corredorPista += " ";
                }
            }

            //exibir a pista e o corredor
            Console.WriteLine(corredorPista);
            Console.WriteLine(pista);

        }
    }
}
