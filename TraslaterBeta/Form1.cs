using FactoryTranslator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TraslaterBeta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void GroupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void BtTraduz_Click(object sender, EventArgs e)
        {
            textoSaida.Text = Traducao(cbSaida.Text, cbEntrada.Text, textoEntrada.Text);


        }

        private void BtLimpar_Click(object sender, EventArgs e)
        {
            textoEntrada.Text = "";
            textoSaida.Text = "";
        }

        private void CbEntrada_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private string Traducao(string lingTo, string lingOri, string txt)
        {
            TranslatorFactory factory = new TranslatorFactory();
            ITranslatorFactory tradutor = factory.GenerateTranslator(lingTo);
            
            return tradutor.Translate(lingOri, txt);
        }
    }
}
