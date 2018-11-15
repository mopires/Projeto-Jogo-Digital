using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;

namespace Jogo_digital_projeto_final
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

            BdManager bdManager = new BdManager();
            bdManager.Connect();
            MySqlDataReader dado = bdManager.GetInfo();
            dado.Read();
            
            Atiradores[] atiradores = new Atiradores[6]; //pegar numero de personagens/linhas
                                                         //no banco para indice

            List<Button> buttons = new List<Button>();
            for (int i = 0; i < 6; i++)
            {
                Button newButton = new Button();

                buttons.Add(newButton);
                Controls.Add(newButton);

                newButton.Name   = dado.GetString(1);
                newButton.Text   = dado.GetString(1);
                newButton.Location = new Point(newButton.Width + (i * 100),
                                               0);

                atiradores[i] = new Atiradores(dado);
                dado.Read();
            }

        }

    }
}
