using System;

namespace ProgramArhitecture {

    public class Boiler_Heater : Heater {

        public Boiler_Heater(string color)
            : base(color) {

        }

        public override void Heat() {
            Console.WriteLine("Boiler started heating!");
            base.Heat();
        }
    }
}
