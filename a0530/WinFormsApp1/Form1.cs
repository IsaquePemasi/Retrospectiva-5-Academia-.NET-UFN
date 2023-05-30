using Microsoft.VisualBasic.ApplicationServices;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        Assimetrica a = new Assimetrica();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCripto_Click(object sender, EventArgs e)
        {
            Simetrica s = new Simetrica();
            string msg = textBox1.Text;
            string msgCripto = s.EncryptData(msg, "Atos");
            label3.Text = msgCripto;


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Simetrica s = new Simetrica();
            string msg = label3.Text;
            string msgCripto = s.DecryptData(msg, "Atos");
            label3.Text = msgCripto;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using var file = new StreamReader("C:\\Users\\Isaque\\Desktop\\Retrospectiva\\a0530\\WinFormsApp1\\dadoscripto.txt");
            string? line;

            Simetrica s = new Simetrica();

            while ((line = file.ReadLine()) != null)
                label3.Text = s.DecryptData(line, "Atos20232");
            file.Close();


        }

        private void button3_Click(object sender, EventArgs e)
        {

            //MessageBox.Show(a.getPublicKey());
            string msg, msgCripto;
            msg = textBox1.Text;
            msgCripto = a.encrypt(msg);
            label4.Text = msgCripto;

        }

        private void button4_Click(object sender, EventArgs e)
        {

            //MessageBox.Show(a.getPublicKey());
            string msg = label4.Text;
            string msgCripto = a.decrypt(msg);
            label4.Text = msgCripto;
        }
    }
}