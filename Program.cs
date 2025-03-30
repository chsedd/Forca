using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("--- Forca ---");
        
        Console.Write("Qual a palavra secreta? ");
        string palavraSecreta = Console.ReadLine().ToLower();
        
        Console.Write("Qual a letra? ");
        char letra = Char.ToLower(Console.ReadKey().KeyChar);
        
        bool existe = palavraSecreta.Contains(letra);
        
        if (existe)
        {
            Console.WriteLine("\nA letra \"" + letra + "\" existe na palavra secreta => True");
        }
        else
        {
            Console.WriteLine("\nA letra \"" + letra + "\" não existe na palavra secreta => False");
        }
    }
}