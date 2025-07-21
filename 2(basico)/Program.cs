using Basico.Models; //chamar o namespace Basico.Models definido na classe Pessoa

Pessoa p = new Pessoa(); //utiliza a classe Pessoa para definir um objeto p (camelCase)
p.Nome = "João";
p.Idade = 30;
p.Apresentar(); //metodo apresentar da classe Pessoa

//2.2 tipos de variaveis
//Tipos de variaveis: int, string, bool, float, double, decimal

string nome = "Maria"; //camelCase para variaveis
int idade = 25; //camelCase para variaveis
bool ativo = true; //camelCase para variaveis
double altura = 1.756487; //camelCase para variaveis , este tipo ignora casas decimais , 1.80=1.8
decimal preco = 1.50M; //camelCase para variaveis, 'm' indica tipo decimal, este tipo não ignora casas decimais

Console.WriteLine($"Nome: {nome}, Idade: {idade}, Ativo: {ativo}, Altura: {altura}, Preço: {preco}");

//tipo DateTime
DateTime agora = DateTime.Now; //metodo now pega data e hora atual
Console.WriteLine($"Data e hora atual: {agora}");

//metodo add do datetimenow

DateTime agoraMais10Dias = agora.AddDays(10); //adiciona 10 dias a data atual
Console.WriteLine($"Data e hora daqui a 10 dias: {agoraMais10Dias}");

//alterar o formato de saida da data, utilizando o metodo ToString com o formato desejado
Console.WriteLine($"Data formatada: {agora.ToString("dd/MM/yyyy")}");
Console.WriteLine($"Data formatada2(sem segundos): {agora.ToString("dd/MM/yyyy HH:mm")}"); //formato dia/mês/ano hora:minuto:segundo
