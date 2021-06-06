using System;

namespace EinsteinsRiddle
{
     class RiddleDescripiton
    {
        
        static Random random = new Random();
        //strings stored statically(in one location)
        static string[] HouseColor = { "Blue", "Green", "Red", "White", "Yellow" };
        static string[] Nationalities = { "Brit", "Dane", "German", "Norwegian", "Swede" };
        static string[] Drinks = { "Beer", "Coffee", "Milk", "Tea", "Water" };
        static string[] Cigarettes = { "Blends", "BlueMaster", "Dunhill", "PallMall", "Prince" };
        static string[] Pets = { "Birds", "Cats", "Dogs", "Horses", "Fish" };
       
       
        static string[] rules = new string[15];

        static void Main(string[] args)
        {
            //Randomizing the list
            Shuffle(HouseColor);
            Shuffle(Nationalities);
            Shuffle(Drinks);
            Shuffle(Pets);
            Shuffle(Cigarettes);
            
            Generaterules();
            static void Generaterules()
            {
                rules[0] = $"The {Nationalities[0]}, lives in the {HouseColor[0]} house.";
                rules[1] = $"The {Nationalities[4]} keeps {Pets[2]} as pets.";
                rules[2] = $"The {Nationalities[1]} drinks {Drinks[3]}.";
                rules[3] = $"{HouseColor[1]} is exactly to the left of the {HouseColor[3]} house.";
                rules[4] = $"The {HouseColor[1]} house owner drinks {Drinks[1]}.";
                rules[5] = $"The person who smokes {Cigarettes[3]} rears {Pets[0]}.";
                rules[6] = $"The owner of the {HouseColor[4]} house smokes {Cigarettes[2]}";
                rules[7] = $"The man living in the centre house drinks {Drinks[2]}.";
                rules[8] = $"The {Nationalities[3]} lives in the first house.";
                rules[9] = $"The man who smokes {Cigarettes[0]} lives next to the one who keeps {Pets[1]}.";
                rules[10] = $"The man who keeps {Pets[3]} lives next to the man who smokes {Cigarettes[2]}.";
                rules[11] = $"The man who smokes {Cigarettes[1]} drinks {Drinks[0]}.";
                rules[12] = $"The {Nationalities[2]} smokes {Cigarettes[4]}.";
                rules[13] = $"The {Nationalities[3]} lives next to the {HouseColor[0]} house.";
                rules[14] = $"The man who smokes {Cigarettes[0]} has a neighbour who drinks {Drinks[4]}.";
            }

            //
            /* 1. There are 5 houses in five different colors.
               2. In each house lives a person with a different nationality.");
               3. The five owners drink a specific type of beverage, they smoke a certain brand of cigarette and keep a specific type of pet.");
               4. No owners have the same pet, smoke the same brand of cigarette or drink the same beverage.");
      
             */
            //checking user input
            for (int i = 1; i <= rules.Length; i++)
            {
                Console.WriteLine($"{i}. {rules[i - 1]}");
            }
            
            Console.WriteLine("Enter solution");
            
            //do
            while (true)
            {
                string input = "";
                if (input == "")
                {
                    break;
                }
                //no input implies false/failed user input
                Console.WriteLine("Failed");
                /*else
                {
                    //some rules satisfied while others are not
                    Console.WriteLine("Fair");
                }*/

            }
            PrintSolution();
            
            
        }

        static void Shuffle(string[] info)
        {
            //looping through the random list
            for (int x = 0; x < info.Length; x++)
            {
                int randomItem = x + random.Next(0, info.Length - x);
                string result = info[x];
                info[x] = info[randomItem];
                info[randomItem] = result;
            }
        }

      
        private static void PrintSolution()
        {
            //satisfied rules,correct input
            for (int x = 0; x < 5; x++)
            {
                Console.WriteLine("Passed");
                
                Console.WriteLine($"The person who lives in {HouseColor[x]} is {Nationalities[x]}, drinks {Drinks[x]}, smokes {Cigarettes[x]} and has {Pets[x]}");
                
            }
            
        }
    }
}