namespace EMS
{
    partial class GameWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameWindow));
            this.startTurnButton = new System.Windows.Forms.Button();
            this.actionSelectionComboBox = new System.Windows.Forms.ComboBox();
            this.TurnResultTextBox = new System.Windows.Forms.TextBox();
            this.playerHealthLabel = new System.Windows.Forms.Label();
            this.monsterHealthLabel = new System.Windows.Forms.Label();
            this.PlayerPics = new System.Windows.Forms.PictureBox();
            this.MonsterPics = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PlayerPics)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MonsterPics)).BeginInit();
            this.SuspendLayout();
            // 
            // startTurnButton
            // 
            this.startTurnButton.Location = new System.Drawing.Point(992, 604);
            this.startTurnButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.startTurnButton.Name = "startTurnButton";
            this.startTurnButton.Size = new System.Drawing.Size(423, 114);
            this.startTurnButton.TabIndex = 0;
            this.startTurnButton.Text = "Attack!";
            this.startTurnButton.UseVisualStyleBackColor = true;
            this.startTurnButton.Click += new System.EventHandler(this.startTurnButton_Click);
            // 
            // actionSelectionComboBox
            // 
            this.actionSelectionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.actionSelectionComboBox.FormattingEnabled = true;
            this.actionSelectionComboBox.Location = new System.Drawing.Point(120, 674);
            this.actionSelectionComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.actionSelectionComboBox.Name = "actionSelectionComboBox";
            this.actionSelectionComboBox.Size = new System.Drawing.Size(616, 24);
            this.actionSelectionComboBox.TabIndex = 1;
            // 
            // TurnResultTextBox
            // 
            this.TurnResultTextBox.Location = new System.Drawing.Point(16, 487);
            this.TurnResultTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TurnResultTextBox.Multiline = true;
            this.TurnResultTextBox.Name = "TurnResultTextBox";
            this.TurnResultTextBox.ReadOnly = true;
            this.TurnResultTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TurnResultTextBox.Size = new System.Drawing.Size(875, 179);
            this.TurnResultTextBox.TabIndex = 3;
            this.TurnResultTextBox.TextChanged += new System.EventHandler(this.TurnResultTextBox_TextChanged);
            // 
            // playerHealthLabel
            // 
            this.playerHealthLabel.AutoSize = true;
            this.playerHealthLabel.Location = new System.Drawing.Point(269, 439);
            this.playerHealthLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.playerHealthLabel.Name = "playerHealthLabel";
            this.playerHealthLabel.Size = new System.Drawing.Size(0, 17);
            this.playerHealthLabel.TabIndex = 4;
            // 
            // monsterHealthLabel
            // 
            this.monsterHealthLabel.AutoSize = true;
            this.monsterHealthLabel.Location = new System.Drawing.Point(1095, 439);
            this.monsterHealthLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.monsterHealthLabel.Name = "monsterHealthLabel";
            this.monsterHealthLabel.Size = new System.Drawing.Size(0, 17);
            this.monsterHealthLabel.TabIndex = 5;
            // 
            // PlayerPics
            // 
            this.PlayerPics.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PlayerPics.Location = new System.Drawing.Point(189, 41);
            this.PlayerPics.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PlayerPics.Name = "PlayerPics";
            this.PlayerPics.Size = new System.Drawing.Size(456, 373);
            this.PlayerPics.TabIndex = 6;
            this.PlayerPics.TabStop = false;
            // 
            // MonsterPics
            // 
            this.MonsterPics.Location = new System.Drawing.Point(992, 41);
            this.MonsterPics.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MonsterPics.Name = "MonsterPics";
            this.MonsterPics.Size = new System.Drawing.Size(457, 340);
            this.MonsterPics.TabIndex = 7;
            this.MonsterPics.TabStop = false;
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
            // GameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1488, 734);
            this.Controls.Add(this.MonsterPics);
            this.Controls.Add(this.PlayerPics);
            this.Controls.Add(this.monsterHealthLabel);
            this.Controls.Add(this.playerHealthLabel);
            this.Controls.Add(this.TurnResultTextBox);
            this.Controls.Add(this.actionSelectionComboBox);
            this.Controls.Add(this.startTurnButton);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "GameWindow";
            this.Text = "Epic Monster Showdown";
            ((System.ComponentModel.ISupportInitialize)(this.PlayerPics)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MonsterPics)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startTurnButton;
        private System.Windows.Forms.ComboBox actionSelectionComboBox;
        public System.Windows.Forms.TextBox TurnResultTextBox;
        private System.Windows.Forms.Label playerHealthLabel;
        private System.Windows.Forms.Label monsterHealthLabel;
        private System.Windows.Forms.PictureBox PlayerPics;
        private System.Windows.Forms.PictureBox MonsterPics;
        private System.Windows.Forms.ImageList imageList1;
    }
}