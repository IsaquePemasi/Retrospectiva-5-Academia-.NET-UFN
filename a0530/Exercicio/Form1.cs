namespace Exercicio
{
    public partial class Form1 : Form
    {
        Simetrica s = new Simetrica();

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = textBox1.Text;
            string senha = textBox2.Text;
            string senhaE = s.EncryptData(senha, "Atos");
            label3.Text = senhaE;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string usuario = textBox1.Text;
            string senhaCriptografada = label3.Text;

            using (StreamWriter writer = new StreamWriter("C:\\Users\\Isaque\\Desktop\\Retrospectiva\\a0530\\Exercicio\\dados.txt", true))
            {
                writer.WriteLine(usuario + ";" + senhaCriptografada);
            }
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;

            MessageBox.Show("Cadastro realizado com sucesso!");
        }
    }
}