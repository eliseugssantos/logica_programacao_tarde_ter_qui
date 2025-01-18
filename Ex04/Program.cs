//Escrev um programa que pergunte o nome do usuário e apresente nome + boas vindas

Console.WriteLine("Qual é o seu nome?");
string nome = Console.ReadLine();

Console.WriteLine("Qual é´o seu sobrenome?");
string sobrenome = Console.ReadLine();

Console.WriteLine("Qual é o seu último sobrenome?");
string ultimoSobrenome = Console.ReadLine();

//Console.WriteLine("Seja bem-vindo(a) " + nome + sobrenome + ultimoSobrenome );
Console.WriteLine($"seja bem-vindo(a) {nome} {sobrenome} {ultimoSobrenome} ");


Console.WriteLine("Seja Bem-Vindo(a)" + nome);