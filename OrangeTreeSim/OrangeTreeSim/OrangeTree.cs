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

        public void SetAge(int age)
        {
            this.age = age;
            
        }
        public int GetAge()
        {            
            return age; 
        }
        public void SetHeight(int height)
        {
            this.height = height;
            
        }
        public int GetHeight()
        { 
            return height;
        }
        public void SetTreeAlive(bool treeAlive)
        {
            this.treeAlive = treeAlive;            
            
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
            
            age++;            
           
            
           if (age < 80)
           {                  
               numOranges = (age * 5) - 5;
               height += 2;
           }
           else if (age >= 80)
           {
               treeAlive = false;
               numOranges = 0;
               height += 0;
           }

           orangesEaten = 0;

        }


        public void EatOrange(int count)
        {
            //denne operation simulerer, at der spises det antal appelsiner, der er angivet i count-parameteren
            //fra årets høst, hvis der altså er så mange appelsiner tilbage på træet (orangesEaten-feltet)
            int canEat = Math.Min(count, numOranges);
            numOranges -= canEat;
            orangesEaten += canEat;
            

            
        }
    }
}
