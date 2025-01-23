/* escreva um programa que pergunte o nome do usuario, em seguida , sobrenome do usuario e apresente na tela o nome completo do usuario
 */
Console.WriteLine("digite seu nome: ");
string nome = Console.ReadLine();

Console.WriteLine("Digite seu sobrenome: ");
string sobrenome = Console.ReadLine();

Console.WriteLine($"O nome completo é: {nome} {sobrenome}");
