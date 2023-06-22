using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//adiconar bibliotecas
using System.IO; //entrada e saida de arquivos

namespace Editor_de_Texto
{
    public partial class Form1 : Form
    {
        //adicionar variavel
        StreamReader leitura = null;
        public Form1()
        {
            InitializeComponent();
        }
        //CRIANDO METODO NOVO()
        private void Novo()
        {   //apagando e posicionar o curso 
            richTextBox1.Clear();
            richTextBox1.Focus();
        }
        // botão Novo 1
        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {   //chamando metodo novo
            Novo();
        }
        // botão novo 2
        private void btn_Novo_Click(object sender, EventArgs e)
        {   //chamando metodo novo
            Novo();
        }

        //METODO SALVAR()
        private void Salvar()
        {
            try
            {
                if (this.saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    FileStream arquivo = new FileStream();

                }
            }
            catch (Exception ex)
            {

            }
    }
}
