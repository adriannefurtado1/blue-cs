var numeros = 1;

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

Console.WriteLine(condicao);

/*Console.WriteLine("Digite o nome: ");
var nomedousuario = Console.ReadLine();

Console.WriteLine("Digite a idade: ");
var idadedousuario = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o ano: ");
var anoatual = int.Parse(Console.ReadLine());

Console.WriteLine($"Olá {nomedousuario}, você nasceu em {anoatual - idadedousuario}.");
*/
// Funcoes
void cumprimentar(string cumprimento, string nome)
{
    Console.WriteLine($"{cumprimento} {nome}!");
}

cumprimentar("oi", "Willian");
cumprimentar("Hello", "Thais");
cumprimentar("Hi", "Maiara");
cumprimentar("Ça va", "Adrianne");


string cumprimentar2(string cumprimento, string nome)
{
    return $"{cumprimento} {nome}!";
}

Console.WriteLine(cumprimentar2("oi", "Willian"));
Console.WriteLine(cumprimentar2("Hello", "Thais"));
Console.WriteLine(cumprimentar2("Hi", "Maiara"));
Console.WriteLine(cumprimentar2("Ça va", "Adrianne"));
