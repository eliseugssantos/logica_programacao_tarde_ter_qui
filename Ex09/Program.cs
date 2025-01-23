// Descrição: Crie um programa que gera a tabuada de um número escolhido pelo usuário.
// Do while

Console.WriteLine("Digete um número para ver a tabuada");
int numero = Convert.ToInt32(Console.ReadLine());
int contador = 1;

do
{
    Console.WriteLine($"{numero} x {contador} = {numero * contador}");
    contador +=2;
} 
while (contador <= 10);
