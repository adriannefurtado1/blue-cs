using System;

namespace Aula4
{
    internal class ExsAula4
    {
        static void Main()
        {
            //A4E1_Lista10();
            //A4E2_ParImpar();
            //A4E3_OrdenaTamanho();
            //A4E4_Jokenpo();
            A4E5_Velha();
        }
        static void A4E1_Lista10()
        {
            int[] numeros = new int[10];

            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine($"EXERCICIO 1 - MULTIPLICAR NUMEROS DIGITADOS POR 5");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine();

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Digite o {i + 1}o. numero:");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();
            Console.WriteLine("OS NUMEROS DIGITADOS FORAM MULTIPLICADOS POR 5");
            Console.Write($"Numeros Digitados: ");

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{numeros[i].ToString("#######")} ");
                if (i < 9)
                {
                    Console.Write(", ");
                }

            }

            Console.WriteLine();
            Console.WriteLine();
            Console.Write($"Numeros Digit. x5: ");

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{(numeros[i] * 5).ToString("#######")}");
                if (i < 9)
                {
                    Console.Write(", ");
                }
            }

            Console.ReadLine();
        }

        static void A4E2_ParImpar()
        {
            int numdig;
            int[] pares = new int[0];
            int[] impares = new int[0];


            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine($"EXERCICIO 2 - NUMEROS PARES E IMPARES");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine();

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Digite o {i + 1}o. numero:");
                numdig = int.Parse(Console.ReadLine());
                if (numdig % 2 == 0)
                {
                    Array.Resize(ref pares, pares.Length + 1);
                    pares[pares.Length - 1] = numdig;
                }
                else
                {
                    Array.Resize(ref impares, impares.Length + 1);
                    impares[impares.Length - 1] = numdig;
                }
            }

            Console.Write($"Lista dos números pares: ");
            foreach (int p in pares)
            {
                Console.Write($"{p} ");
            }

            Console.WriteLine();
            Console.Write($"Lista dos números impares: ");
            foreach (int i in impares)
            {
                Console.Write($"{i} ");
            }

            Console.ReadLine();
        }

        static void A4E3_OrdenaTamanho()
        {
            string[] palavras = new string[5];

            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine($"EXERCICIO 3 - ORDENAR 5 PALAVRAS POR TAMANHO");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine();

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Digite a {0}a. palavra: ", i + 1);
                palavras[i] = Console.ReadLine();
            }

            Array.Sort(palavras, (x, y) => x.Length.CompareTo(y.Length));

            foreach (string palavra in palavras)
            {
                Console.Write(palavra + " ");
            }

            Console.ReadLine();
        }

        static void A4E4_Jokenpo()
        {
            int QtdJogadas = 0;
            int JogadasValidas = 0;
            int HumanoGanhou = 0;
            int ComputadorGanhou = 0;
            String[] possibilidades = { "1.Pedra", "2.Papel", "3.Tesoura" }; //1.Pedra 2.Papel 3.Tesoura
            int RspHmn;
            int RspCpt;

            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine($"EXERCICIO 4 - JOKENPO");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine();

            Random rnd = new Random();
            //Random.
            do
            {
                Console.WriteLine();
                Console.WriteLine("==[ JO-KEN-PO ]==");
                Console.WriteLine();
                Console.Write("Quantas jogadas? ");
                QtdJogadas = int.Parse(Console.ReadLine());
                JogadasValidas = 0;

                Console.WriteLine($"=======================================================");

                do
                {
                    Console.WriteLine("JOQUE: 1.Pedra 2.Papel 3.Tesoura\n");
                    Console.Write("Sua Jogada:");
                    RspHmn = int.Parse(Console.ReadLine());
                    RspCpt = rnd.Next(1, 3);

                    Console.WriteLine();
                    Console.WriteLine($"Você Jogou {possibilidades[RspHmn - 1]}");
                    Console.WriteLine($"Computador Jogou: {possibilidades[RspCpt - 1]}");
                    Console.WriteLine();

                    if (RspHmn != RspCpt)
                    {
                        JogadasValidas++;

                        if ((RspHmn == 2 && RspCpt == 1) || (RspHmn == 3 && RspCpt == 2) || (RspHmn == 1 && RspCpt == 3))
                        {
                            Console.WriteLine("VOCÊ GANHOU.\n");
                            HumanoGanhou++;
                        }
                        else
                        {
                            Console.WriteLine("COMPUTADOR GANHOU.\n");
                            ComputadorGanhou++;
                        }

                    }
                    else
                    {
                        Console.WriteLine("JOGADA EMPATOU.\n");
                    }
                    Console.WriteLine($"=======================================================");

                } while (JogadasValidas != QtdJogadas);

                Console.WriteLine($"********************************************************");
                if (HumanoGanhou > ComputadorGanhou)
                {
                    Console.WriteLine($"**VOCÊ** É O GRANDE CAMPEÃO COM {HumanoGanhou} VITÓRIAS!");
                }
                else if (ComputadorGanhou > HumanoGanhou)
                {
                    Console.WriteLine($"O **COMPUTADOR** É O GRANDE CAMPEÃO COM {ComputadorGanhou} VITÓRIAS!");
                }
                else
                {
                    Console.WriteLine($"ESSA RODADA DEU EMPATE, AMBOS COM {ComputadorGanhou} VITÓRIAS!");
                }
                Console.WriteLine($"********************************************************");
                Console.ReadLine();

                Console.Write($"Jogar Novamente?(S/N)");
            } while (Console.ReadLine() == "S");

        }

        static void A4E5_Velha()
        {
            string[] nomes = { "", "" };
            string[,] tabuleiro = new string[3, 3];
            char[] possibilidades = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            char[] preenchido = { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
            bool fimjogo = false;
            string campeao = "";
            char selecao;
            int qtdjog = 0;

            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine($"EXERCICIO 4 - JOGO DA VELHA");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine();

            Console.WriteLine("==[ JOGO DA VELHA ]==");
            Console.WriteLine();

            Console.Write("Informe o nome do jogador X: ");
            nomes[0] = Console.ReadLine();
            Console.Write("Informe o nome do jogador O: ");
            nomes[1] = Console.ReadLine();

            do
            {

                Console.WriteLine();
                Console.WriteLine("Veja o Tabuleiro");
                Console.WriteLine($" 7 | 8 | 9      {preenchido[6]} | {preenchido[7]} | {preenchido[8]}    ");
                Console.WriteLine($"---|---|---    ---|---|---  ");
                Console.WriteLine($" 4 | 5 | 6      {preenchido[3]} | {preenchido[4]} | {preenchido[5]}    ");
                Console.WriteLine($"---|---|---    ---|---|---  ");
                Console.WriteLine($" 1 | 2 | 3      {preenchido[0]} | {preenchido[1]} | {preenchido[2]}    ");

                Console.WriteLine();
                Console.Write($"Jogador {(qtdjog % 2)} - {nomes[qtdjog % 2]} - Em que posição deseja jogar? ");

                do
                {

                    selecao = Char.Parse(Console.ReadLine());

                    if (Array.IndexOf(possibilidades, selecao) < 0)
                    {
                        Console.Write("Valor inválido, digite novamente: ");
                    }
                    else if (preenchido[Array.IndexOf(possibilidades, selecao)] != ' ')
                    {
                        Console.Write("Local preenchido, digite novamente: ");
                    }
                    else
                    {
                        qtdjog++;
                    }


                } while (Array.IndexOf(possibilidades, selecao) < 0 || preenchido[Array.IndexOf(possibilidades, selecao)] != ' ');

                preenchido[Array.IndexOf(possibilidades, selecao)] = (qtdjog % 2) == 0 ? 'O' : 'X';

                if (qtdjog == 9)
                {
                    fimjogo = true;
                }

                if ((preenchido[0] == 'X' && preenchido[1] == 'X' && preenchido[2] == 'X') ||
                    (preenchido[3] == 'X' && preenchido[4] == 'X' && preenchido[5] == 'X') ||
                    (preenchido[6] == 'X' && preenchido[7] == 'X' && preenchido[8] == 'X') ||
                    (preenchido[6] == 'X' && preenchido[3] == 'X' && preenchido[0] == 'X') ||
                    (preenchido[7] == 'X' && preenchido[4] == 'X' && preenchido[1] == 'X') ||
                    (preenchido[8] == 'X' && preenchido[5] == 'X' && preenchido[2] == 'X') ||
                    (preenchido[6] == 'X' && preenchido[4] == 'X' && preenchido[2] == 'X') ||
                    (preenchido[0] == 'X' && preenchido[4] == 'X' && preenchido[8] == 'X'))
                {
                    campeao = "X - " + nomes[0];
                    fimjogo = true;
                }
                else if ((preenchido[0] == 'Y' && preenchido[1] == 'Y' && preenchido[2] == 'Y') ||
                    (preenchido[3] == 'O' && preenchido[4] == 'O' && preenchido[5] == 'O') ||
                    (preenchido[6] == 'O' && preenchido[7] == 'O' && preenchido[8] == 'O') ||
                    (preenchido[6] == 'O' && preenchido[3] == 'O' && preenchido[0] == 'O') ||
                    (preenchido[7] == 'O' && preenchido[4] == 'O' && preenchido[1] == 'O') ||
                    (preenchido[8] == 'O' && preenchido[5] == 'O' && preenchido[2] == 'O') ||
                    (preenchido[6] == 'O' && preenchido[4] == 'O' && preenchido[2] == 'O') ||
                    (preenchido[0] == 'O' && preenchido[4] == 'O' && preenchido[8] == 'O'))
                {
                    campeao = "Y - " + nomes[1];
                    fimjogo = true;
                }


            } while (!fimjogo);

            Console.WriteLine();
            Console.WriteLine("Veja o Tabuleiro");
            Console.WriteLine($" 7 | 8 | 9      {preenchido[6]} | {preenchido[7]} | {preenchido[8]}   ");
            Console.WriteLine($"---|---|---    ---|---|---  ");
            Console.WriteLine($" 4 | 5 | 6      {preenchido[3]} | {preenchido[4]} | {preenchido[5]}    ");
            Console.WriteLine($"---|---|---    ---|---|---  ");
            Console.WriteLine($" 1 | 2 | 3      {preenchido[0]} | {preenchido[1]} | {preenchido[2]}    ");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"************************************");
            Console.WriteLine($"  {campeao} GANHOU  !!!!");
            Console.WriteLine($"************************************");

            Console.ReadLine();
        }

    }
}