// //tabuada de 5

// //for (inicialização; condição; incremento)

// using System.ComponentModel;

// int baseMult = 5;
// for (int i = 1; i <= 10; i++) // (inicio do contador, condição de parada, incremento do contador )
// {
//     Console.WriteLine($"{baseMult} x {i} = {baseMult * i}");  //bloco de execução.
// }

// //o incremento so acontece pós execução do bloco de codigo

// //while (condição) é necessario inicializar um contador fora do laço
// int contador = 1; //inicialização do contador
// while (contador <= 10) //condição de parada
// {
//     Console.WriteLine($"{baseMult} x {contador} = {baseMult * contador}");
//     contador++; //incremento do contador
// }

// //é possivel utilizar um if dentro do laço para controlar a execução com um break em algum ponto de interesse
// //do while executa o codigo e depois verifica a condição, se ela for falsa, o laço é encerrado

// int numero = 0; //numero que vai ser lido
// int soma = 0; //variável para armazenar a soma
// do
// {
//     Console.WriteLine("Digite um número (0 para sair): ");
//     numero = Convert.ToInt32(Console.ReadLine()); //leitura do número

//     soma += numero; //acumula a soma
    
//  } while (numero != 0); //executa o bloco de código e depois verifica a condição

//  Console.WriteLine($"A soma dos números digitados é: {soma}"); //exibe a soma final
//ctrl k+ ctrl c comenta o codigo selecionado

