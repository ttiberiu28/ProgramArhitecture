using System;

namespace ProgramArhitecture {

    public class Expressor {

        public string PotColor { get; set; }
        public double TankCapacity { get; set; }
        public double PotCapacity { get; set; }

        public Boiler Boiler { get; set; }
        public Pot Pot { get; set; }

        public Boiler_Heater BH { get; set; }
        public Plate_Heater PH { get; set; }

        public Water_Sensor WS { get; set; }
        public Plate_Sensor PS { get; set; }

        public IndicatorLight IL { get; set; }
        public StartButton SB { get; set; }

        public FilterReceptacle FR { get; set; }
        public Delivery_Pipe DP { get; set; }

        public Expressor(string potColor, double tankCapacity, double potCapacity) {

            PotColor = potColor;
            TankCapacity = tankCapacity;
            PotCapacity = potCapacity;

            Boiler =  new Boiler(TankCapacity);
            Pot = new Pot(PotColor,PotCapacity);

            BH = new Boiler_Heater("dark grey");
            PH = new Plate_Heater("light grey");

            WS = new Water_Sensor();
            PS = new Plate_Sensor();

            IL = new IndicatorLight();
            SB = new StartButton(0);

            FR = new FilterReceptacle();
            DP = new Delivery_Pipe(0.5, "aluminium");
        }

        //number e numarul ales de user de apasari pe buton
        public void PressButton(int number) {
            SB = new StartButton(number);
        }

        public void AddPot() {
            if(Pot.PotAdded == true) {
                Console.WriteLine("Pot already added");
            } else {
                Pot.AddPot();
            }
            
        }

        public void RemovePot() {
            if(Pot.PotAdded == true) {
                Pot.RemovePot();
            } else {
                Console.WriteLine("You must add pot before removing it!");
            }
            
        }

        public void Heat() {
            if(SB.TimesPressed == 1) {//one time press for heating the boiler
                BH.Heat();
            }else if(SB.TimesPressed == 2) {

                if(Pot.PotAdded == true) {
                    PH.Heat();//two times press for heating the pot
                } else {
                    Console.WriteLine("Please add pot first before re-heating it");
                }
            }
        }

        public void PourWater() {
            if(Pot.PotAdded == true) {

                if(DP.DeliveryPipeHealth < 12) {
                    DP.DecreaseDPHealth();
                }else {
                    Console.WriteLine("WARNING: It is recommended to clean delivery pipe:" );
                    DP.DecreaseDPHealth();
                }

                if(FR.Filter < 7) {

                    IL.TurnOn();
                    Boiler.DecreaseWaterLevel(Pot,WS,IL,PS);
                    FR.DecreaseFilterHealth();
                } else {

                    Console.WriteLine("Filter must be changed!");
                }

            } else {

                Console.WriteLine("Please add pot first before trying to poor water!");
            }
        }

        public void RefillTank() {
            if(Boiler.WaterLevel == Boiler.RefillTank) {
                Console.WriteLine("Water tank is at MAX capacity");
            } else {
                Boiler.AddWater();
            }
            
        }

        public void ChangeFilter() {
            if(FR.Filter != 0) {
                FR.ChangeFilter();
            } else {
                Console.WriteLine("Filter was never used before!");
            }
           
        }

        public void ChooseCoffee(int number) {
            if(number == 1) {
                FR.ChooseCoffee("Latte");
            } else if(number == 2) {
                FR.ChooseCoffee("Cappuccino");
            } else if(number == 3) {
                FR.ChooseCoffee("Americano");
            }else if(number == 4) {
                FR.ChooseCoffee("Expresso");     
            }else if(number == 5) {
                FR.ChooseCoffee("Black Tea");
            }       
        }

        public void CleanDeliveryPipe() {
            DP.CleanDeliveryPipe();
        }
       
    }
}
