using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;




namespace Jogo_digital_projeto_final
{
    class Atiradores
    {
        protected string nome;
        protected int mira, municao, vitoria, derrota;
        protected float dinheiro;
        
        public Atiradores(MySqlDataReader info)
        {
            
            nome     = info.GetString(1);
            mira     = int.Parse(info.GetString(2));
            municao  = int.Parse(info.GetString(3));
            dinheiro = float.Parse(info.GetString(4));
            vitoria  = int.Parse(info.GetString(5));
            derrota  = int.Parse(info.GetString(6));

        }

        public string GetNome()
        {
            return nome;
        }

        public virtual void Shoot()
        {

        }

        public virtual void Reload()
        {
            //rever
        }

    }
}
