using System;

namespace EinsteinsRiddle
{
    public class program
    { 
        //enum keyword for assigning constant names to a group of numeric integer values
        public enum HouseColor {Blue, Green, Red, White, Yellow }
        
    
        public enum Nationalities{Brit, Dane, German, Norwegian, Swede }
    
        public enum Drinks { Beer, Coffee, Milk, Tea, Water }
   
        public enum Cigarettes { Blends, BlueMaster, Dunhill, PallMall, Prince }
  
        public enum Pets {Birds, Cats, Dogs, Horses, Fish }

        
        struct program
        {
            public Nationalities Nationalities{ get; set; }
            public HouseColor HouseColor { get; set; }
            public Cigarettes Cigarettes { get; set; }
            public Drinks Drinks { get; set; }
            public Pets Pet { get; set; }

            public override String ToString()
            {
                String t = String.Format("Nationalities: {0}", this.Nationalities);
                t += Environment.NewLine;
                t += String.Format(" HouseColor: {0}, Pet: {1}", this.HouseColor, this.Pet);
                t += Environment.NewLine;
                t += String.Format("  Cigarettes: {0}, Drink: {1}", this.Cigarettes, this.Drinks);
                return t;
            }
        }
    }
}