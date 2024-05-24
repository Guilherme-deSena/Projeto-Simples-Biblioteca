using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoBiblioteca
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            dataGridViewBib.DataSource = Database.BibliotecaQuery();
            dataGridViewBib.Columns["BibliotecaId"].Visible = false;
            dataGridViewBib.Columns["Endereco"].HeaderText = "Endereço";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Database.InserirBiblioteca(textBoxNome.Text, textBoxEndereco.Text);

            dataGridViewBib.DataSource = Database.BibliotecaQuery();
            labelFeedback.Text = "Biblioteca inserida!";
        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
