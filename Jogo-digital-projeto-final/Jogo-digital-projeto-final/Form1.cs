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
            Atiradores[] atiradores;

            BdManager bdManager = new BdManager();
            bdManager.Connect();
            MySqlDataReader dado = bdManager.GetInfo();
            dado.Read();
            
            dado.ReaderC;



        }
    }
}
