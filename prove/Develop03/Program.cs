using System;

class Program
{
    static void Main(string[] args)
    {

        bool start = true;
        
        Console.WriteLine("Welcome to the Scripture Memorization Program! This program will help you memorize scriptures.");
        Scripture scripture = new Scripture();
        Reference reference= new Reference();
        Word words = new Word();
        reference.DisplayFullReference();
        words.isHidden = false;
        words.DisplayWords();
        Console.WriteLine("Press enter key to hide words, type 'quit' to exit.");
        string action = Console.ReadLine();

        while (start == true)
        {
            Console.Clear();
            words.DisplayHidden();
            Console.WriteLine("Press enter key to hide words, type 'quit' to exit.");
            action = Console.ReadLine();
            if (action != "quit" && words.isHidden == false)
            {
                start= true;
            }
            else if (action != "quit" && words.isHidden == true)
            {
                Console.WriteLine("Good job, you have memorized the verse!");
                start = false;
                break;
            }
            else 
            {
                start = false;
                break;
            }
        }

        
    }
}