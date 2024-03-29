//2PlayerGameWindow.cs created by and contrubuted to by all group members
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMS
{
    public partial class _2PlayerGameWindow : Form
    {
        //When the window is opened, all neccesary objects are created for reference later.

        Slime slimeMonster = new Slime(100, 25, 0.7m);
        Orc orcMonster = new Orc(125, 50, 0.5m);
        Skeleton skeletonMonster = new Skeleton(100, 35, 0.6m);
        Dragon dragonMonster = new Dragon(250, 50, 0.4m);

        Wizard wizardPlayer = new Wizard(125, 50, 0.7m);
        Monk monkPlayer = new Monk(175, 50, 0.7m);
        Knight knightPlayer = new Knight(200, 65, 0.6m);
        Rogue roguePlayer = new Rogue(150, 50, 0.7m);

        Wizard wizardPlayer2 = new Wizard(125, 50, 0.7m);
        Monk monkPlayer2 = new Monk(175, 50, 0.7m);
        Knight knightPlayer2 = new Knight(200, 65, 0.6m);
        Rogue roguePlayer2 = new Rogue(150, 50, 0.7m);

        GameData currentGameData = new GameData();
        public _2PlayerGameWindow() //This is just the primary method that creates the form, gets the player classes and sets up the players
        {
            InitializeComponent();
            currentGameData = MenuWindow.NewGameData;
            FillActionBox();            
        }

        

        void FillActionBox() //This method fills the player's action boxes based on the class they have chosen.
        {
            MonsterPics.Image = imageList1.Images[2];
            TurnResultTextBox.Text = "Its a slime my bro! All you gamer kids, get ready to fight!";
            TurnResultTextBox.Text = Environment.NewLine;
            monsterHealthLabel.Text = "HP: " + slimeMonster.HealthPoints + "/" + slimeMonster.MaxHealthPoints;

            switch (currentGameData.PlayerOneClass)
            {

                case "Monk":
                    {
                        playerHealthLabel.Text = "Player 1 HP: " + monkPlayer.HealthPoints + "/" + monkPlayer.MaxHealthPoints;
                        PlayerPics.Image = imageList1.Images[5];
                        actionSelectionComboBox.Items.Add("Punch");
                        actionSelectionComboBox.Items.Add("Punch but harder");
                        actionSelectionComboBox.Items.Add("Punch but the hardest");
                        break;
                    }
                case "Rogue":
                    {
                        playerHealthLabel.Text = "Player 1 HP: " + roguePlayer.HealthPoints + "/" + roguePlayer.MaxHealthPoints;
                        PlayerPics.Image = imageList1.Images[3];
                        actionSelectionComboBox.Items.Add("Stab");
                        actionSelectionComboBox.Items.Add("Throw smoke bomb");
                        actionSelectionComboBox.Items.Add("Throw knife");
                        break;
                    }
                case "Wizard":
                    {
                        playerHealthLabel.Text = "Player 1 HP: " + wizardPlayer.HealthPoints + "/" + wizardPlayer.MaxHealthPoints;
                        PlayerPics.Image = imageList1.Images[7];
                        actionSelectionComboBox.Items.Add("Magic Missile");
                        actionSelectionComboBox.Items.Add("Fireball");
                        actionSelectionComboBox.Items.Add("Heal");
                        break;
                    }
                case "Knight":
                    {
                        playerHealthLabel.Text = "Player 1 HP: " + knightPlayer.HealthPoints + "/" + knightPlayer.MaxHealthPoints;
                        PlayerPics.Image = imageList1.Images[4];
                        actionSelectionComboBox.Items.Add("Sword");
                        actionSelectionComboBox.Items.Add("Mace");
                        actionSelectionComboBox.Items.Add("Shield");
                        break;
                    }
            }

            switch (currentGameData.PlayerTwoClass)
            {

                case "Monk":
                    {
                        player2HealthLabel.Text = "Player 2 HP: " + monkPlayer2.HealthPoints + "/" + monkPlayer2.MaxHealthPoints;
                        Player2Pics.Image = imageList1.Images[5];
                        action2SelectionComboBox.Items.Add("Punch");
                        action2SelectionComboBox.Items.Add("Punch but harder");
                        action2SelectionComboBox.Items.Add("Punch but the hardest");
                        break;
                    }
                case "Rogue":
                    {
                        player2HealthLabel.Text = "Player 2 HP: " + roguePlayer2.HealthPoints + "/" + roguePlayer2.MaxHealthPoints;
                        Player2Pics.Image = imageList1.Images[3];
                        action2SelectionComboBox.Items.Add("Stab");
                        action2SelectionComboBox.Items.Add("Throw smoke bomb");
                        action2SelectionComboBox.Items.Add("Throw knife");
                        break;
                    }
                case "Wizard":
                    {
                        player2HealthLabel.Text = "Player 2 HP: " + wizardPlayer2.HealthPoints + "/" + wizardPlayer2.MaxHealthPoints;
                        Player2Pics.Image = imageList1.Images[7];
                        action2SelectionComboBox.Items.Add("Magic Missile");
                        action2SelectionComboBox.Items.Add("Fireball");
                        action2SelectionComboBox.Items.Add("Heal");
                        break;
                    }
                case "Knight":
                    {
                        player2HealthLabel.Text = "Player 2 HP: " + knightPlayer2.HealthPoints + "/" + knightPlayer2.MaxHealthPoints;
                        Player2Pics.Image = imageList1.Images[4];
                        action2SelectionComboBox.Items.Add("Sword");
                        action2SelectionComboBox.Items.Add("Mace");
                        action2SelectionComboBox.Items.Add("Shield");
                        break;
                    }
            }


        }

        public void CheckPlayerHP(GameData currentData) //This method checks both players health to see if they are dead after the turn or not.
        {
            switch (currentData.PlayerOneClass)
            {
                case "Rogue":
                    {
                        if (roguePlayer.HealthPoints <= 0)
                        {
                            System.Windows.Forms.MessageBox.Show("You died!!!");
                            Application.Restart();
                            break;
                        }
                        else
                        {
                            break;
                        }
                    }
                case "Knight":
                    {
                        if (knightPlayer.HealthPoints <= 0)
                        {
                            System.Windows.Forms.MessageBox.Show("You died!!!");
                            Application.Restart();
                            break;

                        }
                        else
                        {
                            break;
                        }
                    }
                case "Wizard":
                    {
                        if (wizardPlayer.HealthPoints <= 0)
                        {
                            System.Windows.Forms.MessageBox.Show("You died!!!");
                            Application.Restart();
                            break;
                        }
                        else
                        {
                            break;
                        }
                    }
                case "Monk":
                    {
                        if (monkPlayer.HealthPoints <= 0)
                        {
                            System.Windows.Forms.MessageBox.Show("You died!!!");
                            Application.Restart();
                            break;
                        }
                        else
                        {
                            break;
                        }
                    }
            }

            switch (currentData.PlayerTwoClass)
            {
                case "Rogue":
                    {
                        if (roguePlayer2.HealthPoints <= 0)
                        {
                            System.Windows.Forms.MessageBox.Show("You died!!!");
                            Application.Restart();
                            break;
                        }
                        else
                        {
                            break;
                        }
                    }
                case "Knight":
                    {
                        if (knightPlayer2.HealthPoints <= 0)
                        {
                            System.Windows.Forms.MessageBox.Show("You died!!!");
                            Application.Restart();
                            break;

                        }
                        else
                        {
                            break;
                        }
                    }
                case "Wizard":
                    {
                        if (wizardPlayer2.HealthPoints <= 0)
                        {
                            System.Windows.Forms.MessageBox.Show("You died!!!");
                            Application.Restart();
                            break;
                        }
                        else
                        {
                            break;
                        }
                    }
                case "Monk":
                    {
                        if (monkPlayer2.HealthPoints <= 0)
                        {
                            System.Windows.Forms.MessageBox.Show("You died!!!");
                            Application.Restart();
                            break;
                        }
                        else
                        {
                            break;
                        }
                    }
            }
        }

        public void CheckMonsterHP(GameData currentData) //This method checks the current monsters health to see if it is dead or not and if so moves on to the next monster.
        {
            switch (currentData.CurrentMonster)
            {
                case "Slime":
                    {
                        if (slimeMonster.HealthPoints <= 0)
                        {
                            MonsterPics.Image = imageList1.Images[1];
                            currentGameData.CurrentMonster = "Skeleton";
                            TurnResultTextBox.Text += Environment.NewLine + "You killed the Slime! \nOh no! A skeleton has appeared!";
                            monsterHealthLabel.Text = "Monster HP: " + skeletonMonster.HealthPoints + "/" + skeletonMonster.MaxHealthPoints;
                            wizardPlayer.Mana += 600;
                            wizardPlayer2.Mana += 600;
                            break;
                        }
                        else
                        {
                            monsterHealthLabel.Text = "Monster HP: " + Math.Round(slimeMonster.HealthPoints) + "/" + slimeMonster.MaxHealthPoints;
                            break;
                        }
                    }
                case "Skeleton":
                    {
                        if (skeletonMonster.HealthPoints <= 0)
                        {
                            MonsterPics.Image = imageList1.Images[6];
                            currentGameData.CurrentMonster = "Orc";
                            TurnResultTextBox.Text += Environment.NewLine + "You killed the Skeleton! \nOh no! An orc attacks!";
                            monsterHealthLabel.Text = "Monster HP: " + orcMonster.HealthPoints + "/" + orcMonster.MaxHealthPoints;
                            wizardPlayer.Mana += 600;
                            wizardPlayer2.Mana += 600;
                            break;
                        }
                        else
                        {
                            monsterHealthLabel.Text = "Monster HP: " + Math.Round(skeletonMonster.HealthPoints) + "/" + skeletonMonster.MaxHealthPoints;
                            break;
                        }
                    }
                case "Orc":
                    {
                        if (orcMonster.HealthPoints <= 0)
                        {
                            MonsterPics.Image = imageList1.Images[0];
                            currentGameData.CurrentMonster = "Dragon";
                            TurnResultTextBox.Text += Environment.NewLine + "You killed the Orc! \nThe dragon has been waiting for you!";
                            monsterHealthLabel.Text = "Monster HP: " + dragonMonster.HealthPoints + "/" + dragonMonster.MaxHealthPoints;
                            wizardPlayer.Mana += 600;
                            wizardPlayer2.Mana += 600;
                            break;
                        }
                        else
                        {
                            monsterHealthLabel.Text = "Monster HP: " + Math.Round(orcMonster.HealthPoints) + "/" + orcMonster.MaxHealthPoints;

                            break;
                        }
                    }
                case "Dragon":
                    {
                        if (dragonMonster.HealthPoints <= 0)
                        {
                            TurnResultTextBox.Text += Environment.NewLine + "You killed the dragon and beat the game!";
                            System.Windows.Forms.MessageBox.Show("You killed the dragon and beat the game!");
                            Application.Restart();
                            break;
                        }
                        else
                        {
                            monsterHealthLabel.Text = "Monster HP: " + Math.Round(dragonMonster.HealthPoints) + "/" + dragonMonster.MaxHealthPoints;
                            break;
                        }
                    }
            }


        }

        public void ShowDamageTaken(decimal damageIn) //This is a simple method that just puts the hp of the players and monsters on the form and updates them as health is taken or added.
        {
            switch (currentGameData.PlayerOneClass)
            {
                case "Rogue":
                    {
                        decimal damageTaken = damageIn * roguePlayer.DefenseAmount;
                        TurnResultTextBox.Text += Environment.NewLine + "Player 1 took " + Math.Round(damageTaken) + " damage.";
                        playerHealthLabel.Text = "Player 1 HP: " + Math.Round(roguePlayer.HealthPoints) + "/" + roguePlayer.MaxHealthPoints;
                        break;
                    }
                case "Knight":
                    {
                        decimal damageTaken = damageIn * knightPlayer.DefenseAmount;
                        TurnResultTextBox.Text += Environment.NewLine + "Player 1 took " + Math.Round(damageTaken) + " damage.";
                        playerHealthLabel.Text = "Player 1 HP: " + Math.Round(knightPlayer.HealthPoints) + "/" + knightPlayer.MaxHealthPoints;
                        break;
                    }
                case "Wizard":
                    {
                        decimal damageTaken = damageIn * wizardPlayer.DefenseAmount;
                        TurnResultTextBox.Text += Environment.NewLine + "Player 1 took " + Math.Round(damageTaken) + " damage.";
                        playerHealthLabel.Text = "Player 1 HP: " + Math.Round(wizardPlayer.HealthPoints) + "/" + wizardPlayer.MaxHealthPoints;
                        break;
                    }
                case "Monk":
                    {
                        decimal damageTaken = damageIn * monkPlayer.DefenseAmount;
                        TurnResultTextBox.Text += Environment.NewLine + "Player 1 took " + Math.Round(damageTaken) + " damage.";
                        playerHealthLabel.Text = "Player 1 HP: " + Math.Round(monkPlayer.HealthPoints) + "/" + monkPlayer.MaxHealthPoints;
                        break;
                    }
            }

            switch (currentGameData.PlayerTwoClass)
            {
                case "Rogue":
                    {
                        decimal damageTaken = damageIn * roguePlayer2.DefenseAmount;
                        TurnResultTextBox.Text += Environment.NewLine + "Player 2 took " + Math.Round(damageTaken) + " damage.";
                        player2HealthLabel.Text = "Player 2 HP: " + Math.Round(roguePlayer2.HealthPoints) + "/" + roguePlayer2.MaxHealthPoints;
                        break;
                    }
                case "Knight":
                    {
                        decimal damageTaken = damageIn * knightPlayer2.DefenseAmount;
                        TurnResultTextBox.Text += Environment.NewLine + "Player 2 took " + Math.Round(damageTaken) + " damage.";
                        player2HealthLabel.Text = "Player 2 HP: " + Math.Round(knightPlayer2.HealthPoints) + "/" + knightPlayer2.MaxHealthPoints;
                        break;
                    }
                case "Wizard":
                    {
                        decimal damageTaken = damageIn * wizardPlayer2.DefenseAmount;
                        TurnResultTextBox.Text += Environment.NewLine + "Player 2 took " + Math.Round(damageTaken) + " damage.";
                        player2HealthLabel.Text = "Player 2 HP: " + Math.Round(wizardPlayer2.HealthPoints) + "/" + wizardPlayer2.MaxHealthPoints;
                        break;
                    }
                case "Monk":
                    {
                        decimal damageTaken = damageIn * monkPlayer2.DefenseAmount;
                        TurnResultTextBox.Text += Environment.NewLine + "Player 2 took " + Math.Round(damageTaken) + " damage.";
                        player2HealthLabel.Text = "Player 2 HP: " + Math.Round(monkPlayer2.HealthPoints) + "/" + monkPlayer2.MaxHealthPoints;
                        break;
                    }
            }
        }

        private void startTurnButton_Click(object sender, EventArgs e) //This method is the one that does most of the work. It determines attacks used and applies damage and debuffs accordingly.
        {
            //Set starting damage amounts to be used later
            decimal totalMonsterDamage = 0;
            decimal tempPlayerDamage = 0;
            decimal totalPlayerDamage = 0;
            decimal totalPlayer2Damage = 0;

            //Tests whether the users have selected an action and displays a message if they havent
            if (actionSelectionComboBox.Text == "")
            {
                MessageBox.Show("Please select an action before proceeding");
            }
            else if (action2SelectionComboBox.Text == "")
            {
                MessageBox.Show("Please select an action before proceeding");
            }
            else
            {
                switch (currentGameData.CurrentMonster) //Randomly chooses one of the attacks from the monsters choices of attacks
                {
                    case "Slime":
                        {
                            tempPlayerDamage += slimeMonster.DoAction(currentGameData, monkPlayer, roguePlayer, wizardPlayer, knightPlayer, monkPlayer2, roguePlayer2, wizardPlayer2, knightPlayer2, MenuWindow.SinglePlayerGame, this);
                            totalPlayerDamage += tempPlayerDamage;
                            totalPlayer2Damage += tempPlayerDamage;
                            break;
                        }
                    case "Skeleton":
                        {
                            tempPlayerDamage += skeletonMonster.DoAction(currentGameData, monkPlayer, roguePlayer, wizardPlayer, knightPlayer, MenuWindow.SinglePlayerGame, this);
                            totalPlayerDamage += tempPlayerDamage;
                            totalPlayer2Damage += tempPlayerDamage;
                            break;
                        }
                    case "Orc":
                        {
                            tempPlayerDamage += orcMonster.DoAction(currentGameData, monkPlayer, roguePlayer, wizardPlayer, knightPlayer, MenuWindow.SinglePlayerGame, this);
                            totalPlayerDamage += tempPlayerDamage;
                            totalPlayer2Damage += tempPlayerDamage;
                            break;
                        }
                    case "Dragon":
                        {
                            tempPlayerDamage += dragonMonster.DoAction(currentGameData, monkPlayer, roguePlayer, wizardPlayer, knightPlayer, monkPlayer2, roguePlayer2, wizardPlayer2, knightPlayer2, MenuWindow.SinglePlayerGame, this);
                            totalPlayerDamage += tempPlayerDamage;
                            totalPlayer2Damage += tempPlayerDamage;
                            break;
                        }
                }

                switch (currentGameData.PlayerOneClass) //Takes the action chosen by the 1st player and deals damage or does buffs/debuffs
                {
                    case "Monk":
                        {
                            totalMonsterDamage += monkPlayer.DoAction(actionSelectionComboBox.Text, slimeMonster, skeletonMonster, orcMonster, dragonMonster);
                            break;
                        }
                    case "Rogue":
                        {
                            totalMonsterDamage += roguePlayer.DoAction(actionSelectionComboBox.Text, currentGameData, slimeMonster, skeletonMonster, orcMonster, dragonMonster, monkPlayer, wizardPlayer, roguePlayer, knightPlayer, MenuWindow.SinglePlayerGame, this);
                            break;
                        }
                    case "Wizard":
                        {
                            totalMonsterDamage += wizardPlayer.DoAction(actionSelectionComboBox.Text, currentGameData, monkPlayer, roguePlayer, wizardPlayer, knightPlayer, monkPlayer2, roguePlayer2, wizardPlayer2, knightPlayer2, MenuWindow.SinglePlayerGame, this);
                            break;
                        }
                    case "Knight":
                        {
                            totalMonsterDamage += knightPlayer.DoAction(actionSelectionComboBox.Text, currentGameData, slimeMonster, skeletonMonster, orcMonster, dragonMonster, monkPlayer, wizardPlayer, roguePlayer, knightPlayer, monkPlayer2, roguePlayer2, wizardPlayer2, knightPlayer2);
                            break;
                        }
                }

                switch (currentGameData.PlayerTwoClass) //Takes the action chosen by the 2nd player and deals damage or does buffs/debuffs
                {
                    case "Monk":
                        {
                            totalMonsterDamage += monkPlayer2.DoAction(action2SelectionComboBox.Text, slimeMonster, skeletonMonster, orcMonster, dragonMonster);
                            break;
                        }
                    case "Rogue":
                        {
                            totalMonsterDamage += roguePlayer2.DoAction(action2SelectionComboBox.Text, currentGameData, slimeMonster, skeletonMonster, orcMonster, dragonMonster, monkPlayer, wizardPlayer, roguePlayer, knightPlayer, MenuWindow.SinglePlayerGame, this);
                            break;
                        }
                    case "Wizard":
                        {
                            totalMonsterDamage += wizardPlayer2.DoAction(action2SelectionComboBox.Text, currentGameData, monkPlayer, roguePlayer, wizardPlayer, knightPlayer, monkPlayer2, roguePlayer2, wizardPlayer2, knightPlayer2, MenuWindow.SinglePlayerGame, this);
                            break;
                        }
                    case "Knight":
                        {
                            totalMonsterDamage += knightPlayer2.DoAction(action2SelectionComboBox.Text, currentGameData, slimeMonster, skeletonMonster, orcMonster, dragonMonster, monkPlayer, wizardPlayer, roguePlayer, knightPlayer, monkPlayer2, roguePlayer2, wizardPlayer2, knightPlayer2);
                            break;
                        }
                }

                switch (currentGameData.CurrentMonster) //Takes the damage the players are dealing and deals it to the monster
                {
                    case "Slime":
                        {
                            slimeMonster.TakeDamage(totalMonsterDamage);
                            break;
                        }
                    case "Skeleton":
                        {
                            skeletonMonster.TakeDamage(totalMonsterDamage);
                            break;
                        }
                    case "Orc":
                        {
                            orcMonster.TakeDamage(totalMonsterDamage);
                            break;
                        }
                    case "Dragon":
                        {
                            dragonMonster.TakeDamage(totalMonsterDamage);
                            break;
                        }
                }

                switch (currentGameData.PlayerOneClass) //Takes the damage the monster is dealing and deals it to the 1st player
                {
                    case "Monk":
                        {
                            monkPlayer.TakeDamage(totalPlayerDamage);
                            break;
                        }
                    case "Rogue":
                        {
                            roguePlayer.TakeDamage(totalPlayerDamage);
                            break;
                        }
                    case "Wizard":
                        {
                            wizardPlayer.TakeDamage(totalPlayerDamage);
                            break;
                        }
                    case "Knight":
                        {
                            knightPlayer.TakeDamage(totalPlayerDamage);
                            break;
                        }
                }

                switch (currentGameData.PlayerTwoClass) //Takes the damage the monster is dealing and deals it to the 2nd player
                {
                    case "Monk":
                        {
                            monkPlayer2.TakeDamage(totalPlayer2Damage);
                            break;
                        }
                    case "Rogue":
                        {
                            roguePlayer2.TakeDamage(totalPlayer2Damage);
                            break;
                        }
                    case "Wizard":
                        {
                            wizardPlayer2.TakeDamage(totalPlayer2Damage);
                            break;
                        }
                    case "Knight":
                        {
                            knightPlayer2.TakeDamage(totalPlayer2Damage);
                            break;
                        }
                }

                //Updates players health label
                TurnResultTextBox.AppendText(Environment.NewLine);
                ShowDamageTaken(totalPlayerDamage);

                //Checks to see if player or monster died
                CheckMonsterHP(currentGameData);
                CheckPlayerHP(currentGameData);

                //Resets player defense
                monkPlayer.DefenseAmount = monkPlayer.BaseDefense;
                roguePlayer.DefenseAmount = roguePlayer.BaseDefense;
                wizardPlayer.DefenseAmount = wizardPlayer.BaseDefense;
                knightPlayer.DefenseAmount = knightPlayer.BaseDefense;

                monkPlayer2.DefenseAmount = monkPlayer2.BaseDefense;
                roguePlayer2.DefenseAmount = roguePlayer2.BaseDefense;
                wizardPlayer2.DefenseAmount = wizardPlayer2.BaseDefense;
                knightPlayer2.DefenseAmount = knightPlayer2.BaseDefense;
            }           
        }
        private void TurnResultTextBox_TextChanged(object sender, EventArgs e) //This is a simple method that just makes it so the text box autoscrolls as turns happen.
        {
            TurnResultTextBox.SelectionStart = TurnResultTextBox.Text.Length;
            TurnResultTextBox.ScrollToCaret();
        }
    }
}