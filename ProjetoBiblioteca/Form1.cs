using System.Diagnostics;

namespace ProjetoBiblioteca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CustomizeDesign()
        {
            panelTabelasMenu.Visible = false;
            panelInserirMenu.Visible = false;
        }

        private void ShowSubMenu(Panel subMenu) //Mostra ou esconde o submenu
        {
            if (!subMenu.Visible) { subMenu.Visible = true; }
            else { subMenu.Visible = false; }
        }

        private Form activeForm = null;
        private void OpenChildForm(Form childForm) //Abre o formulário do parâmetro no painel principal
        {
            if (activeForm != null) { activeForm.Close(); }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panelSideMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        #region TabelasSubMenu
        private void buttonTabelas_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelTabelasMenu);
        }

        private void buttonTabelaBiblioteca_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form2());
        }

        private void buttonTabelaLivro_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form3());
        }
        #endregion

        #region InserirSubMenu
        private void buttonInserir_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelInserirMenu);
        }

        private void buttonInserirBiblioteca_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form4());
        }

        private void buttonInserirLivros_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form5());
        }
        #endregion

        private void panelChildForm_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}