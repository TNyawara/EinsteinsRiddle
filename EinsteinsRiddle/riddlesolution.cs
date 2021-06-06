using System;
using EinsteinsRiddle;


namespace EinsteinsRiddle
{
     class riddlesolution
    {
        private void InitPossibilities()
        {
            
        } 
        private program.HouseColor[] houses;
        private int[][] five_possibilities;
        
     //public class  riddlesolution()
    {
        this.InitPossibilities();

        // create five houses
        this.houses = new program.HouseColor[5];
        for (int i = 0; i < this.houses.Length; i++)
            this.houses[i] = new program.HouseColor();
        
    }
    
    public void Solution()
    {
        // looping through house colors
        for (int c = 0; c < this.five_possibilities.Length; c++)
        
            int[] poss1 = this.five_possibilities[c];
            this.houses[poss1[0]].HouseColor = program.HouseColor.Blue;
            this.houses[poss1[1]].HouseColor = program.HouseColor.Green;
            this.houses[poss1[2]].HouseColor = program.HouseColor.Red;
            this.houses[poss1[3]].HouseColor = program.HouseColor.White;
            this.houses[poss1[4]].HouseColor = program.HouseColor.Yellow;
        
        
        // looping through nationalities
        for (int n = 0; n < this.five_possibilities.Length; n++)
        {
            int[] poss2 = this.five_possibilities[n];
            this.houses[poss2[0]].Nationalities = program.Nationalities.Brit;
            this.houses[poss2[0]].Nationalities = program.Nationalities.Dane;
            this.houses[poss2[0]].Nationalities = program.Nationalities.German;
            this.houses[poss2[0]].Nationalities = program.Nationalities.Norwegian;
            this.houses[poss2[0]].Nationalities = program.Nationalities.Swede;
            
            // looping through drinks
            for (int d = 0; d < this.five_possibilities.Length; d++)
            {
                int[] poss3 = this.five_possibilities[d];
                this.houses[poss3[0]].Drinks = program.Drinks.Beer;
                this.houses[poss3[1]].Drinks = program.Drinks.Coffee;
                this.houses[poss3[2]].Drinks= program.Drinks.Milk;
                this.houses[poss3[3]].Drinks= program.Drinks.Tea;
                this.houses[poss3[4]].Drinks= program.Drinks.Water;
            
        //looping through cigarette brands
        for (int b = 0; b < this.five_possibilities.Length; b++)
        {
            int[] poss4= this.five_possibilities[b];
            this.houses[poss4[0]].Cigarettes= program.Cigarettes.Blends;
            this.houses[poss4[1]].Cigarettes= program.Cigarettes.BlueMaster;
            this.houses[poss4[2]].Cigarettes= program.Cigarettes.Dunhill;
            this.houses[poss4[3]].Cigarettes = program.Cigarettes.PallMall;
            this.houses[poss4[4]].Cigarettes = program.Cigarettes.Prince;

            // looping through pets
            for (int p = 0; p < this.five_possibilities.Length; p++)
            {
                int[] poss5 = this.five_possibilities[p];
                this.houses[poss5[0]].Pets = program.Pets.Birds;
                this.houses[poss5[1]].Pets = program.Pets.Cats;
                this.houses[poss5[2]].Pets = program.Pets.Dogs;
                this.houses[poss5[3]].Pets = program.Pets.Horses;
                this.houses[poss5[4]].Pets= program.Pets.Fish;

                         // The Brit Lives in the red house
                            if (!this.hint1_Verify())
                                continue;

                            //The Swede keeps Dogs as pets
                            if (!this.hint2_Verify())
                                continue;

                            // The Dane drinks Tea
                            if (!this.hint3_Verify())
                                continue;

                            // THe green house is exactly to the left of the white house
                            if (!this.hint4_Verify())
                                continue;

                           //The owner of the Green house drinks Coffee.
                            if (!this.hint5_Verify())
                                continue;

                            // The person who smokes Pall Mall rears Birds.
                            if (!this.hint6_Verify())
                                continue;

                            // The owner of the Yellow house smokes Dunhill."
                         

                            // The man living in the centre house drinks Milk.
                            if (!this.hint8_Verify())
                                continue;

                            // The Norwegian lives in the first house.
                       

                            // The man who smokes Blends lives next to the one who keeps Cats.
                            if (!this.hint10_Verify())
                                continue;

                            //The man who keeps Horses lives next to the man who smokes Dunhill.
                            if (!this.hint11_Verify())
                                continue;

                            // The man who smokes Blue Master drinks Beer.
                            if (!this.hint12_Verify())
                                continue;

                            // The German smokes Prince.

                            // The Norwegian lives next to the Blue house.
                            if (!this.hint14_Verify())
                                continue;

                            // The man who smokes Blends has a neighbour who drinks Water.
                            if (!this.hint15_Verify())
                                continue;

                            // print solution
                            this.PrintSolution();
                        }
                    }
                }
            }
        }
    }

   
    // The Brit Lives in the red house
    private bool hint1_Verify()
    {
        bool hint= false;
        for (int i = 0; i < 5; i++)
        {
            if (this.houses[i].Nationalities== program.Nationalities.Brit)
            {
                if (this.houses[i].HouseColor == program.HouseColor.Red)
                {
                    hint = true;
                }
                break;
            }
        }
        return hint;
    }

