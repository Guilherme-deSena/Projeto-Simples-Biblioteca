namespace ProjetoBiblioteca
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            panelSideMenu = new Panel();
            panelInserirMenu = new Panel();
            buttonInserirLivros = new Button();
            buttonInserirBiblioteca = new Button();
            buttonInserir = new Button();
            panelTabelasMenu = new Panel();
            buttonTabelaLivro = new Button();
            buttonTabelaBiblioteca = new Button();
            buttonTabelas = new Button();
            panelTopLogo = new Panel();
            pictureBox1 = new PictureBox();
            panelChildForm = new Panel();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            imageList1 = new ImageList(components);
            panelSideMenu.SuspendLayout();
            panelInserirMenu.SuspendLayout();
            panelTabelasMenu.SuspendLayout();
            panelTopLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CacheAge = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.EnableCaching = false;
            mySqlCommand1.Transaction = null;
            // 
            // panelSideMenu
            // 
            panelSideMenu.AutoScroll = true;
            panelSideMenu.BackColor = Color.LightSteelBlue;
            panelSideMenu.Controls.Add(panelInserirMenu);
            panelSideMenu.Controls.Add(buttonInserir);
            panelSideMenu.Controls.Add(panelTabelasMenu);
            panelSideMenu.Controls.Add(buttonTabelas);
            panelSideMenu.Controls.Add(panelTopLogo);
            panelSideMenu.Dock = DockStyle.Left;
            panelSideMenu.Location = new Point(0, 0);
            panelSideMenu.Name = "panelSideMenu";
            panelSideMenu.Size = new Size(250, 368);
            panelSideMenu.TabIndex = 0;
            panelSideMenu.Paint += panelSideMenu_Paint;
            // 
            // panelInserirMenu
            // 
            panelInserirMenu.BackColor = Color.LightBlue;
            panelInserirMenu.Controls.Add(buttonInserirLivros);
            panelInserirMenu.Controls.Add(buttonInserirBiblioteca);
            panelInserirMenu.Dock = DockStyle.Top;
            panelInserirMenu.Location = new Point(0, 242);
            panelInserirMenu.Name = "panelInserirMenu";
            panelInserirMenu.Size = new Size(250, 80);
            panelInserirMenu.TabIndex = 2;
            panelInserirMenu.Visible = false;
            // 
            // buttonInserirLivros
            // 
            buttonInserirLivros.Dock = DockStyle.Top;
            buttonInserirLivros.FlatAppearance.BorderSize = 0;
            buttonInserirLivros.FlatStyle = FlatStyle.Flat;
            buttonInserirLivros.Location = new Point(0, 40);
            buttonInserirLivros.Name = "buttonInserirLivros";
            buttonInserirLivros.Padding = new Padding(35, 0, 0, 0);
            buttonInserirLivros.Size = new Size(250, 40);
            buttonInserirLivros.TabIndex = 3;
            buttonInserirLivros.Text = "Livros";
            buttonInserirLivros.TextAlign = ContentAlignment.MiddleLeft;
            buttonInserirLivros.UseVisualStyleBackColor = true;
            buttonInserirLivros.Click += buttonInserirLivros_Click;
            // 
            // buttonInserirBiblioteca
            // 
            buttonInserirBiblioteca.Dock = DockStyle.Top;
            buttonInserirBiblioteca.FlatAppearance.BorderSize = 0;
            buttonInserirBiblioteca.FlatStyle = FlatStyle.Flat;
            buttonInserirBiblioteca.ForeColor = SystemColors.ControlText;
            buttonInserirBiblioteca.Location = new Point(0, 0);
            buttonInserirBiblioteca.Name = "buttonInserirBiblioteca";
            buttonInserirBiblioteca.Padding = new Padding(35, 0, 0, 0);
            buttonInserirBiblioteca.Size = new Size(250, 40);
            buttonInserirBiblioteca.TabIndex = 2;
            buttonInserirBiblioteca.Text = "Bibliotecas";
            buttonInserirBiblioteca.TextAlign = ContentAlignment.MiddleLeft;
            buttonInserirBiblioteca.UseVisualStyleBackColor = true;
            buttonInserirBiblioteca.Click += buttonInserirBiblioteca_Click;
            // 
            // buttonInserir
            // 
            buttonInserir.Dock = DockStyle.Top;
            buttonInserir.FlatAppearance.BorderSize = 0;
            buttonInserir.FlatStyle = FlatStyle.Flat;
            buttonInserir.Location = new Point(0, 197);
            buttonInserir.Name = "buttonInserir";
            buttonInserir.Padding = new Padding(10, 0, 0, 0);
            buttonInserir.Size = new Size(250, 45);
            buttonInserir.TabIndex = 3;
            buttonInserir.Text = "Inserir dados";
            buttonInserir.TextAlign = ContentAlignment.MiddleLeft;
            buttonInserir.UseVisualStyleBackColor = true;
            buttonInserir.Click += buttonInserir_Click;
            // 
            // panelTabelasMenu
            // 
            panelTabelasMenu.BackColor = Color.LightBlue;
            panelTabelasMenu.Controls.Add(buttonTabelaLivro);
            panelTabelasMenu.Controls.Add(buttonTabelaBiblioteca);
            panelTabelasMenu.Dock = DockStyle.Top;
            panelTabelasMenu.Location = new Point(0, 117);
            panelTabelasMenu.Name = "panelTabelasMenu";
            panelTabelasMenu.Size = new Size(250, 80);
            panelTabelasMenu.TabIndex = 1;
            panelTabelasMenu.Visible = false;
            // 
            // buttonTabelaLivro
            // 
            buttonTabelaLivro.Dock = DockStyle.Top;
            buttonTabelaLivro.FlatAppearance.BorderSize = 0;
            buttonTabelaLivro.FlatStyle = FlatStyle.Flat;
            buttonTabelaLivro.Location = new Point(0, 40);
            buttonTabelaLivro.Name = "buttonTabelaLivro";
            buttonTabelaLivro.Padding = new Padding(35, 0, 0, 0);
            buttonTabelaLivro.Size = new Size(250, 40);
            buttonTabelaLivro.TabIndex = 3;
            buttonTabelaLivro.Text = "Livros";
            buttonTabelaLivro.TextAlign = ContentAlignment.MiddleLeft;
            buttonTabelaLivro.UseVisualStyleBackColor = true;
            buttonTabelaLivro.Click += buttonTabelaLivro_Click;
            // 
            // buttonTabelaBiblioteca
            // 
            buttonTabelaBiblioteca.Dock = DockStyle.Top;
            buttonTabelaBiblioteca.FlatAppearance.BorderSize = 0;
            buttonTabelaBiblioteca.FlatStyle = FlatStyle.Flat;
            buttonTabelaBiblioteca.ForeColor = SystemColors.ControlText;
            buttonTabelaBiblioteca.Location = new Point(0, 0);
            buttonTabelaBiblioteca.Name = "buttonTabelaBiblioteca";
            buttonTabelaBiblioteca.Padding = new Padding(35, 0, 0, 0);
            buttonTabelaBiblioteca.Size = new Size(250, 40);
            buttonTabelaBiblioteca.TabIndex = 2;
            buttonTabelaBiblioteca.Text = "Bibliotecas";
            buttonTabelaBiblioteca.TextAlign = ContentAlignment.MiddleLeft;
            buttonTabelaBiblioteca.UseVisualStyleBackColor = true;
            buttonTabelaBiblioteca.Click += buttonTabelaBiblioteca_Click;
            // 
            // buttonTabelas
            // 
            buttonTabelas.Dock = DockStyle.Top;
            buttonTabelas.FlatAppearance.BorderSize = 0;
            buttonTabelas.FlatStyle = FlatStyle.Flat;
            buttonTabelas.Location = new Point(0, 72);
            buttonTabelas.Name = "buttonTabelas";
            buttonTabelas.Padding = new Padding(10, 0, 0, 0);
            buttonTabelas.Size = new Size(250, 45);
            buttonTabelas.TabIndex = 1;
            buttonTabelas.Text = "Tabelas";
            buttonTabelas.TextAlign = ContentAlignment.MiddleLeft;
            buttonTabelas.UseVisualStyleBackColor = true;
            buttonTabelas.Click += buttonTabelas_Click;
            // 
            // panelTopLogo
            // 
            panelTopLogo.Controls.Add(pictureBox1);
            panelTopLogo.Dock = DockStyle.Top;
            panelTopLogo.Location = new Point(0, 0);
            panelTopLogo.Name = "panelTopLogo";
            panelTopLogo.Size = new Size(250, 72);
            panelTopLogo.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(250, 72);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panelChildForm
            // 
            panelChildForm.BackColor = Color.FloralWhite;
            panelChildForm.Controls.Add(pictureBox3);
            panelChildForm.Controls.Add(pictureBox2);
            panelChildForm.Dock = DockStyle.Fill;
            panelChildForm.Location = new Point(250, 0);
            panelChildForm.Name = "panelChildForm";
            panelChildForm.Size = new Size(740, 368);
            panelChildForm.TabIndex = 1;
            panelChildForm.Paint += panelChildForm_Paint;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(126, 60);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(500, 250);
            pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(126, 72);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(500, 250);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(990, 368);
            Controls.Add(panelChildForm);
            Controls.Add(panelSideMenu);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panelSideMenu.ResumeLayout(false);
            panelInserirMenu.ResumeLayout(false);
            panelTabelasMenu.ResumeLayout(false);
            panelTopLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelChildForm.ResumeLayout(false);
            panelChildForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private Panel panelSideMenu;
        private Button buttonTabelas;
        private Panel panelTopLogo;
        private Panel panelTabelasMenu;
        private Button button4;
        private Button buttonTabelaLivro;
        private Button buttonTabelaBiblioteca;
        private Panel panelInserirMenu;
        private Button button1;
        private Button button5;
        private Button buttonInserirBiblioteca;
        private Button buttonInserirLivros;
        private Button buttonInserir;
        private Panel panelChildForm;
        private PictureBox pictureBox1;
        private ImageList imageList1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
    }
}
