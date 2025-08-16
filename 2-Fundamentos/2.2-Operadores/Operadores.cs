
using Models; //importando o namespace Models onde está a classe Calculadora
//na pasta models do projeto
using Basico.Models; //namespace presente no models do projeto 2.1
//operador soma

int a = 10;
int b = 5;
int soma = a + b; //soma
Console.WriteLine($"Soma: {soma}");

soma += 5; //soma e atribui o resultado a soma
Console.WriteLine($"Soma após incremento: {soma}");

// convertendo tipos
int numero = Convert.ToInt32("5"); //converte string para int
int numrero2 = int.Parse("10"); //converte string para int com metodo parse
Console.WriteLine($"Número convertido: {numero}, Número2 convertido: {numrero2}");
// metodo Convert transforma null em zero, enquanto o metodo Parse gera erro se for nulo

string texto = 5.ToString(); //converte int para string
Console.WriteLine($"Texto convertido: {texto}");

//se um tipo couber em outro, não é necessário conversão, apenas atribuição de tipo
//exemplo > int a = 10; long b = a; //atribuição direta, pois int cabe em long

//conversão segura

string numeroInvalido = "25abc"; //string inválida para conversão
int.TryParse(numeroInvalido, out int conversao); //tenta converter e jogar o valor para a variavel conversão
//se conseguir, reatribui a variavel conversão , se não conseguir , retorna zero
Console.WriteLine(conversao);


//operadores condicionais

int quantidadeEstoque = 10;
int quantidadeCompra = 5;
if (quantidadeEstoque >= quantidadeCompra) //verifica se a quantidade em estoque é maior ou igual a quantidade da compra
{
    Console.WriteLine("Venda realizada com sucesso!");
}
else
{
    Console.WriteLine("Estoque insuficiente para realizar a venda.");
}

//assim como python é possivel atribuir comparação a uma variavel booleana, e então utilizar
bool podeVender = quantidadeEstoque >= quantidadeCompra; //atribui o resultado da comparação a uma variavel booleana

if (podeVender)
{
    Console.WriteLine("Venda realizada com sucesso! v2");
}
else
{
    Console.WriteLine("Estoque insuficiente para realizar a venda.v2");
}


//&& é igual ao and em python
//|| é igual ao or em python 

// switch case

Console.WriteLine("Digite uma letra minuscula:");
string letra = Console.ReadLine();

switch (letra)
{
    case "a":
    case "e":
    case "i":
    case "o":
    case "u":
        Console.WriteLine("A letra é uma vogal.");
        break;
    default:
        Console.WriteLine("A letra é uma consoante.");
        break;
}


//Praticas com operadores logicos

//permissão para entrar no evento > maior de 18 ou permitido pelos pais

bool maiorDeIdad = true;
bool permitidoPelosPais = false;

if (maiorDeIdad || permitidoPelosPais) //se for maior de idade ou permitido pelos pais
{
    Console.WriteLine("Entrada permitida.");
}
else
{
    Console.WriteLine("Entrada negada.");
}


//aprovação se contem presença e nota maior que 7

bool temPresenca = true;
double nota = 8.5;
bool aprovado = temPresenca && nota >= 7; //aprovado se tiver presença e nota maior que 7
if (aprovado)
{
    Console.WriteLine("Aprovado!");
}
else
{
    Console.WriteLine("Reprovado!");
}

//operador not é utilizado para inverter o valor booleano, representado por ! em C#



// utilizar a classe calculadora criada, com Namespace Models na pasta Models
//utilizamos o Math.Round para arredondar o resultado de seno, coseno e tangente

Calculadora calculadora = new Calculadora();
calculadora.Somar(10, 5);
calculadora.Subtrair(10, 5);
calculadora.Multiplicar(10, 5);
calculadora.Dividir(10, 5);
calculadora.Dividir(10, 0); //teste de divisão por zero
calculadora.Potenciação(3, 3); //3 elevado a 3
calculadora.Seno(90); //seno de 90 graus
calculadora.Coseno(90); //coseno de 90 graus
calculadora.Tangente(45); //tangente de 45 graus 

Pessoa p = new Pessoa(); //utiliza a classe Pessoa para definir um objeto p (camelCase)
p.Nome = "João";  
p.Idade = 30;
p.Apresentar(); //metodo apresentar da classe Pessoa

//metodo pessoa so existe no projeto 2.1, para utilizar é necessario adicionar referencia ao projeto 2.1
//o sln serve para referenciarmos diferentes projetos que utilizam mesmas soluções
//neste caso aqui, estou utilizando a solução pessoa, do projeto 2.1, no projeto 2.2, que representa
//a solução de operadores
//utilizar a extensão vscode-solution-explorer
//adicionar os csproj no sln, e adicionar a referencia quando necessario
//a boa pratica é condensar os commons em uma unica pasta de classes, e apenas uma pasta de solução executavel