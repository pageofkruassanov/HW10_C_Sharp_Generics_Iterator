using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW10_C_Sharp_Generics_Iterator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 1:
            Shark bullShark = new Shark("Bull Shark");
            Shark sandShark = new Shark("Sand Shark");
            Tuna bluefinTuna = new Tuna("Bluefin Tuna");
            Marlin blueMarlin = new Marlin("Blue Marlin");
            FlyingFish ecoketFlyingFish = new FlyingFish("Ecoket Flying Fish");

            ISeaCreature[] seaCreatures = new ISeaCreature[] { bullShark, bluefinTuna, sandShark, blueMarlin, ecoketFlyingFish };
            Aquarium aquarium = new Aquarium(seaCreatures);

            foreach(var sea in aquarium)
            {
                Console.WriteLine(sea.Swim());
            }

            Console.ReadLine();

            // Task 2:
            Player karimBenzema = new Player("Karim Benzema", "Weight: 81 kg\nHeight: 1.85 m");
            Player edenHazard = new Player("Eden Hazard", "Weight: 74 kg\nHeight: 1.75 m");
            Player sergioRamos = new Player("Sergio Ramos", "Weight: 82 kg\nHeight: 1.84 m");
            Player lukaModric = new Player("Luka Madric", "Weight: 66 kg\nHeight: 1.72 m");
            Player thibautCourtois = new Player("Thibaut Courtois", "Weight: 96 kg\nHeight: 1.99 m");

            IPlayer[] players = new IPlayer[] { karimBenzema, edenHazard, sergioRamos, lukaModric, thibautCourtois };

            FootballTeam realMadrid = new FootballTeam(players, "Real Madrid");
            Console.WriteLine($"Football team name: {realMadrid.GetName()} \nPopular players: \n");

            foreach(var player in players)
            {
                Console.WriteLine(player.ShowInfo());
            }
            Console.ReadLine();

            // Task 3:

            IWorker[] workers = new IWorker[] { new Worker(2500, "Julia", "Barista"), new Worker(2500, "Dima", "Barista"), new Worker(3200, "Pavlo", "Manager") };

            Console.WriteLine("Cafe staff: ");

            foreach (var worker in workers)
            {
                Console.WriteLine(worker.ShowInfo());
            }
            Console.ReadLine();

        }
    }
}
