while (true)
{
    int aux, size, repetidos, sizefinal, numcontrol, posicao, opcao;
    aux = 0;
    size = -1;
    repetidos = 0;
    sizefinal = 0;
    opcao = 10;
    // USUARIO ESCOLHE A QTDE DE REGISTROS
    while (size < 0)
    {
        Console.WriteLine("Escolha a quantidade de numeros a serem informadas");
        size = int.Parse(Console.ReadLine());
    }

    // USUARIO ESCOLHE A OPCAO SE QUER ALEATORIO OU MANUAL
    while (opcao < 0 || opcao > 1)
    {
        Console.WriteLine("Escolha sua opção:\n0 - Numeros Aleatorios\n1- Numeros manualmente");
        opcao = int.Parse(Console.ReadLine());
    }

    int[] numeros = new int[size];
    int[] ordenado = new int[size];

    // ESCOLHE A FORMA COMO OS DADOS SERAO INFORMADOS
    switch (opcao)
    {
        case 0:
            for (int i = 0; i < size; i++)
            {
                numeros[i] = new Random().Next(0, size);
                ordenado[i] = numeros[i];
            }
            break;
        case 1:
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"Informe o {i + 1} numero:");
                numeros[i] = int.Parse(Console.ReadLine());
                ordenado[i] = numeros[i];
            }
            break;
    }

    // REALIZA ORDENACAO CRESCENTE NO VETOR "ORDENADO"
    for (int i = 0; i < size; i++)
    {
        for (int j = i + 1; j < size; j++)
        {
            // ordena no vetor "Normal"
            if (ordenado[i] > ordenado[j])
            {
                aux = ordenado[i];
                ordenado[i] = ordenado[j];
                ordenado[j] = aux;
            }
        }
    }

    // COM BASE NO VETOR ORDENADO, VERIFICO QUANTOS NUMEROS SAO REPETIDOS, COMPARANDO O NRO ATUAL COM O ANTERIOR
    // SE REPETE, ADICIONO AO CONTADOR "REPETIDOS"
    numcontrol = ordenado[0];
    for (int i = 1; i < size; i++)
    {
        if (ordenado[i] == numcontrol)
        {
            repetidos++;
        }
        numcontrol = ordenado[i];
    }

    // VARIAVEL "SIZEFINAL", PEGA O SIZE ORIGINAL E DIMINUI OS REPETIDOS, PARA GERAR UM NOVO VETOR COM TAMANHO MENOR SE NECESSARIO
    sizefinal = size - repetidos;
    int[] ordenado_norepeat = new int[sizefinal];

    // NOVO VETOR "ORDENADO_NOREPEAT" DE TAMANHO "SIZEFINAL"
    // INICIO NA POSICAO 0, NUMERO = PRIMEIRO INDICE DO ORDENADO
    // E PRIMEIRO INDICE DO ORDENADO NO REPEAT = PRIMEIRO INDICE DO ORDENADO
    numcontrol = ordenado[0];
    ordenado_norepeat[0] = ordenado[0];
    posicao = 0;
    for (int i = 1; i < size; i++)
    {
        if (ordenado[i] != numcontrol)
        {
            // VARIAVEL PARA CONTROLAR O INDICE PARA INSERIR NO ARRAY CORRETO NO VETOR "ORDENADO_NOREPEAT"
            posicao++;
            ordenado_norepeat[posicao] = ordenado[i];
        }
        numcontrol = ordenado[i];
    }

    /*
        AQUI JA TENHO:
        VETOR ORIGINAL
        VETOR ORDENADO (ORIGINAL)
        VETOR NO REPEAT JA ORDENADO

    */

    ///// IMPRESSOES ////////
    ///
    Console.WriteLine("\nNumeros informados:");
    for (int i = 0; i < size; i++)
    {
        Console.Write(numeros[i] + " "); // VETOR ORIGINAL
    }

    Console.WriteLine("\nNumeros ordenados:");
    for (int i = 0; i < size; i++)
    {
        Console.Write(ordenado[i] + " "); // VETOR ORDENADO
    }

    Console.WriteLine("\nNumeros ordenados sem repetir:");
    for (int i = 0; i < sizefinal; i++)
    {
        Console.Write(ordenado_norepeat[i] + " "); // VETOR ORDENADO NO REPEAT
    }

    Console.WriteLine("\nNumeros ordenados sem repetir ao contrario:");
    for (int i = (sizefinal - 1); i >= 0; i--)
    {
        Console.Write(ordenado_norepeat[i] + " "); // VETOR ORDENADO NO REPEAT INVERSO
    }

    Console.ReadLine();
    Console.Clear();
}