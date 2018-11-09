using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo_digital_projeto_final
{
    class Atiradores
    {
        protected string nome;
        protected int dano, distancia, alcanco, municao, vida;

        public Atiradores(string DefineNome, int DefineDano, int DefineDistancia, int DefineMunicao, int DefineVida, int DefineAlcanco)
        {
            this.nome = DefineNome;
            this.dano = DefineDano;
            this.distancia = DefineDistancia;
            this.municao = DefineMunicao;
            this.vida = DefineVida;
            this.alcanco = DefineAlcanco;
        }



    }
}
