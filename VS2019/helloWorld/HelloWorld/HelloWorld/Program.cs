using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            char tab = '\t';
            char backSpace = '\b';
            String name="";
            Console.WriteLine("Hei maailma!");
            Console.WriteLine("Minä olen Anh");
            String message = "Minä olen ";
            int age = 39;
            Console.WriteLine(tab + message +  backSpace + age + "-voutias.");
            Console.Write("Mika sun nimi on? ");
            name = Console.ReadLine();
            while (name == "")
            {
                Console.Write("Voitko ystävällisesti kirjoittaa nimesi uudelleen? ");
                name = Console.ReadLine();
                if (name!= "")
                {
                    Console.WriteLine("Moi " + name);
                    break;
                }
            }
            
                
            

        }
    }
}
