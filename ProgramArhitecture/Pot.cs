using System;

namespace ProgramArhitecture {

    public class Pot {

        public string Color { get; set; }
        public double Capacity { get; set; }//in liters
        public bool PotAdded { get; set; }

        public Pot(string color,double capacity) {

            Color = color;
            Capacity = capacity;
            PotAdded = false;

        }

        public void AddPot() {
            PotAdded = true;
            Console.WriteLine("*POT ADDED*");
        }

        public void RemovePot() {
            PotAdded = false;
            Console.WriteLine("*POT REMOVED*");
        }

    }
}
