using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Jogo_digital_projeto_final
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Atiradores Dimitri = new Atiradores("Dimitri", 20, 6, 100, 50, 4);
        Atiradores Nikolai = new Atiradores("Nikolai", 10, 6, 30, 100, 2);
        Atiradores Mikhail = new Atiradores("Mikhail", 40, 6, 1, 35, 5);
        Atiradores Bóris = new Atiradores("Bóris", 20, 6, 100, 50, 4);
        Atiradores Serguei = new Atiradores("Serguei", 10, 6, 30, 100, 2);
        Atiradores Samiro = new Atiradores("Samiro", 40, 6, 1, 35, 5);

        Atiradores player, computador;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            player = Dimitri;
            
        }
    }
}
