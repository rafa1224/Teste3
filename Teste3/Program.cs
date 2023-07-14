using System;
using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        float nota1, nota2, media;
        String Nome;


        while (true)
        {
            Console.WriteLine("informe o nome do aluno");
            Nome = Console.ReadLine();

            Console.WriteLine("qual foi a nota do primeiro semestre do aluno {0}?", Nome);
            nota1 = float.Parse(Console.ReadLine());

            Console.WriteLine("qual foi a nota do segundo semestre do aluno {0}?", Nome);
            nota2 = float.Parse(Console.ReadLine());

            media = (nota1 + nota2) / 2;

            Console.WriteLine("Nome do aluno: {0}", Nome);

            Console.WriteLine("Média: {0}", media);

            if (media  >= 6.5) { Console.WriteLine("Aluno aprovado"); }

            else { Console.WriteLine("Aluno reprovado"); }
        }
    }
}