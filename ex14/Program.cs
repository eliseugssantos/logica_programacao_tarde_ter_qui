/*
Objetivo: Criar um array que armazene 5 nomes de frutas e, em seguida, imprimir cada nome na tela.
 
Instruções:
- Crie um array de strings para armazenar os nomes das frutas.
- Preencha o array com 5 frutas diferentes.
- Use um loop para iterar sobre o array e imprimir cada fruta.
*/


/*string[] frutas = new string[5];

frutas[0] = "Maça";
frutas[1] = "tomate";
frutas[2] = "laranja";
frutas[3] = "uva";
frutas[4] = "Goiaba";

for (int i = 0; i < frutas.Length; i++)
{
    Console.WriteLine($"Fruta na posição {i}:{frutas [i]}");

}*/


string[] frutas = new string[5];
for (int i = 0; i < frutas.Length; i++)
{
    Console.WriteLine($"Digite o nome das frutas {i + 1}");
    frutas[i] = Console.ReadLine();


}  
    
    
    Console.Clear();


//for (int i = 0; i < frutas.Length; i++)
//{
  //  Console.WriteLine($"Fruta na posição {i}:{frutas [i]}");

//}
Console.WriteLine("===========================");
Console.WriteLine("=====Frutas Digitadas======");
Console.WriteLine("===========================");
int index = 0;


foreach (string fruta in frutas) 
{
    Console.WriteLine($"Fruta na posiçao {index}: {frutas}");

}


