//Dragon.cs written by Ben Bittles
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS
{
    class Dragon : BaseCombatant
    {

        public Dragon(decimal hPIn, decimal attackIn, decimal defenseIn) //Constructor takes neccesary variables and creates dragon monster. 
            : base(hPIn, attackIn, defenseIn)
        {

        }

        public decimal TailSwing() //Tailswing attack does basic amount of damage for dragon.
        {
            return DealDamage(AttackDamage);
        }

        //Fireblast takes all neccesary variables and deals extra damage, also lowers players defense
        public decimal FireBlast(GameData currentData, Monk monkPlayer, Rogue roguePlayer, Wizard wizardPlayer, Knight knightPlayer, Monk monkPlayer2, Rogue roguePlayer2, Wizard wizardPlayer2, Knight knightPlayer2)
        {
            switch (currentData.PlayerOneClass) //Lowers player ones defense
            {
                case "Monk":
                    monkPlayer.BaseDefense += 0.1m;
                    break;
                case "Rogue":
                    roguePlayer.BaseDefense += 0.1m;
                    break;
                case "Wizard":
                    wizardPlayer.BaseDefense += 0.1m;
                    break;
                case "Knight":
                    knightPlayer.BaseDefense += 0.1m;
                    break;
            }

            switch (currentData.PlayerTwoClass) //Lowers player twos defense
            {
                case "Monk":
                    monkPlayer2.BaseDefense += 0.1m;
                    break;
                case "Rogue":
                    roguePlayer2.BaseDefense += 0.1m;
                    break;
                case "Wizard":
                    wizardPlayer2.BaseDefense += 0.1m;
                    break;
                case "Knight":
                    knightPlayer2.BaseDefense += 0.1m;
                    break;
            }



            return DealDamage(AttackDamage * 1.75m);
        }

        //DoAction determines a random attack of the 2 to do and sets damage output to be dealt to player.
        public decimal DoAction(GameData currentData, Monk monkPlayer, Rogue roguePlayer, Wizard wizardPlayer, Knight knightPlayer, Monk monkPlayer2, Rogue roguePlayer2, Wizard wizardPlayer2, Knight knightPlayer2, GameWindow singlePlayerWindow, _2PlayerGameWindow twoPlayerWindow)
        {
            //Create random number that will be use to determine which attack is chosen.
            Random rnd = new Random();
            int num = rnd.Next(1, 3);

            //Create damage total variable for use through method
            decimal damageTotal = 0;

            //Detects which attack is determined my random number and does it accordingly
            switch (num)
            {
                case 1:
                    damageTotal = TailSwing();
                    switch (currentData.CurrentGameType)
                        //If tailswing attack is chosen it sets damage amount to amount tailswing does and tells the user how they were attacked.
                    {
                        case "1Player":
                            {
                                singlePlayerWindow.TurnResultTextBox.Text += Environment.NewLine + "The dragon swung its tail and made a swooshy sound effect!";
                                break;
                            }
                        case "2Player":
                            {
                                twoPlayerWindow.TurnResultTextBox.Text += Environment.NewLine + "The dragon swung its tail and made a swooshy sound effect!";
                                break;
                            }
                    }
                    break;
                case 2:
                    //If fireball attack is chosen it sets damage amount to amount tailswing does, lowers players defenses, and tells the user how they were attacked.
                    damageTotal = FireBlast(currentData, monkPlayer, roguePlayer, wizardPlayer, knightPlayer, monkPlayer2, roguePlayer2, wizardPlayer2, knightPlayer2);
                    switch (currentData.CurrentGameType)
                    {
                        case "1Player":
                            {
                                singlePlayerWindow.TurnResultTextBox.Text += Environment.NewLine + "The dragon got you all sorts of toasty! Ouch! Your armor got burned and your defense was lowered!";
                                break;
                            }
                        case "2Player":
                            {
                                twoPlayerWindow.TurnResultTextBox.Text += Environment.NewLine + "The dragon got you all sorts of toasty! Ouch! Your armor got burned and your defense was lowered!";
                                break;
                            }
                    }
                    break;
            }

            return damageTotal;
        }
    }
}
