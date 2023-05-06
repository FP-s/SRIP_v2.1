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
    public partial class Relatorio : Form
    {
        public Relatorio()
        {
            InitializeComponent();
        }

        private void Data(object sender, EventArgs e)
        {
            DateTime date = dateTimePicker1.Value;
            Controller controller = new Controller();
            controller.IntroduzirDados(date);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Relatorio_Load(object sender, EventArgs e)
        {

        }



        private void Nome1(object sender, EventArgs e)
        {

        }
    }
}
