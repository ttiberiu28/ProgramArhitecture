using System;

namespace ProgramArhitecture {

    public class Delivery_Pipe {//useless - gandeste cum sa implementez
        //si clasa asta

        public double Length { get; set; }
        public string Material { get; set; }
        public int DeliveryPipeHealth { get; set; }


        public Delivery_Pipe(double length, string material) {
            Length = length;
            Material = material;
            DeliveryPipeHealth = 0;
        }

        public void DecreaseDPHealth() {
            DeliveryPipeHealth++;
        }

        public void CleanDeliveryPipe() {
            DeliveryPipeHealth = 0;
            Console.WriteLine("Delivery Pipe was cleaned");
        }

    }
}
