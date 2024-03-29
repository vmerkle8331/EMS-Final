//Orc.cs written by Eduardo Rincon
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS
{
    class Knight : BaseCombatant
    {
        public Knight(decimal hPIn, decimal attackIn, decimal defenseIn) : base(hPIn, attackIn, defenseIn)//Constructor takes neccesary variables and creates monk player.
        {

        }

        string className = "Knight";

        public string ClassName
        {
            get { return className; }
        }

        private decimal Sword(string monster1) //Sword attack better for orc and dragon.
        {
            switch (monster1)
            {
                case "Orc":
                    AttackDamage += 10;
                    break;

                case "Dragon":
                    AttackDamage += 10;
                    break;
            }

            return DealDamage(AttackDamage);
        }
        private decimal Mace(string monster1) //Mace attack better for the skeleton and slime.
        {
            switch (monster1)
            {
                case "Skeleton":
                    AttackDamage += 10;
                    break;

                case "Slime":
                    AttackDamage += 10;
                    break;
            }

            return DealDamage(AttackDamage);
        }
        //Shield attack adds defense to player two and himself.
        public void Shield(GameData currentData, Monk monkPlayer, Rogue roguePlayer, Wizard wizardPlayer, Knight knightPlayer, Monk monkPlayer2, Rogue roguePlayer2, Wizard wizardPlayer2, Knight knightPlayer2)
        {
            switch (currentData.PlayerOneClass)//Detects which player and adds the defense.
            {
                case "Monk":
                    monkPlayer.DefenseAmount -= 0.3m;
                    break;
                case "Rogue":
                    roguePlayer.DefenseAmount -= 0.3m;
                    break;
                case "Wizard":
                    wizardPlayer.DefenseAmount -= 0.3m;
                    break;
                case "Knight":
                    knightPlayer.DefenseAmount -= 0.3m;
                    break;
            }

            switch (currentData.PlayerTwoClass)
            {
                case "Monk":
                    monkPlayer2.DefenseAmount -= 0.3m;
                    break;
                case "Rogue":
                    roguePlayer2.DefenseAmount -= 0.3m;
                    break;
                case "Wizard":
                    wizardPlayer2.DefenseAmount -= 0.3m;
                    break;
                case "Knight":
                    knightPlayer2.DefenseAmount -= 0.3m;
                    break;
            }

        }

        public decimal DoAction(string actionName, GameData currentData, Slime slime, Skeleton skeleton, Orc orc, Dragon dragon, Monk monkPlayer, Wizard wizardPlayer, Rogue roguePlayer, Knight knightPlayer, Monk monkPlayer2, Rogue roguePlayer2, Wizard wizardPlayer2, Knight knightPlayer2)
        {
            //Create damage total variable for use through method
            decimal damageTotal = 0;
            switch (actionName)
            {
                case "Sword":
                    {
                        damageTotal = Sword(currentData.CurrentMonster);
                        return damageTotal;
                    }
                case "Mace":
                    {
                        damageTotal = Mace(currentData.CurrentMonster);
                        return damageTotal;
                    }
                case "Shield":
                    {
                        Shield(currentData, monkPlayer, roguePlayer, wizardPlayer, knightPlayer, monkPlayer2,  roguePlayer2,  wizardPlayer2,  knightPlayer2);
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
