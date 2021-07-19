using System;
namespace ProgramArhitecture {

    public class Plate_Sensor: Sensor {

        public Plate_Sensor() : base() { }

        public override void SensorOn() {

            Console.WriteLine("Sensor detects valve must be turned on!");
            base.SensorOn();

        }

    }
}
