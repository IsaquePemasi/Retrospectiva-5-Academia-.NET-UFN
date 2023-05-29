using Microsoft.VisualBasic.ApplicationServices;
using Newtonsoft.Json;


namespace Praticando
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Aluno aluno = new Aluno();
            aluno.Nome = textBox1.Text;
            aluno.Turma = textBox2.Text;
            aluno.Nota = int.Parse(textBox3.Text);

            /*Serialização*/
            JsonSerializer serializer = new JsonSerializer();
            StreamWriter sw = new StreamWriter(@"C:\Users\Isaque\Desktop\Retrospectiva\a0529\Praticando\aluno.json");
            JsonWriter writer = new JsonTextWriter(sw);
            serializer.Serialize(writer, aluno);
            sw.Close();
            writer.Close();
            MessageBox.Show("Json criado");


        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Desserialização
            string json = File.ReadAllText(@"C:\Users\Isaque\Desktop\Retrospectiva\a0529\Praticando\aluno.json");
            Aluno a = JsonConvert.DeserializeObject<Aluno>(json);
            textBox1.Text = a.Nome;
            textBox2.Text = a.Turma;
            textBox3.Text =  a.Nota.ToString();

            MessageBox.Show("Json Desserializado");
        }
    }
}