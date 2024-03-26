using System;

class Program
{
    // Exercício 1
    static void Exercicio1()
    {
        int INDICE = 13, SOMA = 0, K = 0;

        while (K < INDICE)
        {
            K = K + 1;
            SOMA = SOMA + K;
        }

        Console.WriteLine("Exercício 1: \n\nO valor da variável SOMA é = " + SOMA);
    }

    // Exercício 2
    static void Exercicio2()
    {
        Console.WriteLine("Exercício 2: \n");

        bool VerificaFibonacci(int numero)
        {
            int a = 0, b = 1;
            while (a < numero)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return a == numero;
        }

        bool continuar = true;
        while (continuar)
        {
            Console.Write("Informe um número para verificar se pertence à sequência de Fibonacci: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            if (VerificaFibonacci(numero))
            {
                Console.WriteLine($"O número {numero} pertence à sequência de Fibonacci.");
            }
            else
            {
                Console.WriteLine($"O número {numero} não pertence à sequência de Fibonacci.");
            }

            Console.Write("Deseja informar um novo número? (s/n): ");
            string resposta = Console.ReadLine();
            continuar = (resposta.ToLower() == "s");
        }
    }

    // Exercício 5
    static void Exercicio5()
    {
        Console.WriteLine("Exercício 5: \n");

        string stringOriginal = "Target Sistemas";

        while (stringOriginal.ToLower() != "sair")
        {
            string stringInvertida = InverterString(stringOriginal);

            Console.WriteLine("String original: " + stringOriginal);
            Console.WriteLine("String invertida: " + stringInvertida);

            Console.Write("\nInforme uma nova string para inverter ou digite 'sair' para finalizar: ");
            stringOriginal = Console.ReadLine();
        }
    }

    static string InverterString(string entrada)
    {
        char[] caracteres = entrada.ToCharArray();
        int comprimento = caracteres.Length;

        for (int i = 0; i < comprimento / 2; i++)
        {
            char temp = caracteres[i];
            caracteres[i] = caracteres[comprimento - i - 1];
            caracteres[comprimento - i - 1] = temp;
        }

        return new string(caracteres);
    }

    static void Main(string[] args)
    {
        Exercicio1();
        Console.WriteLine("\n--------------------------------------------------------------------------\n");
        Exercicio2();
        Console.WriteLine("\n--------------------------------------------------------------------------\n");
        Exercicio5();
    }
}
