using System;

namespace WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada PIN kood
            //programm võrdleb sisestatud PIN koodi arvuga 1234
            //kui sisestatud PIN kood on 1234
            //programm kuvab konsoolis "Tere tulemast!"
            //kui sisestatud PIN kood on vale, programm kuvab konsoolis
            //"Vale PIN. Proovi uuesti"
            //katsete arv on piiramatu

            //boolean --> true/false
            bool loopActive = true;

            while (loopActive)
            {
                Console.WriteLine("Sisesta PIN:");
                int userPIN = Convert.ToInt32(Console.ReadLine());

                if(userPIN == 1234)
                {
                    Console.WriteLine("Tere tulemast!");
                    loopActive = false;
                }

            }

            Console.WriteLine("Kena päeva!");
        }
    }
}
