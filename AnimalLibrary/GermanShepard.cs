using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalLibrary {

    public class GermanSheperd : Dog {
        //GermanSheperd uses Inheritance. inherts (non private) properties, methods, and constructors of Dog Class. Describes the differences
        public bool BigDog { get; set; } = true; //can define new properties not in Dog

        public GermanSheperd() { //default constructor, all instances of German Sheperd will have these properties
            this.Muzzle = MuzzleType.Long;

        }
    }
}
