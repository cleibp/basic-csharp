using System;

class Program
{
    public static void Main(string[] args)
    {


        string nome = "Cleiton";
        int idade = 20;
        char sexo = 'M';
        double peso = 70.5;
        bool ativo = true;

        int val1, val2, soma, subtracao, multiplicacao, divisao, modulo;

        int idadeTernario;
        string idadeTer;

        int idadeIF;

        int dia;

        int a = 0;

        int b = 0;

        int c = 0;

        // int m = 0;
        // int n = 0;

        // Constante
        const double PI = 3.14159265;

        // Comentário de uma linha

        /* Comentário
        de varias linhas */

        // Escrever na tela
        Console.WriteLine("#### Escrever na tela ####");
        Console.WriteLine("Olá Mundo");
        Console.WriteLine("");

        // VARIÁVEIS
        Console.WriteLine("### VARIÁVEIS ###");
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

        soma = val1 + val2; // Pode usar: (+, -, *, /, %)
        subtracao = val1 - val2;
        multiplicacao = val1 * val2;
        divisao = val1 / val2;
        modulo = val1 % val2;
        Console.WriteLine("Soma: " + soma);
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



    }
}
