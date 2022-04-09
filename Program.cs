using System;

namespace Count
{
    class Program
    {
        static void Main()
        {
            //Console.Title = "Examples of loops";

            //increment
           // Console.Write("Count 0 to 9");
           // for (int i = 0; i < 10; i++) 
            {
               // Console.WriteLine(i);
            }

            //decrement
           // Console.WriteLine("Count down 9 to 0");
           // for (int j = 9; j > -1; j--) 
            {
               // Console.WriteLine(j);
            }
            /*Console.Title = "Write Each Element in Array";
            string[] items = {
                "banana",
                "orange",
                "avocado",
                "pretzels",
                "lemon",
                "pecans"
            };

            foreach (string element in items)
            {
                Console.WriteLine(element);
            }
            Console.ReadLine();*/

            /* int bearsNeeded = 6;
             int bearsTotal = 0;

             Console.WriteLine("A while loop. Total bears: " + bearsTotal);
             while(bearsTotal<bearsNeeded)
             {
                 MakeBear();
                 bearsTotal++;
             }

             Console.WriteLine("A do while Loop. Total bears: " + bearsTotal);
             do
             {
                 MakeBear();
                 bearsTotal++;
             } while (bearsTotal < bearsNeeded);

             Console.WriteLine("A for loop");
             int total = 2;
             for (int i = 0; i < total; i++)
             {
                 MakeBear();
             }
             Console.ReadLine();*/
            for (int currentBears = 10; currentBears > 1; currentBears--)
            {
                Console.WriteLine(currentBears + " bears in the bed and the little one said \"I'm crowded... roll over...\"");
                Console.WriteLine("So they all rolled over and one fell out...\n");
            }
            Console.WriteLine("One little bear in the bed and the liitle one said \"I'm lonely\"");
            MakeBear();
        }
        static void MakeBear()
        {
            string bear = @"
         {''-''}
          (o o)
        ,--`Y'--.
        ``:   ;''
          / _ \
         ()' `()
        ";
            Console.WriteLine(bear);
        }
    }

    
}
