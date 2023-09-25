using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    internal class Program
    { 
        
    
        static int health;
        static int damage;
    

    
        

        static void Main(string[] args)
        {
            Console.WriteLine("conditionals");
            Console.WriteLine("---------");
            Console.WriteLine("");
            // intialisations

            health = 100;
            damage = 10;

           

       
                // sample gameplay
            ShowHUD();
            TakeDamage(10);
            ShowHUD();
      

            Console.WriteLine("");
            Console.WriteLine("press any key to exit");
            Console.ReadKey(true);
        }
        static void TakeDamage(int v)
        {
            Console.WriteLine("player took" + " " + damage + " " + "damage");
            health = health - damage;
        }

        static void ShowHUD()
        {
            Console.WriteLine("player health" + " " + health);
        }
    }   
}
