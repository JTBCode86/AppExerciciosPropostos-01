using System;

namespace AppExerciciosPropostos_01
{
    /// <summary>
    /// Exercícios propostos - Estrutura While.
    /// Escreva um programa que repita a leitura de uma senha até que ela seja válida. Para cada leitura de senha 
    /// incorreta informada, escrever a mensagem "Senha Invalida". Quando a senha for informada corretamente deve ser 
    /// impressa a mensagem "Acesso Permitido" e o algoritmo encerrado. Considere que a senha correta é o valor 2002.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a sua senha: ");
            int senha = int.Parse(Console.ReadLine());

            while (senha != 2002)
            {
                Console.WriteLine("Senha invalida!");
                senha = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Acesso Permitido!");
            Console.ReadLine();
        }
    }
}
