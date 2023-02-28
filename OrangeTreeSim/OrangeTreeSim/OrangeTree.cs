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

            //ligger 1 til alder
            age++;
            // Træet højde øges med 2, hvis træets alder er under 80, ellers ikke (height-feltet)
            //Træet er i live, hvis træets alder er under 80, ellers dødt (treeAlive)
            if (age > 80) 
            {
                height += 2;
                treeAlive = true;
            }
            else
            {
                treeAlive= false;
                numOranges = 0;

            }
            /*Træet giver ikke frugt første år, men derefter øges dets produktion med 5 appelsiner for hvert år
             * (dvs. 5 appelsiner 2. år, 10 appelsiner det 3. år, 15 appelsiner det 4. år osv.)
              Frugt fra forrige år føres ikke med over til et nyt år (numOranges-feltet)*/
            if (age == 1)
            {
                numOranges = 0;
            }
            else
            {
                numOranges = (age * 5) - 5;
            }
            
            EatOrange(numOranges);
            
        }

        public int EatOrange(int count)
        {
            count = 0;
            return count;
        }
    }
}
