//Rogue.cs writen by Vickie Merkle
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS
{
    class Rogue : BaseCombatant
    {
        public Rogue(decimal hPIn, decimal attackIn, decimal defenseIn) //takes in data to make a Rogue player
            : base(hPIn, attackIn, defenseIn)
        {

        }
        private int amountOfKnives = 10; //uses variable to limit how many times a player can use these attacks
        private int amountOfSmokeBombs = 5;

        string className = "Rogue";

        public string ClassName
        {
            get { return className; }
        }

        public decimal Stab() //basic attack that doesn't use any of the variables and causes minimal damage
        {
            return DealDamage(AttackDamage);
        }
        public decimal ThrowKnife( GameWindow singlePlayerWindow, _2PlayerGameWindow twoPlayerWindow) //attack that uses the knife variable and causes more damage than stab if out of knives attack fails
        {
            if (amountOfKnives > 0)
            {
                amountOfKnives--;

                return DealDamage(AttackDamage * 1.5m);
            }
            else
            {// If the rogue doesn't have enough knives, text is displayed to notify the player.

                twoPlayerWindow.TurnResultTextBox.Text += Environment.NewLine + "You don't have enough knives to throw one!";
                singlePlayerWindow.TurnResultTextBox.Text += Environment.NewLine + "You don't have enough knives to throw one!";
                return 0;
            }
        }

        //attack that lowers the monster's defense and uses the bomb variable if out of bombs attack fails
        public void ThrowSmokeBomb(GameData currentGameData, Slime slimeMonster, Skeleton skeletonMonster, Dragon dragonMonster, Orc orcMonster, GameWindow singlePlayerWindow, _2PlayerGameWindow twoPlayerWindow)
        {
            if (amountOfSmokeBombs > 0)
            {
                switch (currentGameData.CurrentMonster)
                {
                    case "Slime":
                        slimeMonster.DefenseAmount += 0.1m;
                        break;
                    case "Skeleton":
                        skeletonMonster.DefenseAmount += 0.1m;
                        break;
                    case "Dragon":
                        dragonMonster.DefenseAmount += 0.1m;
                        break;
                    case "Orc":
                        orcMonster.DefenseAmount += 0.1m;
                        break;
                }
                amountOfSmokeBombs--;
            }
            else
            {// If the rogue doesn't have enough bombs, text is displayed to notify the player.

                    twoPlayerWindow.TurnResultTextBox.Text += Environment.NewLine + "You don't have any smoke bombs left!";
                singlePlayerWindow.TurnResultTextBox.Text += Environment.NewLine + "You don't have any smoke bobmbs left!";
                
            }
        }

        public decimal DoAction(string actionName, GameData currentData, Slime slime, Skeleton skeleton, Orc orc, Dragon dragon, Monk monkPlayer, Wizard wizardPlayer, Rogue roguePlayer, Knight knightPlayer, GameWindow singlePlayerWindow, _2PlayerGameWindow twoPlayerWindow)
        {
            //variable damageTotal is created to store the total amount of damage the rogue will do this turn. 
            decimal damageTotal = 0;
            switch (actionName)
            {
                //Gets user's selection from the drop down menu 
                case "Stab":
                    {
                        damageTotal = Stab();
                        return damageTotal;
                    }
                case "Throw knife":
                    {
                        damageTotal = ThrowKnife(singlePlayerWindow, twoPlayerWindow);
                        return damageTotal;
                    }
                case "Throw smoke bomb":
                    {
                        ThrowSmokeBomb(currentData, slime, skeleton, dragon, orc, singlePlayerWindow, twoPlayerWindow);
                        return damageTotal;
                    }
                default:
                    {
                        return damageTotal;
                    }
            }

        }
    }
}