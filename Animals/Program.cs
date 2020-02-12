using System;
using AnimalLibrary;

namespace Animals {
    class Program {
        static void Main(string[] args) {
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
        }
    }
}
