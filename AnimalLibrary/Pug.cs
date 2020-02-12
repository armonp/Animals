using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalLibrary {
    public class Pug : Dog {
        public bool IsSmall { get; set; } = true;

        public Pug (string Name) : base(Name) {
            this.Muzzle = MuzzleType.Collapsed;
            this.LongTail = false;
        }
        public Pug() : this("Spot") { //gives name to Pug without name then executes above constructor
            
            
        }

        public override string GetTypeOfDog() {
            return "Pug";
        }
    }
}
