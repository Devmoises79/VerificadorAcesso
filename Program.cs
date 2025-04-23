using System;

class Program 
{
    static void Main()
    {

    Console.Write("Digite seu nome:  "); //pede o nome
    string nome = Console.ReadLine(); // recebe o nome

    Console.Write("Digite sua idade:  "); // pede a idade
    int idade = int.Parse(Console.ReadLine()); // recebe a idade

    bool nomeNaLista = nome == "Joao" || nome == "Maria" || nome == "Pedro"; //verifica o acesso

    if (nomeNaLista && idade >= 18) // verifica se pode entrar
    {
        Console.WriteLine("Pode entrar!"); // acesso permitido
    }
    else
    {
        Console.WriteLine("Não pode entrar!");// acesso negado

    }

    }
}


