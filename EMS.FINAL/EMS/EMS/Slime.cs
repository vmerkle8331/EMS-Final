//Slime.cs written by KC Brukiewa
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS
{
    class Slime : BaseCombatant
    {
        public Slime(decimal hPIn, decimal attackIn, decimal defenseIn) // Constructor takes in needed data to create a slime object.
            : base(hPIn, attackIn, defenseIn)
        {

        }

        public decimal Melee() // Melee attack returns the standard slime attack stat. 
        {
            return (DealDamage(AttackDamage));
        }

        public void SlimeBall(GameData currentData, Monk monkPlayer, Rogue roguePlayer, Wizard wizardPlayer, Knight knightPlayer, Monk monkPlayer2, Rogue roguePlayer2, Wizard wizardPlayer2, Knight knightPlayer2) // Slime ball attack reduces the player(s) defense stats and makes the future fights harder.
        {
            switch (currentData.PlayerOneClass) // Only selected characters will be effected by the slime ball attack. 
            {
                case "Monk":
                    monkPlayer.BaseDefense += 0.1m; // Because defense is multiplied by the total damage amount, having a higher defense stat is worse. 
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

            switch (currentData.PlayerTwoClass)
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
        }

        public decimal DoAction(GameData currentData, Monk monkPlayer, Rogue roguePlayer, Wizard wizardPlayer, Knight knightPlayer, Monk monkPlayer2, Rogue roguePlayer2, Wizard wizardPlayer2, Knight knightPlayer2, GameWindow singlePlayerWindow, _2PlayerGameWindow twoPlayerWindow) // Selects a random slime action to be executed. 
        {
            //A random number is generated each round to determine which attack is used. 
            Random rnd = new Random();
            int num = rnd.Next(1,3);

            decimal damageTotal = 0;

            switch (num)
            {
                case 1:
                    damageTotal = Melee();
                    //If Melee attack is selected text is displayed to notify the player(s).
                    switch (currentData.CurrentGameType)
                    {
                        case "1Player": 
                            {
                                singlePlayerWindow.TurnResultTextBox.Text += Environment.NewLine + "The Slime tackled you!";
                                break;
                            }
                        case "2Player":
                            {
                                twoPlayerWindow.TurnResultTextBox.Text += Environment.NewLine + "The Slime tackled you!";
                                break;
                            }
                    }

                    break;
                case 2:
                    SlimeBall(currentData, monkPlayer, roguePlayer, wizardPlayer, knightPlayer, monkPlayer2, roguePlayer2, wizardPlayer2, knightPlayer2);
                    //If SlimeBall attack is selected text is displayed to notify the player(s).
                    switch (currentData.CurrentGameType)
                    {
                        case "1Player":
                            {
                                singlePlayerWindow.TurnResultTextBox.Text += Environment.NewLine + "The Slime got you all stuck in it's stuff! Your defense was lowered permanently!";
                                break;
                            }
                        case "2Player":
                            {
                                twoPlayerWindow.TurnResultTextBox.Text += Environment.NewLine + "The Slime got you all stuck in it's stuff! Your defense was lowered permanently!";
                                break;
                            }
                    }

                    break;

            }

            return damageTotal;
        }

    }
}
