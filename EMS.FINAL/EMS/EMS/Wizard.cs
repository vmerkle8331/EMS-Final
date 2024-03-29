//Wizard.cs written by KC Brukiewa
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS
{
    class Wizard : BaseCombatant
    {

        public Wizard(decimal hPIn, decimal attackIn, decimal defenseIn) // Constructor takes in needed data to create a monk player.
            : base(hPIn, attackIn, defenseIn)
        {

        }

        private decimal mana = 1000; // Wizard uses special variable mana to restrict spell use. Player starts with 1000 mana points.
        string className = "Wizard";

        public decimal Mana
        {
            get { return mana; }
            set { mana = value; }
        }

        public string ClassName
        {
            get { return className; }
        }

        public decimal MagicMissle() // Magic Missle spell costs no mana to use and deals damage using the standard wizard attack stat.
        {
            return (DealDamage(AttackDamage));
        }

        public decimal Fireball(GameWindow singlePlayerWindow, _2PlayerGameWindow twoPlayerWindow) // Fireball costs 400 mana to use, if 400 mana is not available the attack fails.
        {
            if (mana - 400 >= 0)
            {
                //if the player has enough mana, the player's mana is reduced and a higher attack stat is returned.
                mana -= 400;
                return (75);
            }
            else
            {
                // If the wizard doesn't have enough mana, text is displayed to notify the player.
                twoPlayerWindow.TurnResultTextBox.Text += Environment.NewLine + "You don't have enough mana to use fireball! Regain mana by killing monsters!"; 
                singlePlayerWindow.TurnResultTextBox.Text += Environment.NewLine + "You don't have enough mana to use fireball! Regain mana by killing monsters!";
                return (0);
            }
        }

        public void Heal(GameData currentData, Monk monkPlayer, Rogue roguePlayer, Wizard wizardPlayer, Knight knightPlayer, Monk monkPlayer2, Rogue roguePlayer2, Wizard wizardPlayer2, Knight knightPlayer2, GameWindow singlePlayerWindow, _2PlayerGameWindow twoPlayerWindow) // Heal spell heals 50 Health points to every character and costs 400 mana. If 400 mana is not available the spell fails.
        {
            if (mana - 400 >= 0) 
            {
                //if the player has enough mana, the player's mana is reduced and the proper character(s) is/are healed. 
                mana -= 400;
                switch (currentData.PlayerOneClass)
                {
                    case "Monk":
                        monkPlayer.HealthPoints += 50;
                        break;
                    case "Rogue":
                        roguePlayer.HealthPoints += 50;
                        break;
                    case "Wizard":
                        wizardPlayer.HealthPoints += 50;
                        break;
                    case "Knight":
                        knightPlayer.HealthPoints += 50;
                        break;
                }

                switch (currentData.PlayerTwoClass)
                {
                    case "Monk":
                        monkPlayer2.HealthPoints += 50;
                        break;
                    case "Rogue":
                        roguePlayer2.HealthPoints += 50;
                        break;
                    case "Wizard":
                        wizardPlayer2.HealthPoints += 50;
                        break;
                    case "Knight":
                        knightPlayer2.HealthPoints += 50;
                        break;
                }
            }
            else
            {
                // If the wizard doesn't have enough mana, text is displayed to notify the player.
                twoPlayerWindow.TurnResultTextBox.Text += Environment.NewLine + "You don't have enough mana to heal! Regain mana by killing monsters!";
                singlePlayerWindow.TurnResultTextBox.Text += Environment.NewLine + "You don't have enough mana to heal! Regain mana by killing monsters!";
            }
        }

        public decimal DoAction(string actionName, GameData currentData, Monk monkPlayer, Rogue roguePlayer, Wizard wizardPlayer, Knight knightPlayer, Monk monkPlayer2, Rogue roguePlayer2, Wizard wizardPlayer2, Knight knightPlayer2, GameWindow singlePlayerWindow, _2PlayerGameWindow twoPlayerWindow) // DoAction takes all needed data to determine and execute the user's selected action.
        {
            //variable damageTotal is created to store the total amount of damage the wizard will do this turn. 
            decimal damageTotal = 0;

            switch (actionName)
            {
                //Selects which action should be executed depending on the user's input via the drop down menu. 
                case "Magic Missile":
                    {
                        damageTotal = MagicMissle();
                        return damageTotal;
                    }
                case "Fireball":
                    {
                        damageTotal = Fireball(singlePlayerWindow, twoPlayerWindow);
                        return damageTotal;
                    }
                case "Heal":
                    { 
                        Heal(currentData, monkPlayer, roguePlayer, wizardPlayer, knightPlayer, monkPlayer2, roguePlayer2, wizardPlayer2, knightPlayer2, singlePlayerWindow, twoPlayerWindow);
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
