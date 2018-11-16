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
            
            btnDimitri.Text = dado.GetString(1);
            dado.Read();
            btnMikhail.Text = dado.GetString(1);
            dado.Read();
            btnNikolai.Text = dado.GetString(1);
            dado.Read();
            btnSamiro.Text = dado.GetString(1);
            dado.Read();
            btnSerguei.Text = dado.GetString(1);
            dado.Read();
            btnBoris.Text = dado.GetString(1);
            dado.Read();


        }

        private void btnDimitri_Click(object sender, EventArgs e)
        {

        }
    }
}
