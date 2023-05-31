namespace WF_AdoNet
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
            btn_consultar = new Button();
            txbNome = new TextBox();
            dataGridView1 = new DataGridView();
            btn_filtrar = new Button();
            textBoxNome = new TextBox();
            textBoxProfissao = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btn_cadastrar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btn_consultar
            // 
            btn_consultar.Location = new Point(30, 75);
            btn_consultar.Name = "btn_consultar";
            btn_consultar.Size = new Size(75, 23);
            btn_consultar.TabIndex = 0;
            btn_consultar.Text = "Consultar";
            btn_consultar.UseVisualStyleBackColor = true;
            btn_consultar.Click += btn_consultar_Click;
            // 
            // txbNome
            // 
            txbNome.Location = new Point(30, 22);
            txbNome.Name = "txbNome";
            txbNome.Size = new Size(198, 23);
            txbNome.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(258, 22);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(240, 150);
            dataGridView1.TabIndex = 2;
            // 
            // btn_filtrar
            // 
            btn_filtrar.Location = new Point(153, 75);
            btn_filtrar.Name = "btn_filtrar";
            btn_filtrar.Size = new Size(75, 23);
            btn_filtrar.TabIndex = 3;
            btn_filtrar.Text = "Filtrar";
            btn_filtrar.UseVisualStyleBackColor = true;
            btn_filtrar.Click += btn_filtrar_Click;
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(79, 168);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(115, 23);
            textBoxNome.TabIndex = 4;
            // 
            // textBoxProfissao
            // 
            textBoxProfissao.Location = new Point(94, 219);
            textBoxProfissao.Name = "textBoxProfissao";
            textBoxProfissao.Size = new Size(100, 23);
            textBoxProfissao.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 171);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 6;
            label1.Text = "Nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 222);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 7;
            label2.Text = "profissao:";
            // 
            // btn_cadastrar
            // 
            btn_cadastrar.Location = new Point(94, 264);
            btn_cadastrar.Name = "btn_cadastrar";
            btn_cadastrar.Size = new Size(75, 23);
            btn_cadastrar.TabIndex = 8;
            btn_cadastrar.Text = "cadastrar";
            btn_cadastrar.UseVisualStyleBackColor = true;
            btn_cadastrar.Click += btn_cadastrar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_cadastrar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxProfissao);
            Controls.Add(textBoxNome);
            Controls.Add(btn_filtrar);
            Controls.Add(dataGridView1);
            Controls.Add(txbNome);
            Controls.Add(btn_consultar);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_consultar;
        private TextBox txbNome;
        private DataGridView dataGridView1;
        private Button btn_filtrar;
        private TextBox textBoxNome;
        private TextBox textBoxProfissao;
        private Label label1;
        private Label label2;
        private Button btn_cadastrar;
    }
}