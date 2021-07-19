using System;

namespace ProgramArhitecture {

    public class Boiler {

        public double WaterLevel { get; set; }//liters
        public double RefillTank { get; set; }//liters
        public bool PressureValveOn { get; set; }//open or close

        public Boiler(double waterLevel) {

            WaterLevel = waterLevel;
            RefillTank = waterLevel;

            PressureValveOn = false;// off
        }
           
        public void DecreaseWaterLevel(Pot p, Water_Sensor ws, IndicatorLight Il, Plate_Sensor ps) {

            if(WaterLevel <= p.Capacity) {

                ws.SensorOn();
                ps.SensorOn();
            
                Console.WriteLine("Pressure valve is automatically turned on," +
                    " please refill, your water level is: " + WaterLevel);

            } else {
                WaterLevel -= p.Capacity;
                Console.WriteLine("*POURING WATER*");
                Il.TurnOff();
                Console.WriteLine("Your water level is: " + WaterLevel);
            }


        }

        public void AddWater() {
            WaterLevel = RefillTank;
            Console.WriteLine("Water tank was refilled: " + WaterLevel + "L");
        }

    }
}
