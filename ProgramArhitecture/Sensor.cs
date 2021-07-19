using System;

namespace ProgramArhitecture {

    public abstract class Sensor {

        public bool Activated { get; set; }


        public Sensor() { Activated = false;}

        public virtual void SensorOn() {

            Activated = true;
        }
    }
}
