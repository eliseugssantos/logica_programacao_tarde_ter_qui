// Ex - 11 - Crie um programa que peça ao usuário para inserir um número inteiro positivo e então conte de 1 até
// esse número, exibindo cada número. O programa deve implementar essa contagem usando while,do while e for.



Console.WriteLine("Insira um numero inteiro positivo");
int numero = int.Parse(Console.ReadLine());

int contador = 1;

while (contador <= numero)
{
    Console.WriteLine(contador);
    contador++;
}