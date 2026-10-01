using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture scripture = new Scripture("And my father dwelt in a tent", "1 Nephi", 2, 15);

        Console.WriteLine(scripture.ScriptureString());
    }
}