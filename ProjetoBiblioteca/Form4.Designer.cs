namespace ProjetoBiblioteca
{
    partial class Form4
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
            textBoxEndereco = new TextBox();
            label2 = new Label();
            label1 = new Label();
            textBoxNome = new TextBox();
            buttonClose = new Button();
            dataGridViewBib = new DataGridView();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBib).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoScroll = true;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(dataGridViewBib, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 110F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(740, 368);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(labelFeedback);
            panel1.Controls.Add(buttonSend);
            panel1.Controls.Add(textBoxEndereco);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBoxNome);
            panel1.Controls.Add(buttonClose);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(734, 104);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // labelFeedback
            // 
            labelFeedback.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelFeedback.AutoSize = true;
            labelFeedback.Location = new Point(199, 73);
            labelFeedback.Name = "labelFeedback";
            labelFeedback.Size = new Size(0, 15);
            labelFeedback.TabIndex = 6;
            // 
            // buttonSend
            // 
            buttonSend.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonSend.Location = new Point(106, 69);
            buttonSend.Name = "buttonSend";
            buttonSend.Size = new Size(75, 23);
            buttonSend.TabIndex = 5;
            buttonSend.Text = "Enviar";
            buttonSend.UseVisualStyleBackColor = true;
            buttonSend.Click += button1_Click;
            // 
            // textBoxEndereco
            // 
            textBoxEndereco.Location = new Point(373, 24);
            textBoxEndereco.Name = "textBoxEndereco";
            textBoxEndereco.Size = new Size(352, 23);
            textBoxEndereco.TabIndex = 4;
            textBoxEndereco.TextChanged += textBox1_TextChanged_2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(373, 6);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 3;
            label2.Text = "Endereço";
            label2.Click += label1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 6);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 3;
            label1.Text = "Nome";
            label1.Click += label1_Click;
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(9, 24);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(352, 23);
            textBoxNome.TabIndex = 2;
            textBoxNome.TextChanged += textBox1_TextChanged_1;
            // 
            // buttonClose
            // 
            buttonClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonClose.Location = new Point(9, 69);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(75, 23);
            buttonClose.TabIndex = 1;
            buttonClose.Text = "Fechar";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // dataGridViewBib
            // 
            dataGridViewBib.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBib.Dock = DockStyle.Fill;
            dataGridViewBib.Location = new Point(3, 113);
            dataGridViewBib.Name = "dataGridViewBib";
            dataGridViewBib.Size = new Size(734, 252);
            dataGridViewBib.TabIndex = 3;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(740, 368);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form4";
            Text = "Form4";
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBib).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button buttonClose;
        private Panel panel1;
        private TextBox textBoxBibliotecaId;
        private Label label1;
        private TextBox textBoxNome;
        private TextBox textBoxEndereco;
        private Label label2;
        private Button buttonSend;
        private DataGridView dataGridViewBib;
        private Label labelFeedback;
    }
}