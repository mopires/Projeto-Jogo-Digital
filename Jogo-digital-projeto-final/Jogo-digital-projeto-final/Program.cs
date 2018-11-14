using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo_digital_projeto_final
{
    static class Program
    {


        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1()); //mudar para o form de inicio
            //dependendo da plataforma ou da UI, trocar a instancia
        }
    }
}
