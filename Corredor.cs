using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RacingGame
{
    public class Corredor
    {
        private String nome;

        public String Nome
        {
            get { return this.nome; }
            set {
                this.nome = value.ToLower(); 
                if (value.Length == 0) this.nome = "Visitante";
                if(value.Length > 1 ) this.nome = value[0].ToString().ToLower();
            }
        }


        public Corredor()
        {
            this.Nome = "";
        }

        public Corredor(String nome)
        {
            this.Nome = nome;
        }

        public int Correr()
        {
            Random rnd = new Random();
            return rnd.Next(1, 10);
        }

    }
}
