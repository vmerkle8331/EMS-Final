//Monk.cs written by Ben Bittles
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS
{
    class Monk : BaseCombatant
    {

        public Monk(decimal hPIn, decimal attackIn, decimal defenseIn) //Constructor takes neccesary variables and creates monk player. 
            : base(hPIn, attackIn, defenseIn)
        {

        }

        string className = "Monk";

        public string ClassName
        {
            get { return className; }
        }

        public decimal Punch() //Punch option deals minimum amount of damage for monk
        {
            return DealDamage(AttackDamage);
        }

        public decimal HarderPunch() //Harder punch option deals slightly more damage and debuffs monsters defense
        {
            return AttackDamage * 1.5m;
        }

        public decimal HardestPunch() //Hardest punch option deals 2x damage and does self damage.
        {
            HealthPoints -= 35;
            return AttackDamage * 2;
        }

        public decimal DoAction(string actionName, Slime slime, Skeleton skeleton, Orc orc, Dragon dragon) //Takes the option the user selected and sets damage output to be dealt to monster.
        {
            //Create damage total variable for use through method
            decimal damageTotal = 0;

            //Detects which option was chosen and does it accordingly
            switch (actionName)
            {
                case "Punch":
                    {
                        damageTotal = Punch();
                        return damageTotal;
                    }
                case "Punch but harder":
                    {
                        damageTotal = HarderPunch();
                        slime.DefenseAmount += 0.1m;
                        skeleton.DefenseAmount += 0.1m;
                        orc.DefenseAmount += 0.1m;
                        dragon.DefenseAmount += 0.1m;
                        return damageTotal;
                    }
                case "Punch but the hardest":
                    {
                        damageTotal = HardestPunch();
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
