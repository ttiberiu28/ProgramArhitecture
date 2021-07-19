using System;

namespace ProgramArhitecture {

    public class IndicatorLight {

        public bool Activated { get; set; }

        public IndicatorLight() {
            Activated = false;
        }

        public void TurnOn() {
            Console.WriteLine("*LIGHT ON*");
            Activated = true;
        }

        public void TurnOff() {
            Console.WriteLine("*LIGHT OFF*");
            Activated = false;
        }

    }
}
