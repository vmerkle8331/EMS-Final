//Orc.cs written by Eduardo Rincon
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS
{

    class Orc : BaseCombatant
    {
        public Orc(decimal hpIn, decimal attackIn, decimal defenseIn) : base(hpIn, attackIn, defenseIn)//Constructor takes in needed data to create a orc object.
        {

        }
        public decimal Melee() // Melee attack for the orc. 
        {
            return DealDamage(AttackDamage);
        }
        public decimal Sword()
        {
            return DealDamage(AttackDamage * 1.5m); //Sword attack and the added variable.
        }

        public decimal DoAction(GameData currentData, Monk monkPlayer, Rogue roguePlayer, Wizard wizardPlayer, Knight knightPlayer, GameWindow singlePlayerWindow, _2PlayerGameWindow twoPlayerWindow)
        {
            Random rnd = new Random(); //Random number generated for the attacks and rounds 
            int num = rnd.Next(1, 3);

            decimal damageTotal = 0;
            //If Melee attack is selected text is displayed to notify both players.
            switch (num)
            {
                case 1:
                    damageTotal = Melee();
                    switch (currentData.CurrentGameType)
                    {
                        case "1Player":
                            {
                                singlePlayerWindow.TurnResultTextBox.Text += Environment.NewLine + "The orc punched you real hard!";
                                break;
                            }
                        case "2Player":
                            {
                                twoPlayerWindow.TurnResultTextBox.Text += Environment.NewLine + "The orc punched you real hard!";
                                break;
                            }
                    }
                    break;
                //If sword attack is selected text is displayed to notify both players.
                case 2:
                    damageTotal = Sword();
                    switch (currentData.CurrentGameType)
                    {
                        case "1Player":
                            {
                                singlePlayerWindow.TurnResultTextBox.Text += Environment.NewLine + "The orc attacked you with its sword!";
                                break;
                            }
                        case "2Player":
                            {
                                twoPlayerWindow.TurnResultTextBox.Text += Environment.NewLine + "The orc attacked you with its sword!";
                                break;
                            }
                    }
                    break;
            }
            return damageTotal;
        }
    }
}