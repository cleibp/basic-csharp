using System;

enum Cor { Vermelho, Verde, Azul, Amarelo, Laranja }

class Program
{
    public static void Main(string[] args)
    {


        string nome = "Cleiton";
        int idade = 20;
        char sexo = 'M';
        double peso = 70.5;
        bool ativo = true;

        int val1, val2, adicao, subtracao, multiplicacao, divisao, modulo;

        int idadeTernario;
        string idadeTer;

        int idadeIF;

        int dia;

        int a = 0;

        int b = 0;

        int c = 0;

        int m = 0;
        int n = 0;

        int numero1, numero2, res;

        // Constante
        const double PI = 3.14159265;

        // Comentário de uma linha

        /* Comentário
        de varias linhas */

        // ESCREVER NA TELA
        Console.WriteLine("#### ESCREVER NA TELA ####");
        Console.WriteLine("Olá Mundo");
        Console.WriteLine("");

        // VARIÁVEIS
        Console.WriteLine("### VARIÁVEIS E TIPOS BÁSICOS ###");
        Console.WriteLine("Nome: " + nome);
        Console.WriteLine("Idade: " + idade);
        Console.WriteLine("Sexo: " + sexo);
        Console.WriteLine("Peso: " + peso);
        Console.WriteLine("Ativo: " + ativo);
        Console.WriteLine("\n");

        // CONSTANTE
        Console.WriteLine("### CONSTANTE ###");
        Console.WriteLine("PI: " + PI);
        Console.WriteLine("\n");

        // OPERACOES
        Console.WriteLine("#### OPERACOES ####");
        Console.Write("Informe o valor 1: ");
        val1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Informe o valor 2: ");
        val2 = Convert.ToInt32(Console.ReadLine());

        adicao = val1 + val2; // Pode usar: (+, -, *, /, %)
        subtracao = val1 - val2;
        multiplicacao = val1 * val2;
        divisao = val1 / val2;
        modulo = val1 % val2;
        Console.WriteLine("Soma: " + adicao);
        Console.WriteLine("Subtracao: " + subtracao);
        Console.WriteLine("Multiplicacao: " + multiplicacao);
        Console.WriteLine("Divisao: " + divisao);
        Console.WriteLine("Modulo: " + modulo);
        Console.WriteLine("");

        // TERNARIO
        Console.WriteLine("### TERNARIO ###");
        Console.Write("Digite um número: ");
        idadeTernario = Convert.ToInt32(Console.ReadLine());
        idadeTer = idadeTernario >= 18 ? "Maior de idade" : "Menor de idade";
        Console.WriteLine(idadeTer);
        Console.WriteLine("\n");

        // IF ELSE IF ELSE
        Console.WriteLine("### IF ELSE IF ELSE ###");
        Console.Write("Informe a idade: ");
        idadeIF = Convert.ToInt32(Console.ReadLine());
        if (idadeIF < 12)
        {
            Console.WriteLine("CRIANCA");
        }
        else if ((idadeIF >= 12) && (idadeIF < 18))
        {
            Console.WriteLine("ADOLESCENTE");
        }
        else
        {
            Console.WriteLine("ADULTO");
        }
        Console.WriteLine("\n");

        // CASE
        Console.WriteLine("### CASE ###");
        Console.Write("Informe um numero 1 - 7 para semana: ");
        dia = Convert.ToInt32(Console.ReadLine());

        switch (dia)
        {

            case 1:
                Console.WriteLine("Domingo");
                break;

            case 2:
                Console.WriteLine("Segunda");
                break;

            case 3:
                Console.WriteLine("Terça");
                break;

            case 4:
                Console.WriteLine("Quarta");
                break;

            case 5:
                Console.WriteLine("Quinta");
                break;

            case 6:
                Console.WriteLine("Sexta");
                break;

            case 7:
                Console.WriteLine("Sabado");
                break;

            default:
                Console.WriteLine("Valor nao existente");
                break;
        }
        Console.WriteLine("\n");

        // REPEAT
        Console.WriteLine("### REPEAT ###");
        Console.WriteLine("Não tem REPEAT");
        Console.WriteLine("\n");

        // DO WHILE
        Console.WriteLine("### DO WHILE ###\n");
        do
        {
            Console.WriteLine(a);
            a = a + 1;
        } while (a < 10);
        Console.WriteLine("\n");

        // WHILE
        Console.WriteLine("### WHILE ###");
        while (b < 10)
        {
            Console.WriteLine(b);
            b = b + 1;
        }
        Console.WriteLine("\n");

        // FOR
        Console.WriteLine("### FOR ###");
        for (c = 0; c < 10; c++)
        {
            Console.WriteLine(c);
        }
        Console.WriteLine("\n");


        // ARRAY
        Console.WriteLine("### ARRAY ###");
        int[] numbers = { 10, 20, 30, 40 };

        for (int i = 0; i < 4; i++)
        {
            Console.WriteLine(numbers[i]);
        }
        Console.WriteLine();

        // MATRIZ
        Console.WriteLine("### MATRIZ ###");
        int[,] matriz = new int[3, 3]; // Declaração de uma matriz 3x3 de inteiros

        // Inicialização da matriz
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                matriz[i, j] = i * 3 + j + 1;
            }
        }

        // Acesso aos elementos da matriz
        Console.WriteLine("Elementos da matriz:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(matriz[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
  

        // FUNCAO
        Console.WriteLine("### FUNCAO ###");
        Console.Write("Digite o valor 1: ");
        m = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite o valor 2: ");
        n = Convert.ToInt32(Console.ReadLine());
      
        int resultado = soma(m, n);
        Console.WriteLine($"A soma de {m} e {n} é igual a {resultado}.");

        Console.WriteLine("\n");

        // PROCEDURE
        Console.WriteLine("### PROCEDURE ###");
        Console.WriteLine("Não tem PROCEDURE");
        Console.WriteLine("\n");

        // PONTEIRO
        Console.WriteLine("### PONTEIRO ###\n");
        Console.WriteLine("Não tem PONTEIRO \n");
        Console.WriteLine(" Não é necessário liberar memória manualmente, como em C ou C++. A variável será automaticamente coletada pelo coletor de lixo quando não estiver mais em uso. \n");
        Console.WriteLine("\n");

        // TRY
        Console.WriteLine("### TRY ###\n");
        Console.Write("Informe o valor 1 para o dividendo: ");
        numero1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Informe o valor 2 para o divisor: ");
        numero2 = Convert.ToInt32(Console.ReadLine());

        try {
            if (numero2 == 0) {
                throw new Exception("Divisão por zero não é permitida!");
            }
            res = numero1 / numero2;
            Console.WriteLine("Resultado da divisão: " + res.ToString("0.00"));
        } catch (Exception ex) {
            Console.WriteLine("Ocorreu uma exceção: " + ex.Message);
        }
       Console.WriteLine("\n");
      
        // ENUM
        Console.WriteLine("### ENUM ###\n");
        Cor minhaCor = Cor.Azul;

        switch (minhaCor) {
            case Cor.Vermelho:
                Console.WriteLine("Minha cor favorita é vermelho.");
                break;
            case Cor.Verde:
                Console.WriteLine("Minha cor favorita é verde.");
                break;
            case Cor.Azul:
                Console.WriteLine("Minha cor favorita é azul.");
                break;
            case Cor.Amarelo:
                Console.WriteLine("Minha cor favorita é amarelo.");
                break;
            case Cor.Laranja:
                Console.WriteLine("Minha cor favorita é laranja.");
                break;
            default:
                Console.WriteLine("Eu não tenho uma cor favorita.");
                break;
        }

    }
    static int soma(int a, int b)
    {
        return a + b;
    }
}
