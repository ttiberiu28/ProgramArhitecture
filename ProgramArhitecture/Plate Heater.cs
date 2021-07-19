using System;

namespace ProgramArhitecture {

    public class Plate_Heater: Heater {

        public Plate_Heater(string color)
            : base(color) {

        }

        public override void Heat() {

            Console.WriteLine("Pot started re-heating!");
            base.Heat();
        }

    }
}
