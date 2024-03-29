namespace EMS
{
    partial class MenuWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.startGameButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.player1ClassComboBox = new System.Windows.Forms.ComboBox();
            this.player2ClassComboBox = new System.Windows.Forms.ComboBox();
            this.SecondPlayerSelectionButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.player2ClassLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startGameButton
            // 
            this.startGameButton.Location = new System.Drawing.Point(78, 345);
            this.startGameButton.Name = "startGameButton";
            this.startGameButton.Size = new System.Drawing.Size(164, 61);
            this.startGameButton.TabIndex = 0;
            this.startGameButton.Text = "GO!";
            this.startGameButton.UseVisualStyleBackColor = true;
            this.startGameButton.Click += new System.EventHandler(this.startGameButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(369, 345);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(164, 61);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // player1ClassComboBox
            // 
            this.player1ClassComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.player1ClassComboBox.FormattingEnabled = true;
            this.player1ClassComboBox.Items.AddRange(new object[] {
            "Knight",
            "Wizard",
            "Rogue",
            "Monk"});
            this.player1ClassComboBox.Location = new System.Drawing.Point(171, 148);
            this.player1ClassComboBox.Name = "player1ClassComboBox";
            this.player1ClassComboBox.Size = new System.Drawing.Size(262, 21);
            this.player1ClassComboBox.TabIndex = 2;
            // 
            // player2ClassComboBox
            // 
            this.player2ClassComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.player2ClassComboBox.FormattingEnabled = true;
            this.player2ClassComboBox.Items.AddRange(new object[] {
            "Knight",
            "Wizard",
            "Rogue",
            "Monk"});
            this.player2ClassComboBox.Location = new System.Drawing.Point(171, 218);
            this.player2ClassComboBox.Name = "player2ClassComboBox";
            this.player2ClassComboBox.Size = new System.Drawing.Size(262, 21);
            this.player2ClassComboBox.TabIndex = 3;
            this.player2ClassComboBox.Visible = false;
            // 
            // SecondPlayerSelectionButton
            // 
            this.SecondPlayerSelectionButton.Location = new System.Drawing.Point(241, 255);
            this.SecondPlayerSelectionButton.Name = "SecondPlayerSelectionButton";
            this.SecondPlayerSelectionButton.Size = new System.Drawing.Size(126, 44);
            this.SecondPlayerSelectionButton.TabIndex = 7;
            this.SecondPlayerSelectionButton.Text = "2 Player Mode";
            this.SecondPlayerSelectionButton.UseVisualStyleBackColor = true;
            this.SecondPlayerSelectionButton.Click += new System.EventHandler(this.SecondPlayerSelectionButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(272, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Player 1 Class";
            //this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // player2ClassLabel
            // 
            this.player2ClassLabel.AutoSize = true;
            this.player2ClassLabel.Location = new System.Drawing.Point(272, 202);
            this.player2ClassLabel.Name = "player2ClassLabel";
            this.player2ClassLabel.Size = new System.Drawing.Size(73, 13);
            this.player2ClassLabel.TabIndex = 9;
            this.player2ClassLabel.Text = "Player 2 Class";
            this.player2ClassLabel.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Old English Text MT", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(82, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(465, 48);
            this.label3.TabIndex = 10;
            this.label3.Text = "Epic Monster Showdown!!!";
            // 
            // MenuWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 465);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.player2ClassLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SecondPlayerSelectionButton);
            this.Controls.Add(this.player2ClassComboBox);
            this.Controls.Add(this.player1ClassComboBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.startGameButton);
            this.Name = "MenuWindow";
            this.Text = "Epic Monster Showdown";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startGameButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button SecondPlayerSelectionButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label player2ClassLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox player1ClassComboBox;
        public System.Windows.Forms.ComboBox player2ClassComboBox;
    }
}

