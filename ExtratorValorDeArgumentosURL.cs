using System;

namespace ManipulandoString
{
    public class ExtratorValorDeArgumentosURL
    {

        private readonly string _argumentos;
        public string URL { get; }

        public ExtratorValorDeArgumentosURL(string url)
        {

           if(String.IsNullOrEmpty(url))
           {
               throw new ArgumentException("O argumento não pode ser nulo ou vazio", nameof(url));
           }

           int indiceInterrogacao = url.IndexOf('?');
            _argumentos = url.Substring(indiceInterrogacao + 1);
            
            URL = url;
        }

        public string GetValor (string nomeParametro)
        {
            nomeParametro = nomeParametro.ToUpper(); // VALOR
            string argumentosEmCaixaAlta = _argumentos.ToUpper(); // MOEDAORIGEM=REAL&MOEDADESTINO=DOLAR

            string termo = nomeParametro + "="; // moedaDestino=
            int indiceTermo = _argumentos.IndexOf(termo); // x

            string resultado = _argumentos.Substring(indiceTermo + termo.Length); // dolar
            int indiceEComercial = resultado.IndexOf("&");

            if (indiceEComercial == -1)
            {
                return resultado;
            }
                return resultado.Remove(indiceEComercial);
        }   
    }
}