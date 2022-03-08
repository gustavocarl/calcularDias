using System;

namespace calcularDias
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dataInicial, dataFinal, quantidadeTotalDeDias = 0, dataInicialImpressa, aux;
            //O programa recebe 5 variáveis
            Console.WriteLine("Por favor, informe a data inicial: ");//É informado ao usuário que ele deve entrar com a data inicial
            dataInicial = Convert.ToInt32(Console.ReadLine());//dataInicial irá receber um número inteiro
            Console.WriteLine("Por favor, informe a data final: ");//É informado ao usuário que ele deve entrar com a data final
            dataFinal = Convert.ToInt32(Console.ReadLine());//dataFinal irá receber um número inteiro
            dataInicialImpressa = dataInicial;//dataInicialImpressa recebe dataInicial
            if(dataInicial > dataFinal)
            {
                aux = dataInicial;
                dataInicial = dataFinal;
                dataFinal = aux;
            }
            while(dataInicial <= dataFinal)//Laço de repetição para repetir até dataInicial for igual a dataFinal
            {
                if ((dataInicial % 4 == 0) || (dataInicial % 100 == 0) && (dataInicial % 400 == 0))//Se essa conta for verdadeira indicar que o ano é bissexto
                {
                    Console.WriteLine($"O ano {dataInicial} é bissexto: ");
                    quantidadeTotalDeDias += 366;//Se o ano for bissexto é adicionado 366 a quantidadeTotalDeDias
                }
                else
                {
                    quantidadeTotalDeDias += 365;//Senão adicionado 365 dias a quantidadeTotalDeDias
                }
                dataInicial++;//Incrementa + 1 na dataInicial 
            }
            Console.WriteLine($"O total de dias entre {dataInicialImpressa} e {dataFinal} é igual a: {quantidadeTotalDeDias} ");
            //É apresentado a dataInicial e a dataFinal e o total de dias entre ambas as datas
            Console.ReadKey();
        }
    }
}
