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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            dataGridViewBook.DataSource = Database.LivroQuery();
            dataGridViewBook.Columns["LivroId"].Visible = false;
            dataGridViewBook.Columns["BibliotecaId"].Visible = false;
            dataGridViewBook.Columns["Titulo"].HeaderText = "Título";
            dataGridViewBook.Columns["BibliotecaNome"].HeaderText = "Biblioteca";
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
