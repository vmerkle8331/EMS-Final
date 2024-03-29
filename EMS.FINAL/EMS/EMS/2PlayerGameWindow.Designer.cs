namespace EMS
{
    partial class _2PlayerGameWindow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_2PlayerGameWindow));
            this.MonsterPics = new System.Windows.Forms.PictureBox();
            this.PlayerPics = new System.Windows.Forms.PictureBox();
            this.monsterHealthLabel = new System.Windows.Forms.Label();
            this.playerHealthLabel = new System.Windows.Forms.Label();
            this.TurnResultTextBox = new System.Windows.Forms.TextBox();
            this.actionSelectionComboBox = new System.Windows.Forms.ComboBox();
            this.startTurnButton = new System.Windows.Forms.Button();
            this.Player2Pics = new System.Windows.Forms.PictureBox();
            this.action2SelectionComboBox = new System.Windows.Forms.ComboBox();
            this.player2HealthLabel = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.player1ActionLabel = new System.Windows.Forms.Label();
            this.player2ActionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MonsterPics)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerPics)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player2Pics)).BeginInit();
            this.SuspendLayout();
            // 
            // MonsterPics
            // 
            this.MonsterPics.Location = new System.Drawing.Point(989, 15);
            this.MonsterPics.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MonsterPics.Name = "MonsterPics";
            this.MonsterPics.Size = new System.Drawing.Size(423, 340);
            this.MonsterPics.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MonsterPics.TabIndex = 14;
            this.MonsterPics.TabStop = false;
            // 
            // PlayerPics
            // 
            this.PlayerPics.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PlayerPics.Location = new System.Drawing.Point(121, 46);
            this.PlayerPics.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PlayerPics.Name = "PlayerPics";
            this.PlayerPics.Size = new System.Drawing.Size(456, 373);
            this.PlayerPics.TabIndex = 13;
            this.PlayerPics.TabStop = false;
            // 
            // monsterHealthLabel
            // 
            this.monsterHealthLabel.AutoSize = true;
            this.monsterHealthLabel.Location = new System.Drawing.Point(1112, 448);
            this.monsterHealthLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.monsterHealthLabel.Name = "monsterHealthLabel";
            this.monsterHealthLabel.Size = new System.Drawing.Size(0, 17);
            this.monsterHealthLabel.TabIndex = 12;
            // 
            // playerHealthLabel
            // 
            this.playerHealthLabel.AutoSize = true;
            this.playerHealthLabel.Location = new System.Drawing.Point(157, 436);
            this.playerHealthLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.playerHealthLabel.Name = "playerHealthLabel";
            this.playerHealthLabel.Size = new System.Drawing.Size(0, 17);
            this.playerHealthLabel.TabIndex = 11;
            // 
            // TurnResultTextBox
            // 
            this.TurnResultTextBox.Location = new System.Drawing.Point(28, 470);
            this.TurnResultTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TurnResultTextBox.Multiline = true;
            this.TurnResultTextBox.Name = "TurnResultTextBox";
            this.TurnResultTextBox.ReadOnly = true;
            this.TurnResultTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TurnResultTextBox.Size = new System.Drawing.Size(875, 179);
            this.TurnResultTextBox.TabIndex = 10;
            this.TurnResultTextBox.TextChanged += new System.EventHandler(this.TurnResultTextBox_TextChanged);
            // 
            // actionSelectionComboBox
            // 
            this.actionSelectionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.actionSelectionComboBox.FormattingEnabled = true;
            this.actionSelectionComboBox.Location = new System.Drawing.Point(61, 725);
            this.actionSelectionComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.actionSelectionComboBox.Name = "actionSelectionComboBox";
            this.actionSelectionComboBox.Size = new System.Drawing.Size(616, 24);
            this.actionSelectionComboBox.TabIndex = 9;
            // 
            // startTurnButton
            // 
            this.startTurnButton.Location = new System.Drawing.Point(989, 535);
            this.startTurnButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.startTurnButton.Name = "startTurnButton";
            this.startTurnButton.Size = new System.Drawing.Size(423, 114);
            this.startTurnButton.TabIndex = 8;
            this.startTurnButton.Text = "Attack!";
            this.startTurnButton.UseVisualStyleBackColor = true;
            this.startTurnButton.Click += new System.EventHandler(this.startTurnButton_Click);
            // 
            // Player2Pics
            // 
            this.Player2Pics.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Player2Pics.Location = new System.Drawing.Point(611, 46);
            this.Player2Pics.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Player2Pics.Name = "Player2Pics";
            this.Player2Pics.Size = new System.Drawing.Size(456, 373);
            this.Player2Pics.TabIndex = 15;
            this.Player2Pics.TabStop = false;
            // 
            // action2SelectionComboBox
            // 
            this.action2SelectionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.action2SelectionComboBox.FormattingEnabled = true;
            this.action2SelectionComboBox.Location = new System.Drawing.Point(795, 725);
            this.action2SelectionComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.action2SelectionComboBox.Name = "action2SelectionComboBox";
            this.action2SelectionComboBox.Size = new System.Drawing.Size(616, 24);
            this.action2SelectionComboBox.TabIndex = 16;
            // 
            // player2HealthLabel
            // 
            this.player2HealthLabel.AutoSize = true;
            this.player2HealthLabel.Location = new System.Drawing.Point(624, 436);
            this.player2HealthLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.player2HealthLabel.Name = "player2HealthLabel";
            this.player2HealthLabel.Size = new System.Drawing.Size(0, 17);
            this.player2HealthLabel.TabIndex = 17;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Smaugfinal.png");
            this.imageList1.Images.SetKeyName(1, "sthingfinal.jpg");
            this.imageList1.Images.SetKeyName(2, "slimethingfinal.png");
            this.imageList1.Images.SetKeyName(3, "roguefinal.jpg");
            this.imageList1.Images.SetKeyName(4, "knightthingfinal.jpg");
            this.imageList1.Images.SetKeyName(5, "monkpersonfinal.jpg");
            this.imageList1.Images.SetKeyName(6, "orc.png");
            this.imageList1.Images.SetKeyName(7, "wizardpersonfinal.png");
            // 
            // player1ActionLabel
            // 
            this.player1ActionLabel.AutoSize = true;
            this.player1ActionLabel.Location = new System.Drawing.Point(315, 700);
            this.player1ActionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.player1ActionLabel.Name = "player1ActionLabel";
            this.player1ActionLabel.Size = new System.Drawing.Size(109, 17);
            this.player1ActionLabel.TabIndex = 18;
            this.player1ActionLabel.Text = "Player 1 actions";
            // 
            // player2ActionLabel
            // 
            this.player2ActionLabel.AutoSize = true;
            this.player2ActionLabel.Location = new System.Drawing.Point(1061, 700);
            this.player2ActionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.player2ActionLabel.Name = "player2ActionLabel";
            this.player2ActionLabel.Size = new System.Drawing.Size(109, 17);
            this.player2ActionLabel.TabIndex = 19;
            this.player2ActionLabel.Text = "Player 2 actions";
            // 
            // _2PlayerGameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1488, 777);
            this.Controls.Add(this.MonsterPics);
            this.Controls.Add(this.player2ActionLabel);
            this.Controls.Add(this.player1ActionLabel);
            this.Controls.Add(this.player2HealthLabel);
            this.Controls.Add(this.action2SelectionComboBox);
            this.Controls.Add(this.Player2Pics);
            this.Controls.Add(this.PlayerPics);
            this.Controls.Add(this.monsterHealthLabel);
            this.Controls.Add(this.playerHealthLabel);
            this.Controls.Add(this.TurnResultTextBox);
            this.Controls.Add(this.actionSelectionComboBox);
            this.Controls.Add(this.startTurnButton);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "_2PlayerGameWindow";
            this.Text = "Epic Monster Showdown!!!";
            ((System.ComponentModel.ISupportInitialize)(this.MonsterPics)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerPics)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player2Pics)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox MonsterPics;
        private System.Windows.Forms.PictureBox PlayerPics;
        private System.Windows.Forms.Label monsterHealthLabel;
        private System.Windows.Forms.Label playerHealthLabel;
        public System.Windows.Forms.TextBox TurnResultTextBox;
        private System.Windows.Forms.ComboBox actionSelectionComboBox;
        private System.Windows.Forms.Button startTurnButton;
        private System.Windows.Forms.PictureBox Player2Pics;
        private System.Windows.Forms.ComboBox action2SelectionComboBox;
        private System.Windows.Forms.Label player2HealthLabel;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label player1ActionLabel;
        private System.Windows.Forms.Label player2ActionLabel;
    }
}