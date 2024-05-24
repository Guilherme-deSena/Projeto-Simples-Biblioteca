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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();

            dataGridViewBook.DataSource = Database.LivroQuery();
            dataGridViewBook.Columns["LivroId"].Visible = false;
            dataGridViewBook.Columns["BibliotecaId"].Visible = false;
            dataGridViewBook.Columns["Titulo"].HeaderText = "Título";
            dataGridViewBook.Columns["BibliotecaNome"].HeaderText = "Biblioteca";

            dataGridViewBib.DataSource = Database.BibliotecaQuery();
            dataGridViewBib.Columns["BibliotecaId"].Visible = false;
            dataGridViewBib.Columns["Endereco"].HeaderText = "Endereço";
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            int idBiblioteca = Database.ObterBibliotecaId(textBoxBiblioteca.Text);
            int ano;
            Int32.TryParse(textBoxAno.Text, out ano);

            if (idBiblioteca >= 0)
            {
                Database.InserirLivro(textBoxTitulo.Text, textBoxAutor.Text, ano, idBiblioteca);
                dataGridViewBook.DataSource = Database.LivroQuery();
                labelFeedback.Text = "Livro inserido!";
            }
            else { labelFeedback.Text = "Não foi encontrado uma biblioteca com o nome inserido. Tente novamente."; }
        }

        private void dataGridViewBook_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewBook_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {

        }

        private void buttonClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
