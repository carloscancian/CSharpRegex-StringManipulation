using System;
using System.Text.RegularExpressions;

namespace ManipulandoString
{
    class Program
    {
        static void Main(string[] args)
        {
            //Teste Regex 
            string padrao = "[0-9]{0,9}.?[0-9]{4}";
            string testeTexto = "89861285.8965";

            Match resultado = Regex.Match(testeTexto, padrao);

            Console.WriteLine(resultado.Value);
            Console.WriteLine("Quantidade de caracters: " + resultado.Length);
            Console.WriteLine("Grupo do resultado: " + resultado.Groups);
            Console.ReadLine();

            //Teste manipulação de string com classe
            string url = "www.bytebank.com/cambio?moedaOrigem=real&moedaDestino=dolar&valor=1500";

              var extrator = new ExtratorValorDeArgumentosURL(url);

              extrator.GetValor("moedaOrigem");
              extrator.GetValor("moedaDestino");
              extrator.GetValor("valor");

              Console.ReadLine();
  
        }
        static void TestaString()
        {
            string url = "pagina?argumentos";

            url.Substring(8);

            int indice = url.IndexOf("?");
            string url2 = url.Substring(indice + 1); 

            Console.WriteLine(url2);
            Console.WriteLine(indice);
           
            string textoVazio = "";
            string textoNulo = null;

            Console.WriteLine(String.IsNullOrEmpty(textoVazio));
            Console.WriteLine(String.IsNullOrEmpty(textoNulo));

           Console.ReadLine();
        }
    }
}
