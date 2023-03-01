using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeTreeSim
{
    public class OrangeTree
    {
        private int age;
        private int height;
        private bool treeAlive;
        private int numOranges;
        private int orangesEaten;

        public int SetAge(int age)
        {
            this.age = age;
            return age;
        }
        public int GetAge()
        {            
            return age; 
        }
        public int SetHeight(int height)
        {
            this.height = height;
            return height;
        }
        public int GetHeight()
        { 
            return height;
        }
        public bool SetTreeAlive(bool treeAlive)
        {
            this.treeAlive = treeAlive;            
            return treeAlive;  
        }       
        public bool GetTreeAlive()
        {
            return treeAlive;
        }
        public int GetNumOranges()
        { 
            return numOranges; 
        }
        public int GetOrangesEaten()
        { 
            return orangesEaten; 
        }
        public void OneYearPasses()
        {
            treeAlive = true;
            //ligger 1 til alder
            age++;
            

            // Træet højde øges med 2, hvis træets alder er under 80, ellers ikke (height-feltet)         
            height += 2;

            //Træet er i live, hvis træets alder er under 80, ellers dødt (treeAlive)
            if (treeAlive == true)
            {
                if (age < 80)
                {
                   
                    numOranges = (age * 5) - 5;
                }

                else if ( age >= 80)
                {
                    treeAlive = false;
                    numOranges += 0;
                    
                }
            }


            //denne kalder EatOranges() som holder styr på hvor mange appelsiner der er blevet spist
            EatOrange(numOranges);

        }

        public int EatOrange(int count)
        {
            //denne operation simulerer, at der spises det antal appelsiner, der er angivet i count-parameteren
            //fra årets høst, hvis der altså er så mange appelsiner tilbage på træet (orangesEaten-feltet)
            
                return count;

            
        }
    }
}
