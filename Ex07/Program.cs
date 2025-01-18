// Desenvolva um programa em C# que calcule a média de um aluno a partir de três notas fornecidas pelo usuário



using System.ComponentModel.Design;

Console.WriteLine("Digite a 1° nota:");
double nota1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite a 2° nota:");
double nota2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite a 3° nota:");
double nota3 = Convert.ToDouble(Console.ReadLine());

double media = (nota1 + nota2 + nota3) / 3;

Console.WriteLine($"Média: {media}");

if (media >= 7)
{
    Console.WriteLine("Aprovado");
}

else if (media >= 4)
{
    Console.WriteLine("Recuperaçao");
}
else
{
    Console.WriteLine("Reprovado");
}
