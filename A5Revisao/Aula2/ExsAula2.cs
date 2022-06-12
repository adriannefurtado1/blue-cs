using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2
{
    internal class ExsAula2
    {
        private const string Format = "#,###,###.00";
        static void Main()
        {
            CalcIdade();

            Soma10();

            CalcSal();

            CalcId2();

            Cambio();
        }

        static void CalcIdade()
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine($"EXERCICIO 1 - CALCULA IDADE");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Em que ano vc nasceu? ");
            int anonasc = int.Parse(Console.ReadLine());
            Console.WriteLine("************************************");
            Console.WriteLine($"Sua idade é: {2022 - anonasc}");
            Console.WriteLine("************************************");
            Console.WriteLine();
            Console.WriteLine("Pressione qqr tecla para continuar");
            Console.WriteLine();
            Console.ReadLine();
        }

        static void Soma10()
        {

            long numero = 0;

            Console.WriteLine("------------------------------------------");
            Console.WriteLine($"EXERCICIO 2 - SOMA 10 NUMEROS DIGITADOS");
            Console.WriteLine("------------------------------------------");

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Digite o {i + 1}o. numero? ");
                numero += long.Parse(Console.ReadLine());
            }
            Console.WriteLine("************************************************");
            Console.WriteLine($"A soma de todos os números digitados é: {numero}");
            Console.WriteLine("************************************************");
            Console.WriteLine();
            Console.WriteLine("Pressione qqr tecla para continuar");
            Console.WriteLine();
            Console.ReadLine();

            //Math.Round(10/2, 2);
        }

        static void CalcSal()
        {

            Console.WriteLine("------------------------------------------");
            Console.WriteLine($"EXERCICIO 3 - CALCULA SALARIO");
            Console.WriteLine("------------------------------------------");


            Console.WriteLine("Digite a quantidade de horas trabalhadas: ");
            int horastrab = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor da hora: ");
            float valorhora = float.Parse(Console.ReadLine());

            Console.WriteLine("************************************************");
            Console.WriteLine($"Salario do funcionario é: {horastrab * valorhora}");
            Console.WriteLine("************************************************");
            Console.WriteLine();
            Console.WriteLine("Pressione qqr tecla para continuar");
            Console.WriteLine();
            Console.ReadLine();
        }

        static void CalcId2()
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine($"EXERCICIO 4 - CALCULA IDADE EM ANOS MESES E DIAS");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Quantos anos vc tem? ");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("************************************");
            Console.WriteLine($"Vc viveu: {idade} anos");
            Console.WriteLine($"Vc viveu: {idade = idade * 12} meses");
            Console.WriteLine($"Vc viveu: {idade = idade * 365} dias");
            Console.WriteLine("************************************");
            Console.WriteLine();
            Console.WriteLine("Pressione qqr tecla para continuar");
            Console.WriteLine();
            Console.ReadLine();
        }

        private static void Cambio()
        {
            float valor = 0.00f;
            float resultado = 0.00f;

            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("------------------------------------------");
            Console.WriteLine($"EXERCICIO 5 - CONVERSAO MOEDAS");
            Console.WriteLine("------------------------------------------");

            Console.WriteLine("Qual o valor em reais (R$)? ");
            valor = float.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("***********************************");
            Console.WriteLine("*       VALORES CONVERTIDOS       *");
            Console.WriteLine("***********************************");
            Console.WriteLine($"REAL:        R$ {valor.ToString(Format)}");
            resultado = (float)(valor / 4.87);
            Console.WriteLine($"DOLAR:      US$ {resultado.ToString(Format)}");
            resultado = (float)(valor / 5.21);
            Console.WriteLine($"EURO:         € {resultado.ToString(Format)}");
            resultado = (float)(valor / 6.13);
            Console.WriteLine($"LIBRA:        £ {resultado.ToString(Format)}");
            resultado = (float)(valor / 0.040);
            Console.WriteLine($"PESO ARG:   ARS {resultado.ToString(Format)}");
            resultado = (float)(valor / 0.0059);
            Console.WriteLine($"PESO CHI:   CLP {resultado.ToString(Format)}");
            Console.WriteLine("***********************************");

            Console.WriteLine();
            Console.WriteLine("Pressione qqr tecla para continuar");
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}