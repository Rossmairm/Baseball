using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baseball
{
    class Simulator
    {
         //  int bases = 0;


       bool[] bases = new bool[3];
       int[] inning = new int[18];


        private int inningHalf = 1;
    
        private int outs = 0;




        Random rand = new Random();

        public int hitOrStrike()
        {
            int hit;
            int strike = 0;
            while (strike < 3) // continues trying to hit until strike out
            {

                hit = rand.Next(0, 4); // determines if there is a hit
                if (hit != 1)
                {
                    System.Console.WriteLine("Swing #" + (strike + 1) + " YOU WHIFFED, KID...");
                    strike++;

                }
                else
                {
                    System.Console.WriteLine("Swing #" + (strike + 1) + " YOU HIT THE BALL WOO");
                    return 1;
                }
            }

            outs++;
            if (outs == 3)
            {
               // bases = 0;
                inningHalf++;
                System.Console.WriteLine("SWITCH SIDE YO");
                outs = 0;
                if (inningHalf == 18)
                {
                   return 2;
                }
            }
            return 0;
        }


   /*  public void Running()
        {
            int hit = rand.Next(1, 4); //determines how far hitter ran

            while (hit > 0)
            {
                bases = bases << 1;
                bases = bases + 1;


                if (inningHalf > 17)
                {
                    break;
                }
                else
                {
                    if ((bases & 8) > 0)
                    {
                        inning[inningHalf]++;
                        bases = bases & 7;
                    }
                    hit--;
                }
            }
        }


        */
       public void Running()
        {
              int hit = rand.Next(1, 5); //determines how far hitter ran
                

            for (int i = 2; i >= 0; i--)
            {
                
                
            
                  if (bases[i] == true)
                    {
                        bases[i] = false;

                        if (i + hit >= 3)
                        {
                            
                            inning[inningHalf]++;
                            Console.WriteLine("run  " + inning[inningHalf]);
                            

                        }
                        else
                            bases[i + hit] = true;
                  }
                
              }
            if (hit == 4)
            {
                inning[inningHalf]++;
            }
            else
                bases[hit - 1] =  true; 
         }
       

        
       
        

        public int checkInning()
        {

            return inningHalf / 2;

        }

        public int[] getScores()
        {
            return inning;

        }


    }


}

