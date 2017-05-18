using LectureNotes.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LectureNotes
{
    class Program
    {
        static void Main(string[] args)
        {
            // In an ideal world, programmers that use our Automobile class use it correctly.
            Automobile subaru = new Automobile();
            subaru.isStarted = true; //start the car
            subaru.speed = 10; // accelerate to 10
            subaru.speed = 20; // accelerate to 20
            subaru.speed = 30; // accelerate to 30
            subaru.speed = 20; // decelerate to 20
            subaru.speed = 10; // decelerate to 30
            subaru.speed = 0;  // decelerate to 30
            subaru.isReverse = true; // go in reverse
            subaru.speed = 10; // reverse at 10mph
            subaru.speed = 0;  // reverse to 0mph
            subaru.isStarted = false; //turn off the car

            // Probably how a programmer will end up using it though...
            Automobile toyota = new Automobile();
            // ?? wait we're not even going to start the car?
            toyota.speed = 100; // turbo mode to 100mph
            toyota.speed = 0; // turbo brake to 0mph
            // ? and leave it running?


            // Lets have more fun (but not in real life)
            Automobile getawayVehicle = new Automobile();
            getawayVehicle.isStarted = true;
            getawayVehicle.isReverse = true; //<-- did it stall?
            getawayVehicle.isReverse = true;
            getawayVehicle.speed = 100; // let's not experience this ever, please?
        }
    }
}
