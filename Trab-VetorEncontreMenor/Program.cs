// faça um programa que leia 5 valores e encontre o menor
int aux = 0, size = 10;

int[] numeros = new int[size];
int[] ordenado = new int[size];

for(int i = 0; i < size; i++)
{
    numeros[i] = new Random().Next(0, 100);
}

for(int i =  0; i < size; i++)
{
    ordenado[i]  = numeros[i]; // copia os dados do vetor NUMEROS para o vetor ORDENADO
}

for (int i = 0; i < size; i++)
{
    for (int j = i+1; j < size; j++)
    {
        if (ordenado[i] > ordenado[j])
        {
            aux = ordenado[i];
            ordenado[i] = ordenado[j];
            ordenado[j] = aux;
        }
    }
}

for (int i = 0; i < size; i++)
{
    Console.Write(numeros[i] + " ");
}

Console.WriteLine();

for (int i = 0; i < size; i++){
    Console.Write(ordenado[i] + " ");
}
