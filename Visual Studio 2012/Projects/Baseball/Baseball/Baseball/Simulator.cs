using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baseball
{
    class Simulator
    {
       private int bases = 0;


        // bool[] bases = new bool[4];
        int[] inning = new int[18];


        private int inningHalf = 1;
    
        private int outs = 0;




        Random rand = new Random();

        public bool hitOrStrike()
        {
            bool hit;
            int strike = 0;
            while (strike < 3) // continues trying to hit until strike out
            {

                hit = rand.Next(0, 4) == 1; // determines if there is a hit
                if (!hit)
                {
                    strike++;

                }
                else
                {
                  
                    return true;
                }
            }

            outs++;
            if (outs == 3)
            {
                bases = 0;
                inningHalf++;
               
                outs = 0;
            }
            return false;
        }


        public void Running()
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



        /*public void Running()
        {
              

            for (int i = 3; i > 0; i--)
            {
                int hit = rand.Next(0, 5); //determines how far hitter ran
                
                
                if (hit == 0)
                {
                    outs++;

                }
                else
                {
                    if (bases[i] == true)
                    {
                        bases[i] = false;

                        if (i + hit > 3)
                        {
                            
                            inning[inningHalf]++;
                            System.Windows.Forms.MessageBox.Show("run  " + inning[inningHalf]);
                            

                        }
                        else
                            bases[i + hit] = true;
                    }
                    else
                        continue;

                }
            }
            if (outs != 3)
                hitOrStrike();


        }
        */


        public int checkInning()
        {

            return inningHalf / 2;

        }
        public void reset()
        {   
            inningHalf = 0;
            outs = 0;
            bases = 0;

            
            
            for (int i = inning.Length; i > 0; i--)
            {
               inning[i-1]= 0;
               
            }
        


        }

        public int[] getScores()
        {
            return inning;

        }


    }


}

