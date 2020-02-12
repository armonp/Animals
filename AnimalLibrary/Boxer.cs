using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalLibrary {
    public class Boxer : Dog {

        public bool shortCoat { get; set; } = true;

        public Boxer(string Name) : base(Name) {
            this.ExtremeSenseOfSmell = true;
            this.BarkPitch = BarkPitchType.low;
            this.Muzzle = MuzzleType.Short;
        }
        public Boxer() :this("Boxer") {

        }

        public override string GetTypeOfDog() {
            return "Boxer";
        }
    }
}
