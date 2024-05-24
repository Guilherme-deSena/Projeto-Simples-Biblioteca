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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            dataGridViewBib.DataSource = Database.BibliotecaQuery();
            dataGridViewBib.Columns["BibliotecaId"].Visible = false;
            dataGridViewBib.Columns["Endereco"].HeaderText = "Endereço";
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
