using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMaker
{
    class CoffeeMakerApp
    {
        public bool onState;
        public void StartCoffeemaker()
        {
            if (onState == true)
                Console.WriteLine("The coffeMaker is already on");
            else
                onState = true;
                Console.WriteLine("The coffeMaker is now on");
        }
        static void Main(string[] args)
        {
            CoffeeMakerApp st = new CoffeeMakerApp();
            st.onState = true;
            st.StartCoffeemaker();
        }
    }
}
