/*
Desafio: Criar um programa que receba 6 nome utilizando arrays. Ao final o programa deve exibir todos os nome digitados
*/

string[] nome = new string[6];
for (int i = 0; i < nome.Length; i++)
{
    Console.WriteLine($"Digite os nomes {i + 1}");
    nome [i] = Console.ReadLine();


}
Console.WriteLine("\n os nomes digitados sao:");
for (int i = 0; i < 6; i++)
{
    Console.WriteLine(nome[i]);

}
