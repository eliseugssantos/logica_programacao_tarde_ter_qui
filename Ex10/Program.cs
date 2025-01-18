//Descriçao: Crie um programa que gera a tabuada de um número escolhido pelo usuário.
//For


Console.WriteLine("Digite um número para ver a tabuada");
int numero = Convert.ToInt32(Console.ReadLine());

for (int contador = 1; contador <= 10; contador++) 
{
    Console.WriteLine($"{numero} x{contador} = {numero * contador}");
}

   