    //The Swede keeps Dogs as pets
    private bool hint2_Verify()
    {
        bool hint= false;
        for (int i = 0; i < 5; i++)
        {
            if (this.houses[i].Nationalities == program.Nationalities.Swede)
            {
                if (this.houses[i].Pets == program.Pets.Dogs)
                {
                    hint = true;
                } 
                break;
            }
        }
        return hint;
    }

    //The Dane drinks Tea.
    private bool hint3_Verify()
    {
        bool hint = false;
        for (int i = 0; i < 5; i++)
        {
            if (this.houses[i].Nationalities == program.Nationalities.Dane)
            {
                if (this.houses[i].Drinks == program.Drinks.Tea)
                {
                    hint = true;
                }
                break;
            }
        }
        return hint;
    }

  //The Green house is exactly to the left of the White house
    private bool hint4_Verify()
    {
        if ((this.houses[2].HouseColor == program.HouseColor.Green &&
                this.houses[3].HouseColor == program.HouseColor.White) ||
                (this.houses[3].HouseColor == program.HouseColor.Green &&
                this.houses[4].HouseColor == program.HouseColor.White))
        {
            return true;
        }
        else
            return false;
    }

    //The owner of the Green house drinks Coffee.
    private bool hint5_Verify()
    {
        bool hint = false;
        for (int i = 0; i < 5; i++)
        {
            if (this.houses[i].HouseColor == program.HouseColor.Green)
            {
                if (this.houses[i].Drink == program.Drinks.Coffee)
                {
                    hint = true;
                }
                break;
            }
        }
        return hint;
    }

    //The person who smokes Pall Mall rears Birds.
    private bool hint6_Verify()
    {
        bool hint = false;
        for (int i = 0; i < 5; i++)
        {
            if (this.houses[i].Cigarettes == program.Cigarettes.PallMall)
            {
                if (this.houses[i].Pets == program.Pets.Bird)
                {
                    hint = true;
                }
                break;
            }
        }

        return hint;
    }

  

    //he owner of the Yellow house smokes Dunhill.
    private bool hint8_Verify()
    {
        bool hint = false;
        for (int i = 0; i < 5; i++)
        {
            if (this.houses[i].HouseColor == program.HouseColor.Yellow)
            {
                if (this.houses[i].Cigarette == program.Cigarettes.Dunhill)
                {
                    hint = true;
                }
                break;
            }
        }
        return hint;
    }
    // The man who smokes Blends lives next to the one who keeps Cats.
    private bool hint10_Verify()
    {
        bool hint = false;
        for (int i = 0; i < 5; i++)
        {
            if (this.houses[i].Cigarettes == program.Cigarettes.Blends)
            {
                if (i == 0)
                {
                    if (this.houses[1].Pets == program.Pets.Cats)
                        hint = true;
                }
                else if (i == 4)
                {
                    if (this.houses[3].Pets == program.Pets.Cats)
                        hint= true;
                }
                else if (this.houses[i - 1].Pets == program.Pets.Cats ||
                    this.houses[i + 1].Pets== program.Pets.Cats)
                    hint = true;

                break;
            }
        }

        return hint;
    }

    // The man who keeps Horses lives next to the man who smokes Dunhill.
    private bool hint11_Verify()
    {
        bool hint = false;
        for (int i = 0; i < 5; i++)
        {
            if (this.houses[i].Pets == program.Pets.Horses)
            {
                if (i == 0)
                {
                    if (this.houses[1].Cigarettes == program.Cigarettes.Dunhill)
                        hint = true;
                }
                else if (i == 4)
                {
                    if (this.houses[3].Cigarettes == program.Cigarettes.Dunhill)
                        hint = true;
                }
                else if (this.houses[i - 1].Cigarettes == program.Cigarettes.Dunhill ||
                            this.houses[i + 1].Cigarettes == program.Cigarettes.Dunhill)
                        hint = true;
            
                break;
            }
        }
        return hint;
    }

    // The man who smokes Blue Master drinks Beer.
    private bool hint12_Verify()
    {
        bool hint = false;
        for (int i = 0; i < 5; i++)
        {
            if (this.houses[i].Cigarettes == program.Cigarettes.BlueMaster)
            {
                if (this.houses[i].Drinks == program.Drinks.Beer)
                    hint= true;

                break;
            }
        }
        return hint;
    }


    // The German smokes Prince.
    private bool hint14_Verify()
    {
        bool hint = false;
        for (int i = 0; i < 5; i++)
        {
            if (this.houses[i].Nationalities == program.Nationalities.German)
            {
                if (this.houses[i].Cigarettes == program.Cigarettes.Prince)
                    hint= true;

                break;
            }
        }
        return hint;
    }

//The man who smokes Blends has a neighbour who drinks Water.
    private bool hint15_Verify()
    {
        bool hint = false;
        for (int i = 0; i < 5; i++)
        {
            if (this.houses[i].Cigarettes== program.Cigarettes.Blends)
            {
                if (i == 0)
                {
                    if (this.houses[1].Drinks == program.Drinks.Water)
                        hint = true;
                }
                else if (i == 4)
                {
                    if (this.houses[3].Drinks == program.Drinks.Water)
                        hint = true;
                }
                else if (this.houses[i - 1].Drinks == program.Drinks.Water ||
                    this.houses[i + 1].Drinks == program.Drinks.Water)
                    hint = true;

                break;
            }
        }
        return hint;
    }

    string PrintSolution(int result)
    {
        string print;
            if (result == 0)
            {
                print = "Failed";
            }
            else if (result == 15)
            {
                print = "Passed";
            }
            else
            {
                print = "Fair";
            }
            return print;
        }
    } 