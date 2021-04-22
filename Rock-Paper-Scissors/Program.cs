using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors
{
    class Program
    {
        static void Main(string[] args)
        {

            Random random=new Random();
            string[] array = new String[3]
            {
                "Paper", "Scissors", "Rock"
            };

            PlayerA playerA=new PlayerA
            {
                Strategy = "Paper",WinPoints = 0,DrawPoints = 0
            };

            PlayerB playerB=new PlayerB
            {
                WinPoints = 0,
                DrawPoints = 0
            };

            for (int i = 0; i < 100; i++)
            {
              int sayi= random.Next(3);
              playerB.Strategy = array[sayi];
              

                if (playerB.Strategy=="Paper")
                {
                    playerA.DrawPoints = playerA.DrawPoints+1;
                    playerB.DrawPoints = playerB.DrawPoints+1;
                    
                }

                else if (playerB.Strategy=="Scissors")
                {
                    playerB.WinPoints = playerB.WinPoints + 1;
                    
                }
                
                else if (playerB.Strategy=="Rock")
                {
                    playerA.WinPoints = playerA.WinPoints + 1;
                   
                }
            }


            Console.WriteLine("Player A wins {0} of 100 games", playerA.WinPoints);
            Console.WriteLine("Player A wins {0} of 100 games", playerB.WinPoints);
            Console.WriteLine("Tie: {0} of 100 games", playerA.DrawPoints);
            Console.ReadLine();

        }
    }
}
