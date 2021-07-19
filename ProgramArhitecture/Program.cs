using System;

namespace ProgramArhitecture {

    class MainClass {

        public static void Main(string[] args) {

            /*
             How the expressor works:
             1.)As long as there is a pot added, you can pour water(even cold water)
             2.)You can heat the water in the boiler and pour it(1 press of a button)
             3.)You can also only heat the water in the pot(2 presses of a button)
             4.)Any heating takes 10 seconds
             5.)Water Tank can be reffiled at any time , even if it is not completly
            empty yet.
             6.)after 7 uses the filter must be changed(it can also be changed at any time)
             7.)after 12 uses you get a warning to clean delivery pipe(not mandatory)
             8.)you can choose between 5 coffee options, change your decision at any time
             9.)NOTE: it is not necessary to insert capsule in order to use expressor
            , hot water only is an option(how? don't put capsule)
             */

            Expressor expressor = new Expressor("Red",3,0.9);//in liters

            while(true) {
                Console.WriteLine("Options: Add(1)/Remove(2)(pot)" +
                    " | Heat(3)(boiler/coffee) | " +
                    "Pour Water(4) | Refill Tank(5) | Change Filter(6)" +
                    " | Choose Coffee Type(7) | Clean Delivery Pipe(8) | Quit(9)");

                int choice = Convert.ToInt32(Console.ReadLine());

                if(choice == 1) {

                    expressor.AddPot();//adaug pot

                } else if(choice == 2) {

                    expressor.RemovePot();//scot pot

                } else if(choice == 3) {//incalzez boiler sau reincalzesc pot

                    Console.WriteLine("For heating you have 2 options:" +
                    "\n 1 button press for heating the boiler (1)" +
                    "\n 2 button presses for heating the pot(basically" +
                    " reaheating the coffee)(2)");

                    int number = Convert.ToInt32(Console.ReadLine());

                    expressor.PressButton(number);
                    expressor.Heat();

                } else if(choice == 4) {//torn apa

                    expressor.PourWater();

                }else if(choice == 5) {

                    expressor.RefillTank();

                } else if(choice == 6) {

                    expressor.ChangeFilter();   
                    
                }else if(choice == 7) {

                    Console.WriteLine("We have the following coffee types: " +
                        "Latte(1) | Cappuccino(2) | Americano(3) |" +
                        " Expresso(4) | Black Tea(5)");

                    int option = Convert.ToInt32(Console.ReadLine());

                    while(true) {

                        if(option < 1 || option > 5) {

                            Console.WriteLine("Please insert values between 1 and 5");
                            option = Convert.ToInt32(Console.ReadLine());

                        } else {

                            expressor.ChooseCoffee(option);
                            break;
                        }
                    }

                }else if(choice == 8) {

                    expressor.CleanDeliveryPipe();

                }else if(choice == 9){

                    break;

                } else {
                    Console.WriteLine("Please insert values from 1 to 9");
                }
               
            }
        }

    }
}
