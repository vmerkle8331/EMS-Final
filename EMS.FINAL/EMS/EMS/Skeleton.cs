//Rogue.cs writen by Victoria Merkle
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS
{
    class Skeleton : BaseCombatant
    {
        public Skeleton(decimal hPIn, decimal attackIn, decimal defenseIn) //takes in data to make the skeleton monster
            : base(hPIn, attackIn, defenseIn)
        {

        }

        public decimal ThrowSkull() //basic attack that gives minimal damage
        {
            return DealDamage(AttackDamage);
        }

        public decimal Sword() //second attack that does more damage
        {
            return DealDamage(AttackDamage * 2);
            
        }
        public decimal DoAction(GameData currentData, Monk monkPlayer, Rogue roguePlayer, Wizard wizardPlayer, Knight knightPlayer, GameWindow singlePlayerWindow, _2PlayerGameWindow twoPlayerWindow)
        {
            //random number is given to choose which attack is used
            Random rnd = new Random();
            int num = rnd.Next(1, 3);

            decimal damageTotal = 0;

            switch (num)
            {
                case 1:
                    {
                        damageTotal = ThrowSkull();
                        switch (currentData.CurrentGameType) //text is displayed to tell the user which attack was used
                        {
                            case "1Player":
                                {
                                    singlePlayerWindow.TurnResultTextBox.Text += Environment.NewLine + "The Skeleton threw it's head at you!";
                                    break;
                                }
                            case "2Player":
                                {
                                    twoPlayerWindow.TurnResultTextBox.Text += Environment.NewLine + "The Skeleton threw it's head at you!";
                                    break;
                                }
                        }
                        break;
                    }
                case 2:
                    damageTotal = Sword();
                    switch(currentData.CurrentGameType)//tells user which attacked was used
                    {
                        case "1Player":
                            {
                                singlePlayerWindow.TurnResultTextBox.Text += Environment.NewLine + "The Skeleton attacked with it's sword!";
                                break;
                            }
                        case "2Player":
                            {
                                twoPlayerWindow.TurnResultTextBox.Text += Environment.NewLine + "The Skeleton attacked with it's sword!";
                                break;
                            }
                    }
                    break;
            }



            return damageTotal;
        }
    }
}