using System;

namespace ProgramArhitecture {

    public class FilterReceptacle {

        //add coffee / change filter etc
        //tipuri de cafea etc
        public string CoffeeType { get; set; }
        public int Filter { get; set; }


        public FilterReceptacle() {
            Filter = 0;
        }

        public void DecreaseFilterHealth() {
            Filter++;
        }

        public void ChangeFilter() {
            Filter = 0;
            Console.WriteLine("Filter was changed");
        }

        public void ChooseCoffee(string coffeeType) {
            CoffeeType = coffeeType;
            Console.WriteLine("One capsule of: " + CoffeeType + " inserted");
        }


    }
}
