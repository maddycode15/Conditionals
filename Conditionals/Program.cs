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

            health = 70;
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

            if (health ==100) 
            {
                Console.WriteLine("perfect health");
            }

            if ((health >=76 && health <=99))
            {
                Console.WriteLine("healthy");
            }

            if ((health >=51 && health <=76)) ;

        } //   >greator than        <less than
    }   
}
