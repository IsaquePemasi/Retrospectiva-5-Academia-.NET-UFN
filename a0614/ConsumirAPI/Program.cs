using Newtonsoft.Json;

namespace ConsumirAPI
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Consumindo a API desenvolvida");
            int op;
            string BaseUrl = "http://localhost:5010";
            do
            {
                Console.WriteLine("Informe  a opção desejada!");
                Console.WriteLine("1 - consultar pessoas");
                Console.WriteLine("2 - cadastrar pessoas");
                Console.WriteLine("3 - alterar pessoas");
                Console.WriteLine("4 - excluir pessoas");
                Console.WriteLine("0 - sair");
                op = int.Parse(Console.ReadLine());


                switch (op)
                {
                    case 0:
                        break;
                    case 1:
                        List<Pessoa> pessoas = new List<Pessoa>();//receber o que tenho armazaneado no sistema
                        HttpClient client = new HttpClient(); //instanciando um objeto para fazer o acesso via API
                        client.BaseAddress = new Uri(BaseUrl); // definindo  o endereço da API
                        client.DefaultRequestHeaders.Clear();
                        client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                        HttpResponseMessage resposta = await client.GetAsync("API/pessoas");

                        if (resposta.IsSuccessStatusCode) //obtive sucessoa na resposta, entro no if
                        {
                            var retorno = resposta.Content.ReadAsStringAsync().Result;//obtenho o retorno de uma consulta a API
                            pessoas = JsonConvert.DeserializeObject<List<Pessoa>>(retorno);//to pegando o retorno e desserializando e armazenando na lista
                        }
                        else
                        {
                            Console.Out.WriteLineAsync();
                        }

                        break;
                }
            }while (op != 0);   
        }
    }
}