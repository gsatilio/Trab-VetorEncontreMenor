// faça um programa que leia 5 valores e encontre o menor
using System.Runtime.Intrinsics.X86;

int aux = 0, size = 10, repetidos = 0, sizefinal = 0;

int[] numeros = new int[size]; 
//int[] numeros = new int[] { 2, 3, 7, 4, 4, 0, 234, 234, 1, 5}; ; 
int[] ordenado = new int[size];
int[] ordenado_norepeat = new int[size];
int[] ordenado_norepeatback = new int[size];


// pega numeros
for(int i = 0; i < size; i++)
{
    //numeros[i] = new Random().Next(0, 100);
    numeros[i] = int.Parse(Console.ReadLine());
    ordenado[i] = numeros[i];
    ordenado_norepeat[i] = numeros[i];
}

for(int i =  0; i < size; i++)
{
    ordenado[i]  = numeros[i]; // copia os dados do vetor NUMEROS para o vetor ORDENADO
}

// ordena normal
for (int i = 0; i < size; i++)
{
    for (int j = i + 1; j < size; j++)
    {
        // ordenado normal
        if (ordenado[i] > ordenado[j])
        {
            aux = ordenado[i];
            ordenado[i] = ordenado[j];
            ordenado[j] = aux;
        }

        // ordenado sem repetir
        if (ordenado_norepeat[i] > ordenado_norepeat[j])
        {
            aux = ordenado_norepeat[i];
            ordenado_norepeat[i] = ordenado_norepeat[j];
            ordenado_norepeat[j] = aux;
        }
        else if (ordenado_norepeat[i] == ordenado_norepeat[j])
        {
            ordenado_norepeat[i] = 0;
            repetidos++;
        }

    }
}

// ordena novamente os repetidos, para começar do zero
for (int i = 0; i < size; i++)
{
    for (int j = i + 1; j < size; j++)
    {
        // ordenado sem repetir
        if (ordenado_norepeat[i] > ordenado_norepeat[j])
        {
            aux = ordenado_norepeat[i];
            ordenado_norepeat[i] = ordenado_norepeat[j];
            ordenado_norepeat[j] = aux;
        }
        else if (ordenado_norepeat[i] == ordenado_norepeat[j])
        {
            ordenado_norepeat[i] = 0;
        }

    }
}


sizefinal = size - repetidos;

Console.WriteLine("\nNumeros informados:");
for (int i = 0; i < size; i++)
{
    Console.Write(numeros[i] + " ");
}

Console.WriteLine("\nNumeros ordenados:");
for (int i = 0; i < size; i++){
    Console.Write(ordenado[i] + " ");
}

Console.WriteLine("\nNumeros ordenados sem repetir:");
for (int i = repetidos; i < size; i++)
{
    Console.Write(ordenado_norepeat[i] + " ");
}

if(sizefinal == 10)
{
    sizefinal = 9;
}
Console.WriteLine("\nNumeros ordenados sem repetir ao contrario:");
//for (int i = sizefinal+1; i >= repetidos; i--)
// Exemplo SIZE = 10 numeros, REPETIDOS = 2 repetiu 2, entao I = 10 + 2 - 1 (pois pro vetor eh uma casa a menos)
for(int i = (sizefinal); i >= 0 + repetidos; i--)
{
    Console.Write(ordenado_norepeat[i] + " ");
}


Console.WriteLine();
