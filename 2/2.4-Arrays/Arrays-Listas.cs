int[] array = new int[5]; // declarando um array com no maximo 5 elementos

int[] array2 = new int[] { 1, 2, 3, 4, 5 }; // declarando e inicializando um array com 5 elementos determinados

int[] array3 = { 1, 2, 3, 4, 5 }; // declarando e inicializando um array com 5 elementos determinados

//pode-se omitir o new int[] na inicialização do array, mas é necessário informar os valores entre chaves

for (int contador = 0; contador < array2.Lenght; contador++)
{
    Console.WriteLine($"Posição Numero {contador} : {array2[contador]}");
}

//foreach é um metodo para percorrer listas sem utilizar um contador, igual ao for do python
//precisariamos iniciar um contador para numerar a posição do array
int contadorArray = 0;

foreach(int valor in array2)
{
    Console.WriteLine($"Posição numero {contadorArray}");
    Console.WriteLine($"Posição Numero {contadorArray} : {array2[valor]}");
    contadorArray++;
}

//redimensionando um array

Array.Resize(ref array2, array2.Lenght*2); //dobra o tamanho do array2

//Array.Copy(destino, array a ser copiado, quantos elementos serão copiados)
//Listas são objetos mais dinamicas do que arrays, usando o core dos arrays, so que de forma mais simples para de redimensionar automaticamente e etc

List<string> nomeDaLista = new List<string>();
nomeDaLista.Add("SP");
nomeDaLista.Add("BA");
nomeDaLista.Add("ES");

for (int contador = 0; nomeDaLista.Count; contador++) //o metodo Count substitui o metodo lenght em listas
{
    Console.WriteLine($"Posição Numero {contador} : {nomeDaLista[contador]}");
}//acessar o elemento da lista é igual a de um array, o metodo foreach funciona igualmente ao array tbm

//preferir em utilizar listas em detrimento dos arrays, pela flexibilidade