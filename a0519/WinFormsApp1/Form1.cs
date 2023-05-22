namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGerarEmail_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Botão gerar email foi clicado");

            string[] vetorSobrenome = textBoxSobrenome.Text.Split(' ');
            string[] vetorNome = textBoxNome.Text.Split(' ');

            textBoxEmail.Text = vetorSobrenome[vetorSobrenome.Length - 1].ToLower() + "_" + vetorNome[0].ToLower() + "@ufn.edu.br";

            textBoxListaEmails.AppendText(textBoxEmail.Text + Environment.NewLine);
            buttonLimpar.Enabled = true;

            textBoxNome.Text = string.Empty;
            textBoxSobrenome.Text = string.Empty;
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            textBoxNome.Text = string.Empty;
            textBoxSobrenome.Text = string.Empty;
            textBoxEmail.Text = string.Empty;
            textBoxListaEmails.Text = string.Empty;
            buttonLimpar.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBoxListaEmails_TextChanged(object sender, EventArgs e)
        {

        }
    }
}