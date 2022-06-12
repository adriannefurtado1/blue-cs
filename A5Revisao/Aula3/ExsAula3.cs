using System;

namespace Aula3
{
    internal class ExsAula3
    {
        static void Main()
        {
            A3E1_Notas();
            A3E2_Maiorde3();
            A3E3_MediaAl();
            A3E4_ExibeMed();
            A3E5_Reaj();
        }

        static void A3E1_Notas()
        {
            float valor = 0.00f;
            double[] notas = { 100, 50, 20, 10, 5, 2 };
            int[] qtdnt = { 0, 0, 0, 0, 0, 0 };
            float saldo = 0.00f;

            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine($"EXERCICIO 1 - LISTAR NOTAS R$ PARA VALOR DIGITADO");
            Console.WriteLine("--------------------------------------------------");

            Console.Write("Digite o valor monetário: ");
            valor = float.Parse(Console.ReadLine());
            saldo = valor;

            for (int i = 0; i < notas.Length; i++)
            {
                /*if (saldo >= notas[i])
                {
                    qtdnt[i] = (int)(saldo/notas[i]);
                    saldo    -= (float)(qtdnt[i] * notas[i]);
                }*/

                /*****************************************************************/
                /* OPERADOR TERNARIO                                             */
                /*****************************************************************/
                /* variavel = (condicao) ? resultadoVerdadeiro : resultadoFalso; */
                /*                                                               */
                /* converti o if anterior em operador ternario                   */
                /*****************************************************************/

                qtdnt[i] = (saldo >= notas[i]) ? (int)(saldo / notas[i]) : 0;
                saldo -= (float)(qtdnt[i] * notas[i]);

            }

            Console.WriteLine();
            Console.WriteLine("Lista de notas: ");

            for (int i = 0; i < notas.Length; i++)
            {
                Console.WriteLine($"{qtdnt[i]} notas {notas[i]}");
            }
            Console.ReadLine();

        }

        static void A3E2_Maiorde3()
        {
            int[] valor = { 0, 0, 0 };
            int maiorvlr;

            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine($"EXERCICIO 2 - MAIOR DE 3");
            Console.WriteLine("--------------------------------------------------");

            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Digite o {i}o. valor: ");
                valor[i] = int.Parse(Console.ReadLine());
            }

            maiorvlr = valor[0];
            for (int i = 1; i < valor.Length; i++)
            {
                maiorvlr = maiorvlr > valor[i] ? maiorvlr : valor[i];
            }

            //funcao do C# que faz a avaliação do maior número de uma lista
            //maiorvlr = valor.Max();

            Console.WriteLine();
            Console.WriteLine($"O maior valor é: {maiorvlr}");

            Console.ReadLine();
        }

        static void A3E3_MediaAl()
        {
            float nota = 0.0f;
            float media = 0.0f;

            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine($"EXERCICIO 3 - MEDIA DE ALUNO E APROVAÇAO/REPROVAÇAO");
            Console.WriteLine("----------------------------------------------------");

            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Escreva a {i}a. nota: ");
                nota += float.Parse(Console.ReadLine());
            }

            media = nota / 3;

            Console.WriteLine();
            Console.Write($"Media: {media}. ");

            if (media >= 7)
            {
                Console.WriteLine($"Aluno Aprovado.");
            }
            else
            {
                Console.WriteLine($"Aluno Reprovado.");
            }

            Console.ReadLine();
        }

        static void A3E4_ExibeMed()
        {
            float nota = 0.0f;
            float media = 0.0f;

            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine($"EXERCICIO 4 - NOTA DE ALUNO (ABCDEF)");
            Console.WriteLine("----------------------------------------------------");

            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Escreva a {i + 1}a. nota: ");
                nota += float.Parse(Console.ReadLine());
            }

            media = nota / 3;

            Console.WriteLine();
            Console.Write($"Media: {media}. ");

            if (media < 6)
            {
                Console.WriteLine($"Nota F");
            }
            else if (media >= 6 && media < 7)
            {
                Console.WriteLine($"Nota D");
            }
            else if (media >= 7 && media < 8)
            {
                Console.WriteLine($"Nota C");
            }
            else if (media >= 8 && media < 9)
            {
                Console.WriteLine($"Nota B");
            }
            else if (media >= 9 && media < 10)
            {
                Console.WriteLine($"Nota A");
            }

            Console.ReadLine();
        }

        static void A3E5_Reaj()
        {
            float[] valores = { 400.00f, 800.00f, 1200.00f, 2000.00f };
            float[] qtdnt = { 1.15f, 1.12f, 1.10f, 1.07f, 1.04f };

            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine($"EXERCICIO 4 - REAJUSTE SALARIO");
            Console.WriteLine("----------------------------------------------------");

            Console.Write("Digite o valor do salário: ");
            float salario = float.Parse(Console.ReadLine());

            for (int i = 0; i < qtdnt.Length - 1; i++)
            {
                if (salario < valores[i])
                {
                    Console.Write($"Novo salário: {salario * qtdnt[i]}");
                    i = qtdnt.Length;
                }
            }
            if (salario > valores[valores.Length - 1])
            {
                Console.Write($"Novo salário: {salario * qtdnt[qtdnt.Length - 1]}");
            }

            Console.ReadLine();
        }

    }
}
