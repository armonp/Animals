using System;
using System.Collections.Generic;
using AnimalLibrary;

namespace Animals {
    class Program {
        static void Main(string[] args) {
            var gs1 = new GermanSheperd("Spike"); //enum not picked so defaults to first in list. bools not defined defaulted to false. inherts traits from GermansSheperd then Dog.
            var pug1 = new Pug("Rollo");
            var pug2 = new Pug { Name = "Steve", BarkPitch = BarkPitchType.medium };
            var pug3 = new Pug();
            var boxer1 = new Boxer("Clifford");

            var germanSheperd = new GermanSheperd {  //Dog is not in same namespace. declare 'using AnimalLibrary'. Or rename AnimalLibrary to Animals
                LongTail = true,
                BarkPitch = BarkPitchType.low,
                Muzzle = MuzzleType.Long,
                ExtremeSenseOfSmell = true,
                BigDog = true
            };
            var pug = new Dog {
                LongTail = false,
                BarkPitch = BarkPitchType.high, 
                Muzzle = MuzzleType.Collapsed,
                ExtremeSenseOfSmell = false,
                Name = "Ralph"
                
            };

            var dogs = new List<Dog>();
            dogs.Add(pug); dogs.Add(germanSheperd); dogs.Add(boxer1); dogs.Add(pug3); dogs.Add(pug2); dogs.Add(pug1); dogs.Add(gs1);

            foreach(var dog in dogs ) {
                
                Console.WriteLine(dog.GetTypeOfDog());
            }
           
        }
    }
}
