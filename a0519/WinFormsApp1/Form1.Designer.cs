namespace WinFormsApp1
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
            buttonGerarEmail = new Button();
            label1 = new Label();
            textBoxSobrenome = new TextBox();
            textBoxNome = new TextBox();
            label2 = new Label();
            label3 = new Label();
            textBoxEmail = new TextBox();
            textBoxListaEmails = new TextBox();
            buttonLimpar = new Button();
            SuspendLayout();
            // 
            // buttonGerarEmail
            // 
            buttonGerarEmail.Location = new Point(62, 201);
            buttonGerarEmail.Name = "buttonGerarEmail";
            buttonGerarEmail.Size = new Size(385, 23);
            buttonGerarEmail.TabIndex = 0;
            buttonGerarEmail.Text = "Gerar Email";
            buttonGerarEmail.UseVisualStyleBackColor = true;
            buttonGerarEmail.Click += buttonGerarEmail_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 27);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 1;
            label1.Text = "Nome:";
            // 
            // textBoxSobrenome
            // 
            textBoxSobrenome.Location = new Point(62, 95);
            textBoxSobrenome.Name = "textBoxSobrenome";
            textBoxSobrenome.Size = new Size(385, 23);
            textBoxSobrenome.TabIndex = 2;
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(62, 45);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(385, 23);
            textBoxNome.TabIndex = 3;
            textBoxNome.TextChanged += textBoxNome_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 77);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 4;
            label2.Text = "Sobrenome: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(62, 130);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 5;
            label3.Text = "Email:";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(62, 148);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.ReadOnly = true;
            textBoxEmail.Size = new Size(385, 23);
            textBoxEmail.TabIndex = 6;
            textBoxEmail.TextChanged += textBoxEmail_TextChanged;
            // 
            // textBoxListaEmails
            // 
            textBoxListaEmails.Location = new Point(495, 39);
            textBoxListaEmails.Multiline = true;
            textBoxListaEmails.Name = "textBoxListaEmails";
            textBoxListaEmails.ReadOnly = true;
            textBoxListaEmails.ScrollBars = ScrollBars.Vertical;
            textBoxListaEmails.Size = new Size(293, 214);
            textBoxListaEmails.TabIndex = 7;
            textBoxListaEmails.TextChanged += textBoxListaEmails_TextChanged;
            // 
            // buttonLimpar
            // 
            buttonLimpar.Enabled = false;
            buttonLimpar.Location = new Point(62, 230);
            buttonLimpar.Name = "buttonLimpar";
            buttonLimpar.Size = new Size(385, 23);
            buttonLimpar.TabIndex = 8;
            buttonLimpar.Text = "Limpar";
            buttonLimpar.UseVisualStyleBackColor = true;
            buttonLimpar.Click += buttonLimpar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 273);
            Controls.Add(buttonLimpar);
            Controls.Add(textBoxListaEmails);
            Controls.Add(textBoxEmail);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBoxNome);
            Controls.Add(textBoxSobrenome);
            Controls.Add(label1);
            Controls.Add(buttonGerarEmail);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonGerarEmail;
        private Label label1;
        private TextBox textBoxSobrenome;
        private TextBox textBoxNome;
        private Label label2;
        private Label label3;
        private TextBox textBoxEmail;
        private TextBox textBoxListaEmails;
        private Button buttonLimpar;
    }
}