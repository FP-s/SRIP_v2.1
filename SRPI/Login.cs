using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SRPI
{
    public partial class Login : Form
    {
        public Login() {

            InitializeComponent();

        }

        private void IniciarSessao(object sender, EventArgs e) {


            //se clicar no botao de iniciar sessao
            //recebe o utilizador e a password em duas variáveis e passa para o controller para receber o input
            string utilizador = textBox1.Text;
            string password = textBox2.Text;

            Controller controller = new Controller();
            controller.IntroduzirLogin(utilizador, password);


        }

        private void Cancelar(object sender, EventArgs e) {

            //fecha a janela de login
            //mostra mensagem antes de encerrar
            MessageBox.Show("A sessão foi cancelada.",
                            "Aviso",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
            this.Close();
        }
    }
}
