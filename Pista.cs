using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RacingGame
{
    internal class Pista
    {
        public int Tamanho { get; set; }
		private int posAtleta;
        private String pista = "";
        private String corredorPista = "";

        public Pista(int tamanho, Corredor atleta)
        {
            this.Tamanho = tamanho;
            this.Atleta = atleta;
            this.posAtleta = 0;
            this.corredorPista = "";
        }

        public int PosAtleta
        {
			get { return this.posAtleta; }
			//set { this.posAtleta = value; }
		}

        public Corredor Atleta { get; set; }

        public Boolean AtualizarCorrida()
        {
            Boolean ganhou = false;
            if(this.posAtleta < this.Tamanho)
            {
                posAtleta += this.Atleta.Correr();
                
            }

            if(this.posAtleta >= this.Tamanho)
            {
                ganhou = true;
                this.posAtleta = this.Tamanho;
                
            }

            ExibirVencedor();
            return ganhou;
        }

        public void ExibirVencedor()
        {
            while (this.posAtleta == this.Tamanho)
            {
                Console.Clear();
                Console.WriteLine($"O jogador {this.Atleta.Nome} ganhou a corrida.");
                break;
            }
        }

        public void ExibirPista()
        {
            //Monta a imagem do corredor na pista
            String pista = "";
            String corredorPista = "";
            for (int i = 0; i < this.Tamanho; i++)
            {
                pista += "_";
                if (i == this.posAtleta)
                {
                    corredorPista += Atleta.Nome;
                }
                else
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
