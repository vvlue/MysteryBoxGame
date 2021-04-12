using System;
using System.Collections.Generic;
using System.Text;

namespace MysteryBoxGame
{
    public class BoxClass
    {

        private List<int> bronze = new List<int> { 1, 2, 3 };
        private List<int> silver = new List<int> { 2, 4, 6 };
        private List<int> gold = new List<int> { 5, 10, 15 };

        private int value; 

        public BoxClass(int type)
        {
            Random randint = new Random();
            if (type == 1)
              {
                
                int index = randint.Next(0, 2);
                value = bronze[index];
            }
            else if (type == 2)
            {
                int index = randint.Next(0, 2);
                value = silver[index];
            }
            else
            {
                int index = randint.Next(0, 2);
                value = gold[index];
            }

        }

        //

        public int GetValue()
        {
            return value;
        }
    
    }
}
