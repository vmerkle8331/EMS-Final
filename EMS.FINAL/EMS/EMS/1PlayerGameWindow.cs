//1PlayerGameWindow.cs created by and contrubuted to by all group members
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
    public partial class GameWindow : Form
    {

        Slime slimeMonster = new Slime(100, 15, 0.7m);
        Orc orcMonster = new Orc(125, 35, 0.5m);
        Skeleton skeletonMonster = new Skeleton(100, 25, 0.5m);
        Dragon dragonMonster = new Dragon(250, 35, 0.4m);

        Wizard wizardPlayer = new Wizard(125, 50, 0.8m);
        Monk monkPlayer = new Monk(175, 50, 0.7m);
        Knight knightPlayer = new Knight(200, 65, 0.6m);
        Rogue roguePlayer = new Rogue(150, 50, 0.7m);

        Wizard wizardPlayer2 = new Wizard(125, 50, 0.8m);
        Monk monkPlayer2 = new Monk(175, 50, 0.7m);
        Knight knightPlayer2 = new Knight(200, 65, 0.6m);
        Rogue roguePlayer2 = new Rogue(150, 50, 0.7m);

        GameData currentGameData = new GameData();

        public GameWindow() //This is just the primary method that creates the form, gets the player class and sets up the player
        {
            InitializeComponent();
            currentGameData = MenuWindow.NewGameData;
            FillActionBox();
        }

        

        void FillActionBox() //This method fills the player's action boxes based on the class they have chosen.
        {
            MonsterPics.Image = imageList1.Images[2];
            TurnResultTextBox.Text = "Its a slime my bro! All you gamer kids, get ready to fight!";
            monsterHealthLabel.Text = "HP: " + slimeMonster.HealthPoints + "/" + slimeMonster.MaxHealthPoints;

            switch (currentGameData.PlayerOneClass)
            {

                case "Monk":
                    {
                        playerHealthLabel.Text = "HP: " + monkPlayer.HealthPoints + "/" + monkPlayer.MaxHealthPoints;
                        PlayerPics.Image = imageList1.Images[5];
                        actionSelectionComboBox.Items.Add("Punch");
                        actionSelectionComboBox.Items.Add("Punch but harder");
                        actionSelectionComboBox.Items.Add("Punch but the hardest");
                        break;
                    }
                case "Rogue":
                    {
                        playerHealthLabel.Text = "HP: " + roguePlayer.HealthPoints + "/" + roguePlayer.MaxHealthPoints;
                        PlayerPics.Image = imageList1.Images[3];
                        actionSelectionComboBox.Items.Add("Stab");
                        actionSelectionComboBox.Items.Add("Throw smoke bomb");
                        actionSelectionComboBox.Items.Add("Throw knife");
                        break;
                    }
                case "Wizard":
                    {
                        playerHealthLabel.Text = "HP: " + wizardPlayer.HealthPoints + "/" + wizardPlayer.MaxHealthPoints;
                        PlayerPics.Image = imageList1.Images[7];
                        actionSelectionComboBox.Items.Add("Magic Missile");
                        actionSelectionComboBox.Items.Add("Fireball");
                        actionSelectionComboBox.Items.Add("Heal");
                        break;
                    }
                case "Knight":
                    {
                        playerHealthLabel.Text = "HP: " + knightPlayer.HealthPoints + "/" + knightPlayer.MaxHealthPoints;
                        PlayerPics.Image = imageList1.Images[4];
                        actionSelectionComboBox.Items.Add("Sword");
                        actionSelectionComboBox.Items.Add("Mace");
                        actionSelectionComboBox.Items.Add("Shield");
                        break;
                    }
            }

                
        }

        private void startTurnButton_Click(object sender, EventArgs e) //This method is the one that does most of the work. It determines attacks used and applies damage and debuffs accordingly.
        {
            //Set starting damage amounts to be used later
            decimal totalMonsterDamage = 0;
            decimal totalPlayerDamage = 0;

            //Tests whether the user has selected an action and displays a message if they havent
            if (actionSelectionComboBox.Text == "")
            {
                MessageBox.Show("Please select an action before proceeding");
            }
            else
            {
                switch (currentGameData.CurrentMonster) //Randomly chooses one of the attacks from the monsters choices of attacks
                {
                    case "Slime":
                        {
                            totalPlayerDamage = slimeMonster.DoAction(currentGameData, monkPlayer, roguePlayer, wizardPlayer, knightPlayer, monkPlayer2, roguePlayer2, wizardPlayer2, knightPlayer2, this, MenuWindow.TwoPlayerGame);
                            ShowDamageTaken(totalPlayerDamage);
                            break;
                        }
                    case "Skeleton":
                        {
                            totalPlayerDamage = skeletonMonster.DoAction(currentGameData, monkPlayer, roguePlayer, wizardPlayer, knightPlayer, this, MenuWindow.TwoPlayerGame);
                            ShowDamageTaken(totalPlayerDamage);
                            break;
                        }
                    case "Orc":
                        {
                            totalPlayerDamage = orcMonster.DoAction(currentGameData, monkPlayer, roguePlayer, wizardPlayer, knightPlayer, this, MenuWindow.TwoPlayerGame);
                            ShowDamageTaken(totalPlayerDamage);
                            break;
                        }
                    case "Dragon":
                        {
                            totalPlayerDamage = dragonMonster.DoAction(currentGameData, monkPlayer, roguePlayer, wizardPlayer, knightPlayer, monkPlayer2, roguePlayer2, wizardPlayer2, knightPlayer2, this, MenuWindow.TwoPlayerGame);
                            ShowDamageTaken(totalPlayerDamage);
                            break;
                        }
                }

                switch (currentGameData.PlayerOneClass) //Takes the action chosen by the player and deals damage or does buffs/debuffs
                {
                    case "Monk":
                        {
                            totalMonsterDamage = monkPlayer.DoAction(actionSelectionComboBox.Text, slimeMonster, skeletonMonster, orcMonster, dragonMonster);
                            break;
                        }
                    case "Rogue":
                        {
                            totalMonsterDamage = roguePlayer.DoAction(actionSelectionComboBox.Text, currentGameData, slimeMonster, skeletonMonster, orcMonster, dragonMonster, monkPlayer, wizardPlayer, roguePlayer, knightPlayer, this, MenuWindow.TwoPlayerGame);
                            break;
                        }
                    case "Wizard":
                        {
                            totalMonsterDamage = wizardPlayer.DoAction(actionSelectionComboBox.Text, currentGameData, monkPlayer, roguePlayer, wizardPlayer, knightPlayer, monkPlayer2, roguePlayer2, wizardPlayer2, knightPlayer2, this, MenuWindow.TwoPlayerGame);
                            break;
                        }
                    case "Knight":
                        {
                            totalMonsterDamage = knightPlayer.DoAction(actionSelectionComboBox.Text, currentGameData, slimeMonster, skeletonMonster, orcMonster, dragonMonster, monkPlayer, wizardPlayer, roguePlayer, knightPlayer, monkPlayer2, roguePlayer2, wizardPlayer2, knightPlayer2);
                            break;
                        }
                }

                switch (currentGameData.CurrentMonster) //Takes the damage the player is dealing and deals it to the monster
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

                switch (currentGameData.PlayerOneClass) //Takes the damage the monster is dealing and deals it to the player
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

                //Updates players health label
                TurnResultTextBox.AppendText(Environment.NewLine);

                //Checks to see if player or monster died
                CheckMonsterHP(currentGameData);
                CheckPlayerHP(currentGameData);

                //Resets player defense
                monkPlayer.DefenseAmount = monkPlayer.BaseDefense;
                roguePlayer.DefenseAmount = roguePlayer.BaseDefense;
                wizardPlayer.DefenseAmount = wizardPlayer.BaseDefense;
                knightPlayer.DefenseAmount = knightPlayer.BaseDefense;
            }            
        }

        public void CheckPlayerHP(GameData currentData) //This method checks the player's health to see if they are dead after the turn or not.
        {
            switch(currentData.PlayerOneClass)
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
                            monsterHealthLabel.Text = "HP: " + skeletonMonster.HealthPoints + "/" + skeletonMonster.MaxHealthPoints;
                            wizardPlayer.Mana += 600;
                            break;
                        }
                        else
                        {
                            monsterHealthLabel.Text = "HP: " + Math.Round(slimeMonster.HealthPoints) + "/" + slimeMonster.MaxHealthPoints;
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
                            monsterHealthLabel.Text = "HP: " + Math.Round(orcMonster.HealthPoints) + "/" + orcMonster.MaxHealthPoints;
                            wizardPlayer.Mana += 600;
                            break;
                        }
                        else
                        {
                            monsterHealthLabel.Text = "HP: " + Math.Round(skeletonMonster.HealthPoints) + "/" + skeletonMonster.MaxHealthPoints;
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
                            monsterHealthLabel.Text = "HP: " + dragonMonster.HealthPoints + "/" + dragonMonster.MaxHealthPoints;
                            wizardPlayer.Mana += 600;
                            break;
                        }
                        else
                        {
                            monsterHealthLabel.Text = "HP: " + Math.Round(orcMonster.HealthPoints) + "/" + orcMonster.MaxHealthPoints;

                            break;
                        }
                    }
                case "Dragon":
                    {
                        if (orcMonster.HealthPoints <= 0)
                        {
                            TurnResultTextBox.Text += Environment.NewLine + "You killed the dragon and beat the game!";
                            System.Windows.Forms.MessageBox.Show("You killed the dragon and beat the game!");
                            Application.Restart();
                            break;
                        }
                        else
                        {
                            monsterHealthLabel.Text = "HP: " + Math.Round(dragonMonster.HealthPoints) + "/" + dragonMonster.MaxHealthPoints;
                            break;
                        }
                    }
            }

            
        }

        public void ShowDamageTaken(decimal damageIn) //This is a simple method that just puts the hp of the player and monsters on the form and updates them as health is taken or added.
        {
            switch (currentGameData.PlayerOneClass)
            {
                case "Rogue":
                    {
                        decimal damageTaken = damageIn * roguePlayer.DefenseAmount;
                        TurnResultTextBox.Text += Environment.NewLine + "You took " + Math.Round(damageTaken) + " damage.";
                        playerHealthLabel.Text = "HP: " + Math.Round(roguePlayer.HealthPoints) + "/" + roguePlayer.MaxHealthPoints;
                        break;
                    }
                case "Knight":
                    {
                        decimal damageTaken = damageIn * knightPlayer.DefenseAmount;
                        TurnResultTextBox.Text += Environment.NewLine + "You took " + Math.Round(damageTaken) + " damage.";
                        playerHealthLabel.Text = "HP: " + Math.Round(knightPlayer.HealthPoints) + "/" + knightPlayer.MaxHealthPoints;
                        break;
                    }
                case "Wizard":
                    {
                        decimal damageTaken = damageIn * wizardPlayer.DefenseAmount;
                        TurnResultTextBox.Text += Environment.NewLine + "You took " + Math.Round(damageTaken) + " damage.";
                        playerHealthLabel.Text = "HP: " + Math.Round(wizardPlayer.HealthPoints) + "/" + wizardPlayer.MaxHealthPoints;
                        break;
                    }
                case "Monk":
                    {
                        decimal damageTaken = damageIn * monkPlayer.DefenseAmount;
                        TurnResultTextBox.Text += Environment.NewLine + "You took " + Math.Round(damageTaken) + " damage.";
                        playerHealthLabel.Text = "HP: " + Math.Round(monkPlayer.HealthPoints) + "/" + monkPlayer.MaxHealthPoints;
                        break;
                    }
            }
        }
        
        private void TurnResultTextBox_TextChanged(object sender, EventArgs e) //This is a simple method that just makes it so the text box autoscrolls as turns happen.
        {
            TurnResultTextBox.SelectionStart = TurnResultTextBox.Text.Length;
            TurnResultTextBox.ScrollToCaret();
        }
    }
}