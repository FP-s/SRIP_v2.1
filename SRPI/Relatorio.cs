﻿using System;
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
using System.Xml.Linq;

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


        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
        // Botão Gerar PDF
        private void button1_Click(object sender, EventArgs e)
        {

            var document = new PdfSharp.Pdf.PdfDocument();
            var page = document.AddPage();
            var graphics = PdfSharp.Drawing.XGraphics.FromPdfPage(page);
            var textFormatter = new PdfSharp.Drawing.Layout.XTextFormatter(graphics);
            var font = new PdfSharp.Drawing.XFont("Calibri", 14);
           
            //gerar documento pdf
            textFormatter.Alignment = PdfSharp.Drawing.Layout.XParagraphAlignment.Center;
            textFormatter.DrawString("Relatório Diário:", font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(30, 60, page.Width - 60, page.Height - 60));

            textFormatter.Alignment = PdfSharp.Drawing.Layout.XParagraphAlignment.Left;
            textFormatter.DrawString("Data:", font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(30, 70, page.Width - 60, page.Height - 60));
            textFormatter.DrawString(dateTimePicker1.Text, font, XBrushes.Black,
            new XRect(60, 70, page.Width - 60, page.Height - 60));

            textFormatter.Alignment = PdfSharp.Drawing.Layout.XParagraphAlignment.Left;
            textFormatter.DrawString("Turno:", font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(30, 80, page.Width - 60, page.Height - 60));
           // textFormatter.DrawString(listBox1_SelectedIndexChanged_1.text, font, XBrushes.Black,
           // new XRect(60, 70, page.Width - 60, page.Height - 60));


            //guardar arquivo pdf
            string data = DateTime.Now.ToString("ddHHmmMMMyy");
            string nome = "RelatorioDiario_" + data + ".pdf";
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            document.Save(path + "\\" + nome);
            //document.Save("C:\\pdf\\output.pdf");
            MessageBox.Show("Arquivo gerado com sucesso.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

    }
}
