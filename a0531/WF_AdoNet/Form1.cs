using System.Data;

namespace WF_AdoNet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            Banco bd = new Banco();

            string sql = "select * from pessoas";

            DataTable dt = new DataTable();

            dt = bd.executarConsultaGenerica(sql);

            dataGridView1.DataSource = dt;
        }

        private void btn_filtrar_Click(object sender, EventArgs e)
        {
            Banco bd = new Banco();



            string sql = "select * from pessoas where nome = '" + txbNome.Text + "'";



            DataTable dt = new DataTable();



            dt = bd.executarConsultaGenerica(sql);



            dataGridView1.DataSource = dt;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            Pessoa p = new Pessoa();
            p.nome = textBoxNome.Text;
            p.profissao = textBoxProfissao.Text;

            if (p.gravarPessoa())
            {
                MessageBox.Show("cadastrado com sucesso");
            }
            else
            {
                MessageBox.Show("erro ao cadastrar");
            }
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            Pessoa p = new Pessoa();
            p.id = int.Parse(textBoxid.Text);

            if (p.excluir())
            {
                MessageBox.Show("excluido com sucesso");
            }
            else
            {
                MessageBox.Show("erro ao excluir");
            }

        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            Pessoa p = new Pessoa();
            p.nome = textBoxNome.Text;
            p.profissao = textBoxProfissao.Text;
            p.id = int.Parse(textBoxid.Text);

            if (p.atualizar())
            {
                MessageBox.Show("atualizado com sucesso");
            }
            else
            {
                MessageBox.Show("erro ao atualizar");
            }
        }
    }
}