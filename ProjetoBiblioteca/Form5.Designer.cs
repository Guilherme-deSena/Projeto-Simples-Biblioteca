namespace ProjetoBiblioteca
{
    partial class Form5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            labelFeedback = new Label();
            buttonSend = new Button();
            textBoxBiblioteca = new TextBox();
            label4 = new Label();
            textBoxAutor = new TextBox();
            label3 = new Label();
            label2 = new Label();
            textBoxAno = new TextBox();
            label1 = new Label();
            textBoxTitulo = new TextBox();
            buttonClose = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            dataGridViewBook = new DataGridView();
            dataGridViewBib = new DataGridView();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBook).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBib).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 160F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(740, 368);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(labelFeedback);
            panel1.Controls.Add(buttonSend);
            panel1.Controls.Add(textBoxBiblioteca);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBoxAutor);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBoxAno);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBoxTitulo);
            panel1.Controls.Add(buttonClose);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(734, 154);
            panel1.TabIndex = 2;
            // 
            // labelFeedback
            // 
            labelFeedback.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelFeedback.AutoSize = true;
            labelFeedback.Location = new Point(199, 123);
            labelFeedback.Name = "labelFeedback";
            labelFeedback.Size = new Size(0, 15);
            labelFeedback.TabIndex = 6;
            // 
            // buttonSend
            // 
            buttonSend.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonSend.Location = new Point(106, 119);
            buttonSend.Name = "buttonSend";
            buttonSend.Size = new Size(75, 23);
            buttonSend.TabIndex = 5;
            buttonSend.Text = "Enviar";
            buttonSend.UseVisualStyleBackColor = true;
            buttonSend.Click += buttonSend_Click;
            // 
            // textBoxBiblioteca
            // 
            textBoxBiblioteca.Location = new Point(373, 76);
            textBoxBiblioteca.Name = "textBoxBiblioteca";
            textBoxBiblioteca.Size = new Size(352, 23);
            textBoxBiblioteca.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(373, 58);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 3;
            label4.Text = "Biblioteca";
            // 
            // textBoxAutor
            // 
            textBoxAutor.Location = new Point(373, 24);
            textBoxAutor.Name = "textBoxAutor";
            textBoxAutor.Size = new Size(352, 23);
            textBoxAutor.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 58);
            label3.Name = "label3";
            label3.Size = new Size(29, 15);
            label3.TabIndex = 3;
            label3.Text = "Ano";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(373, 6);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 3;
            label2.Text = "Autor";
            // 
            // textBoxAno
            // 
            textBoxAno.Location = new Point(9, 76);
            textBoxAno.Name = "textBoxAno";
            textBoxAno.Size = new Size(352, 23);
            textBoxAno.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 6);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 3;
            label1.Text = "Título";
            // 
            // textBoxTitulo
            // 
            textBoxTitulo.Location = new Point(9, 24);
            textBoxTitulo.Name = "textBoxTitulo";
            textBoxTitulo.Size = new Size(352, 23);
            textBoxTitulo.TabIndex = 2;
            // 
            // buttonClose
            // 
            buttonClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonClose.Location = new Point(9, 119);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(75, 23);
            buttonClose.TabIndex = 1;
            buttonClose.Text = "Fechar";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click_1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(dataGridViewBook, 0, 0);
            tableLayoutPanel2.Controls.Add(dataGridViewBib, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 163);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(734, 202);
            tableLayoutPanel2.TabIndex = 6;
            tableLayoutPanel2.Paint += tableLayoutPanel2_Paint;
            // 
            // dataGridViewBook
            // 
            dataGridViewBook.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBook.Dock = DockStyle.Fill;
            dataGridViewBook.Location = new Point(3, 3);
            dataGridViewBook.Name = "dataGridViewBook";
            dataGridViewBook.Size = new Size(361, 202);
            dataGridViewBook.TabIndex = 5;
            // 
            // dataGridViewBib
            // 
            dataGridViewBib.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBib.Dock = DockStyle.Fill;
            dataGridViewBib.Location = new Point(370, 3);
            dataGridViewBib.Name = "dataGridViewBib";
            dataGridViewBib.Size = new Size(361, 202);
            dataGridViewBib.TabIndex = 6;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(740, 368);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form5";
            Text = "Form5";
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewBook).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBib).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Label labelFeedback;
        private Button buttonSend;
        private TextBox textBoxAutor;
        private Label label2;
        private Label label1;
        private TextBox textBoxTitulo;
        private Button buttonClose;
        private TextBox textBoxBiblioteca;
        private Label label4;
        private Label label3;
        private TextBox textBoxAno;
        private TableLayoutPanel tableLayoutPanel2;
        private DataGridView dataGridViewBook;
        private DataGridView dataGridViewBib;
    }
}