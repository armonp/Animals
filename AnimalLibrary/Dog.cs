using System;

namespace AnimalLibrary {
    /*Enumeration 
    enum [Type] { option1, option 2, option3 }
    */

    public enum MuzzleType { Long, Short, Collapsed }; //define Enumeration outside of class
    public enum BarkPitchType { high, medium, low};

    public class Dog {
        public bool LongTail { get; set; }
        public BarkPitchType BarkPitch { get; set; } //high, medium, low        
        public MuzzleType Muzzle { get; set; } //long, short, collapsed
        public bool ExtremeSenseOfSmell { get; set; } = false;
        public string Name { get; set; }

        public Dog() { //default constructor

        }



    } //end of class
}
