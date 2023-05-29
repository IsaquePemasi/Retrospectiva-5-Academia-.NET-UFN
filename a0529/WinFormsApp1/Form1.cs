using Microsoft.VisualBasic.ApplicationServices;
using Newtonsoft.Json;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Soap;


namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string serializar = textBox1.Text;
            FileStream fs = new FileStream(@"C:\Users\Isaque\Desktop\Retrospectiva\Isaque.data", FileMode.OpenOrCreate);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, serializar);
            fs.Close();
            MessageBox.Show("Serializado com sucesso");


        }

        private void button2_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"C:\Users\Isaque\Desktop\Retrospectiva\Isaque.data", FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            string msgDesserializada;
            msgDesserializada = (string)bf.Deserialize(fs);
            MessageBox.Show("Mensagem desserializada");
            label1.Text = msgDesserializada;
        }


        private void button3_Click(object sender, EventArgs e)
        {
            XmlSerializer xml = new XmlSerializer(typeof(Pessoa));
            StreamReader reader = new StreamReader(@"C:\Users\Isaque\Desktop\Retrospectiva\pessoa.xml");
            Pessoa pDes;
            pDes = (Pessoa)xml.Deserialize(reader);
            textBox2.Text = pDes.nome;
            textBox3.Text = pDes.idade.ToString();
            textBox4.Text = pDes.salario.ToString();
            reader.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //serializa json
            Pessoa p = new Pessoa();
            p.nome = textBox2.Text;
            p.idade = int.Parse(textBox3.Text);
            p.salario = double.Parse(textBox4.Text);

            JsonSerializer serializer = new JsonSerializer();
            StreamWriter sw = new StreamWriter(@"C:\Users\Isaque\Desktop\Retrospectiva\pessoa.json");
            JsonWriter writer = new JsonTextWriter(sw);
            serializer.Serialize(writer, p);
            sw.Close();
            writer.Close();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //deserializa json
            string json = File.ReadAllText(@"C:\Users\Isaque\Desktop\Retrospectiva\pessoa.json");
            Pessoa pDes = JsonConvert.DeserializeObject<Pessoa>(json);
            textBox2.Text = pDes.nome;
            textBox3.Text = pDes.idade.ToString();
            textBox4.Text = pDes.salario.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //serializa SOAP
            Pessoa p = new Pessoa();
            p.nome = textBox2.Text;
            p.idade = int.Parse(textBox3.Text);
            p.salario = double.Parse(textBox4.Text);

            FileStream stream = new FileStream(@"C:\Users\Isaque\Desktop\Retrospectiva\pessoa.data", FileMode.Create);
            SoapFormatter soap =new SoapFormatter();
            soap.Serialize(stream, p);
            stream.Close();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            FileStream stream = new FileStream(@"C:\Users\Isaque\Desktop\Retrospectiva\pessoa.data", FileMode.Open);
            SoapFormatter soap = new SoapFormatter();
            Pessoa pDes = new Pessoa();
            pDes = (Pessoa)soap.Deserialize(stream);
            textBox2.Text = pDes.nome;
            textBox3.Text = pDes.idade.ToString();
            textBox4.Text = pDes.salario.ToString();
        }
    }
}