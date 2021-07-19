using System;

namespace ProgramArhitecture {

    public class Water_Sensor: Sensor {

        public Water_Sensor() : base() { }

        public override void SensorOn() {

            base.SensorOn();
            Console.WriteLine("Sensor detects too little water!");
        }
    }
}
