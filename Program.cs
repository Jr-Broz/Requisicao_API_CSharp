using System;
using System.Net.Http;
using System.Threading.Tasks;
namespace Aula1Etapa2 {
     class Program {
    public static async Task Main(string[] args) {

            string baseUrl = @"https://brasilapi.com.br/api/ddd/v1/";

            Console.WriteLine("Digite o ddd pra ser consultado");

            string ddd = Console.ReadLine();

            using (HttpClient client = new HttpClient()) {

                //Depois de fora do escopo ele apaga

                try {


    HttpResponseMessage  response = await client.GetAsync(baseUrl + ddd);

                    string requestBody = response.Content.ReadAsStringAsync().Result ;

                    //pegar a resposta da api, ler a resposta dela como string
                    //client precisa saber qual endereço vai ser chamado

                    Console.WriteLine(requestBody);
                }
                catch(Exception ex) {

              Console.WriteLine("Error: " + ex.Message);
              
                }

            }
        }
    }
}
