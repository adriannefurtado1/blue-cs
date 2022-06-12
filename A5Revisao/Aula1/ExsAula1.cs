using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1
{
    internal class ExsAula1
    {

        static void Main()
        {
            Aula1_Ex1();
            Console.WriteLine();
            Console.WriteLine();

            Aula1_Ex2();
            Console.WriteLine();
            Console.WriteLine();

            Aula1_Ex3();
            Console.WriteLine();
            Console.WriteLine();

            Aula1_Ex4();
            Console.WriteLine();
            Console.WriteLine();
        }

        static void Aula1_Ex1()  
        {
            string snome;
            string sadress;
            string scep;
            string stelefone;
            
            Console.WriteLine($"*******************************");
            Console.WriteLine($"AULA 1 - EXERCICIO 1");
            Console.WriteLine($"*******************************");

            snome = "Adrianne Furtado";
            sadress = "R. Que Sobe e Desce, 1000";
            scep = "88066-200";
            stelefone = "11-99719-5555";

            Console.WriteLine($"Nome:  {snome}");
            Console.WriteLine($"Endereço: {sadress}");
            Console.WriteLine($"CEP: {scep}");
            Console.WriteLine($"Telefone: {stelefone}");
        }

        static void Aula1_Ex2()
        {
            string snome;
            string sformacao;
            string scontrib;

            Console.WriteLine($"*******************************");
            Console.WriteLine($"AULA 1 - EXERCICIO 2");
            Console.WriteLine($"*******************************");

            snome = "Ada Lovelace";
            sformacao = "matemática e escritora";
            scontrib = "Reconhecida principalmente por ter escrito o primeiro algoritmo para ser processado por uma máquina, a máquina analítica de Charles Babbage.[1][2] Durante o período em que esteve envolvida com o projeto de Babbage, ela desenvolveu os algoritmos que permitiriam à máquina computar os valores de funções matemáticas, além de publicar uma coleção de notas sobre a máquina analítica. Por esse trabalho é considerada a primeira programadora de toda a história.";

            Console.WriteLine($"Nome: {snome}");
            Console.WriteLine($"Formação: {sformacao}");
            Console.WriteLine($"Contribuição: {scontrib}");
        }

        static void Aula1_Ex3()
        {
            string sletra;
            string scompositor;
            string sgenmus;

            Console.WriteLine($"*******************************");
            Console.WriteLine($"AULA 1 - EXERCICIO 3");
            Console.WriteLine($"*******************************");

            sletra = "----FAST CAR----";
            sletra += "\nI want a ticket to anywhere";
            sletra += "\nMaybe we make a deal";
            sletra += "\nMaybe together we can get somewhere";
            sletra += "\nAny place is better";
            sletra += "\nStarting from zero got nothing to lose";
            sletra += "\nMaybe we'll make something";
            sletra += "\nMe, myself, I got nothing to prove";
            sletra += "\nYou got a fast car";
            sletra += "\nI got a plan to get us outta here";
            sletra += "\nI been working at the convenience store";
            sletra += "\nManaged to save just a little bit of money";
            sletra += "\nWon't have to drive too far";
            sletra += "\nJust 'cross the border and into the city";
            sletra += "\nYou and I can both get jobs";
            sletra += "\nAnd finally see what it means to be living";
            sletra += "\nSee, my old man's got a problem";
            sletra += "\nHe live with the bottle, that's the way it is";
            sletra += "\nHe says his body's too old for working";
            sletra += "\nHis body's too young to look like his";
            sletra += "\nMy mama went off and left him";
            sletra += "\nShe wanted more from life than he could give";
            sletra += "\nI said somebody's got to take care of him";
            sletra += "\nSo I quit school and that's what I did";
            sletra += "\nYou got a fast car";
            sletra += "\nIs it fast enough so we can fly away?";
            sletra += "\nWe gotta make a decision";
            sletra += "\nLeave tonight or live and die this way";
            sletra += "\nSo I remember when we were driving, driving in your car";
            sletra += "\nSpeed so fast it felt like I was drunk";
            sletra += "\nCity lights lay out before us";
            sletra += "\nAnd your arm felt nice wrapped 'round my shoulder";
            sletra += "\nAnd I-I had a feeling that I belonged";
            sletra += "\nI - I had a feeling I could be someone, be someone, be someone";

            scompositor = "Tracy Chapman";
            sgenmus = "Folk";

            Console.WriteLine(sletra);
            Console.WriteLine();
            Console.WriteLine($"Compositor(a): {scompositor}");
            Console.WriteLine($"Genero Musical: {sgenmus}");
        }

        static void Aula1_Ex4()
        {

            Console.WriteLine($"*******************************");
            Console.WriteLine($"AULA 1 - EXERCICIO 3I");
            Console.WriteLine($"*******************************");

            Console.WriteLine($"Woman! We want you for I.T. army! Enlist Now!");
        }

    }
}
