using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Jogo_digital_projeto_final
{
    class BdManager
    {
        MySqlConnection conexao;
        MySqlCommand comando;

        /*
        public BdManager(string bd)
        {
            criar contrutor para conectar com a interface que liga o banco
        }
        */

        public void Connect()
        {
            conexao = new MySqlConnection("server=localhost;user id=root;database=jogo_atiradores; allow Zero Datetime=True");
            conexao.Open();

        }

        public MySqlDataReader GetInfo()
        {
            
            comando = new MySqlCommand("SELECT * FROM atiradores", conexao);
            MySqlDataReader dados_da_tabela = comando.ExecuteReader();
            

            return dados_da_tabela;
        }

        public void Close()
        {
            conexao.Close();
        }

        public MySqlDataReader GetAtiradores(string nome = null)
        {
            if (nome != null)
            {
                comando = new MySqlCommand("SELECT nome FROM atiradores WHERE nome='" + nome + "'", conexao);
                MySqlDataReader dados = comando.ExecuteReader();
                return dados;

            }
            else
            {
                comando = new MySqlCommand("SELECT * FROM atiradores", conexao);
                MySqlDataReader dados = comando.ExecuteReader();
                return dados;
            }


        }


        public void UpdateInfo()
        {



        }


    }
}
