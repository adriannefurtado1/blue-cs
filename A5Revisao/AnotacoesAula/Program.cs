/*var numeros = 1;

//Camel case
int numerosInteirosEmCamelCase = 1;

//Pascal case
int NumerosInteirosEmPascal = 1;

//Snake case
int numeros_inteiros_em_snake_case = 1;

const int NUMEROS_INTEIROS_EM_UMA_CONSTANTE = 1;

Console.WriteLine("Atividade 1");

Console.WriteLine("Camel case: " + numerosInteirosEmCamelCase);

Console.WriteLine($"Camel case: {numerosInteirosEmCamelCase}");

// Operadores matemáticos
// + - / * %

int valor1 = 10;
int valor2 = 5;

int resultado = valor1 + valor2;

Console.WriteLine(resultado);
Console.WriteLine(valor1);
Console.WriteLine(valor2);

// Operadores de atribuição
// = += -= /= *=
int valor3 = 10;
int valor4 = 5;

valor3 += 10;
valor3 /= 10;

Console.WriteLine(valor3);

// Operadores lógicos
// > < >= <= == !=

int valor5 = 2;
int valor6 = 10;

bool condicao = valor5 != valor6;

Console.WriteLine(condicao);*/

/*Console.WriteLine("Digite o nome: ");
var nomedousuario = Console.ReadLine();

Console.WriteLine("Digite a idade: ");
var idadedousuario = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o ano: ");
var anoatual = int.Parse(Console.ReadLine());

Console.WriteLine($"Olá {nomedousuario}, você nasceu em {anoatual - idadedousuario}.");
*/


// 1. Funções
// 1.1 Funções que não respondem
/*void cumprimentar(string cumprimento, string nome)
{
    Console.WriteLine($"{cumprimento} {nome}!");
}

cumprimentar("oi", "Willian");
cumprimentar("Hello", "Thais");
cumprimentar("Hi", "Maiara");
cumprimentar("Ça va", "Adrianne");

// 1.2 Funcoes que respondem
string cumprimentar2(string cumprimento, string nome)
{
    return $"{cumprimento} {nome}!";
}

Console.WriteLine(cumprimentar2("oi", "Willian"));
Console.WriteLine(cumprimentar2("Hello", "Thais"));
Console.WriteLine(cumprimentar2("Hi", "Maiara"));
Console.WriteLine(cumprimentar2("Ça va", "Adrianne"));
*/

//Switch... Case... Break... Default

/*int indiceDoDiaDaSemana = 3;

switch(indiceDoDiaDaSemana)
{
    case 0:
        Console.WriteLine("Domingo");
        break;
    case 1:
        Console.WriteLine("Segunda");
        break;
    case 2:
        Console.WriteLine("Terça");
        break;
    case 3:
        Console.WriteLine("Quarta");
        break;
    case 4:
        Console.WriteLine("Quinta");
        break;
    case 5:
        Console.WriteLine("Sexta");
        break;
    case 6:
        Console.WriteLine("Sábado");
        break;
    default:
        Console.WriteLine("Valor informado não é válido!");
        break;

}*/

/*float peso = 0.0f;
float altura = 0.00f;
float IMC = 0.00f;

Console.Write("Digite o peso: ");
peso = float.Parse(Console.ReadLine());

Console.Write("Digite a altura: ");
altura = float.Parse(Console.ReadLine());

IMC = peso / (altura * altura);

Console.WriteLine($"IMC: {IMC}");
Console.Write("DIAGNÓSTICO: ");
switch (IMC)
{
    case <18.5f:
        Console.WriteLine("Anêmico");
        break;
    case <24.9f:
        Console.WriteLine("Normal");
        break;
    case <29.9f:
        Console.WriteLine("Sobrepeso");
        break;
    case <40.0f:
        Console.WriteLine("Obesidade");
        break;
    case >40.0f:
        Console.WriteLine("Obesidade grave");
        break;
    default:
        Console.WriteLine("Valores informados não são válidos!");
        break;
}*/


// 3. Estrutura de repetição
// 3.1 Estrutura de repetição FOR
// (valorInicial    ; condição    ; modificador)
/*
for(int contador = 0; contador < 5; contador++)
{
    Console.WriteLine(contador);
}
*/

// 3.2 Estrutura de repetição WHILE
// contador
int _contador = 0;

// condição
/*
while (_contador < 5)
{
    Console.WriteLine(_contador);
    //modificador
    _contador++;
}
*/

/*
int __contador = 0;
do
{
    Console.WriteLine(__contador);
    //modificador
    __contador++;

} while (__contador < 5);
*/

// 4. Vetores
// 4.1 Declaracao de vetores
int[] numerosPares = { 0, 2, 4 };
int[] numerosImpares = new int[3];

numerosImpares[0] = 1;
numerosImpares[1] = 3;
numerosImpares[2] = 5;

int[] numerosPrimos = new int[3] { 2, 7, 11 };

// 4.2 Acessar valores

/*
Console.WriteLine(numerosPares[0]); //0
Console.WriteLine(numerosImpares[0]); // 1
Console.WriteLine(numerosPrimos[0]); //2
*/

// 4.3 Editar valores
numerosPrimos[2] = 11;

// 4.4 Vetores bidimensionais
string[,] tabuleiro = new string[3, 3] 
{   
    { "X", "X", "O"},
    { "X", "O", "X"},
    { "O", "X", "X"}
};
/*
Console.WriteLine(tabuleiro[0, 0]);
*/

// 5. Estrutura de repetição em Vetores

// 5.1 Estrutura de repetição for... em Vetores
Console.WriteLine("Imprime numeros pares");
for (int indice = 0; indice < numerosPares.Length; indice++)
{
    Console.WriteLine(numerosPares[indice]);
}


// 5.1 Estrutura de repetição foreach... em Vetores
foreach (int numero in numerosPares)
{
    Console.WriteLine(numero);
}

// 5.1 Estrutura de repetição foreach... em Vetores bidimensionais
for(int linha = 0; linha<tabuleiro.GetLength(0);linha++)
{
    for(int coluna = 0;coluna<tabuleiro.GetLength(1);coluna++)
    {
        Console.WriteLine(tabuleiro[linha,coluna]);
    }
}
