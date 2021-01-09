using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Regex;

namespace Teste
{
    class Program
    {
        private static string str { get; set; }
        static void Main(string[] args)
        {

            StringBuilder strText = new StringBuilder();

            strText.Append(@"   João Fulano,123.456.78900,21 de Maio de 1993,(21) 3079-9987,Rua do Ouvidor,50,20040-030,Rio de Janeiro
                                Maria Fulana, 987.654.32100,11 de Abril de 1995,(11) 933339871,Rua Vergueiro,3185,04101-300,São Paulo
                                denise teste, 987.654.321.00,28 de Dezembro de 1991,(31)45562712,SCS Qd. 8 Bl. B-50,11,70333-900,Rio Grande");

            str = strText.ToString();

            var cpf = str.Regex(PatternRegex.CPF);
            
        }
    }
}
