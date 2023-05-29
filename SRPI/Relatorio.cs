using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System.Diagnostics;
using System.Reflection.Metadata;
using PdfSharp;
using PdfSharp.Pdf.IO;
using System.IO;

namespace SRPI
{
    public partial class Relatorio : Form
    {
        public Relatorio()
        {
            InitializeComponent();


            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
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

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        // Botão Gerar PDF
        private void button1_Click(object sender, EventArgs e)
        {

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    //gerar documento pdf
                    PdfDocument doc = new PdfDocument();
                    doc.Info.Title = "Relarório";

                    PdfPage page = doc.AddPage();

                    XGraphics gfx = XGraphics.FromPdfPage(page);

                    // Formatação letra
                    XFont font = new XFont("Arial", 20);
                    gfx.DrawString(richTextBox1.Text, font, XBrushes.Black,
                        new XRect(0, 0, page.Width, page.Height), XStringFormats.Center);

                    //guardar arquivo pdf
                    doc.Save("relatorio.pdf");
                  
                    Process.Start("relatorio.pdf");

                }
            }

        }
       
    }
}
