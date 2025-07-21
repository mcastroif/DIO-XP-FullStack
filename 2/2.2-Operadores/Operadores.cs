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
