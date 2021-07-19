using System;

namespace ProgramArhitecture {

    public abstract class Heater {

        public double Temperature { get; set; }
        public string Color { get; set; }


        public Heater(string color) {
            Temperature = 0;
            Color = color;
        }

        public virtual void Heat() {

            int count = 0;

            while(Temperature < 100) {
 
                Console.WriteLine(10 - count + " seconds remaining");
                count++;
                Temperature += 10;
            }

            Console.WriteLine("Heating finished");
        }

    }
}
