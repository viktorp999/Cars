namespace CarsMain
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.GameMenu = new System.Windows.Forms.MenuStrip();
            this.Game = new System.Windows.Forms.ToolStripMenuItem();
            this.NewGame = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveGame = new System.Windows.Forms.ToolStripMenuItem();
            this.MoneyText = new System.Windows.Forms.Label();
            this.MoneyL = new System.Windows.Forms.Label();
            this.PointsL = new System.Windows.Forms.Label();
            this.PointsText = new System.Windows.Forms.Label();
            this.LevelL = new System.Windows.Forms.Label();
            this.LevelText = new System.Windows.Forms.Label();
            this.LevelProgress = new System.Windows.Forms.ProgressBar();
            this.StoleCarText = new System.Windows.Forms.Label();
            this.StoleB = new System.Windows.Forms.Button();
            this.ChanceL = new System.Windows.Forms.Label();
            this.ChanceText = new System.Windows.Forms.Label();
            this.GarageB = new System.Windows.Forms.Button();
            this.HealthText = new System.Windows.Forms.Label();
            this.Health = new System.Windows.Forms.ProgressBar();
            this.HealB = new System.Windows.Forms.Button();
            this.GameMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // GameMenu
            // 
            this.GameMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Game});
            this.GameMenu.Location = new System.Drawing.Point(0, 0);
            this.GameMenu.Name = "GameMenu";
            this.GameMenu.Size = new System.Drawing.Size(688, 24);
            this.GameMenu.TabIndex = 0;
            this.GameMenu.Text = "Menu";
            // 
            // Game
            // 
            this.Game.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewGame,
            this.SaveGame});
            this.Game.Name = "Game";
            this.Game.Size = new System.Drawing.Size(50, 20);
            this.Game.Text = "Game";
            // 
            // NewGame
            // 
            this.NewGame.Name = "NewGame";
            this.NewGame.Size = new System.Drawing.Size(98, 22);
            this.NewGame.Text = "New";
            this.NewGame.Click += new System.EventHandler(this.NewClick);
            // 
            // SaveGame
            // 
            this.SaveGame.Name = "SaveGame";
            this.SaveGame.Size = new System.Drawing.Size(98, 22);
            this.SaveGame.Text = "Save";
            this.SaveGame.Click += new System.EventHandler(this.SaveClick);
            // 
            // MoneyText
            // 
            this.MoneyText.AutoSize = true;
            this.MoneyText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoneyText.Location = new System.Drawing.Point(12, 45);
            this.MoneyText.Name = "MoneyText";
            this.MoneyText.Size = new System.Drawing.Size(84, 25);
            this.MoneyText.TabIndex = 1;
            this.MoneyText.Text = "Money:";
            // 
            // MoneyL
            // 
            this.MoneyL.AutoSize = true;
            this.MoneyL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoneyL.Location = new System.Drawing.Point(102, 45);
            this.MoneyL.Name = "MoneyL";
            this.MoneyL.Size = new System.Drawing.Size(42, 25);
            this.MoneyL.TabIndex = 2;
            this.MoneyL.Text = "0 $";
            // 
            // PointsL
            // 
            this.PointsL.AutoSize = true;
            this.PointsL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PointsL.Location = new System.Drawing.Point(97, 97);
            this.PointsL.Name = "PointsL";
            this.PointsL.Size = new System.Drawing.Size(24, 25);
            this.PointsL.TabIndex = 5;
            this.PointsL.Text = "0";
            // 
            // PointsText
            // 
            this.PointsText.AutoSize = true;
            this.PointsText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PointsText.Location = new System.Drawing.Point(12, 97);
            this.PointsText.Name = "PointsText";
            this.PointsText.Size = new System.Drawing.Size(79, 25);
            this.PointsText.TabIndex = 4;
            this.PointsText.Text = "Points:";
            // 
            // LevelL
            // 
            this.LevelL.AutoSize = true;
            this.LevelL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LevelL.Location = new System.Drawing.Point(89, 152);
            this.LevelL.Name = "LevelL";
            this.LevelL.Size = new System.Drawing.Size(24, 25);
            this.LevelL.TabIndex = 7;
            this.LevelL.Text = "0";
            // 
            // LevelText
            // 
            this.LevelText.AutoSize = true;
            this.LevelText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LevelText.Location = new System.Drawing.Point(12, 152);
            this.LevelText.Name = "LevelText";
            this.LevelText.Size = new System.Drawing.Size(71, 25);
            this.LevelText.TabIndex = 6;
            this.LevelText.Text = "Level:";
            // 
            // LevelProgress
            // 
            this.LevelProgress.Location = new System.Drawing.Point(119, 154);
            this.LevelProgress.Name = "LevelProgress";
            this.LevelProgress.Size = new System.Drawing.Size(100, 23);
            this.LevelProgress.TabIndex = 8;
            // 
            // StoleCarText
            // 
            this.StoleCarText.AutoSize = true;
            this.StoleCarText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StoleCarText.Location = new System.Drawing.Point(385, 45);
            this.StoleCarText.Name = "StoleCarText";
            this.StoleCarText.Size = new System.Drawing.Size(103, 25);
            this.StoleCarText.TabIndex = 9;
            this.StoleCarText.Text = "Stole Car";
            // 
            // StoleB
            // 
            this.StoleB.Location = new System.Drawing.Point(390, 156);
            this.StoleB.Name = "StoleB";
            this.StoleB.Size = new System.Drawing.Size(75, 23);
            this.StoleB.TabIndex = 10;
            this.StoleB.Text = "Stole";
            this.StoleB.UseVisualStyleBackColor = true;
            this.StoleB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.StoleClick);
            // 
            // ChanceL
            // 
            this.ChanceL.AutoSize = true;
            this.ChanceL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChanceL.Location = new System.Drawing.Point(485, 97);
            this.ChanceL.Name = "ChanceL";
            this.ChanceL.Size = new System.Drawing.Size(49, 25);
            this.ChanceL.TabIndex = 12;
            this.ChanceL.Text = "0 %";
            // 
            // ChanceText
            // 
            this.ChanceText.AutoSize = true;
            this.ChanceText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChanceText.Location = new System.Drawing.Point(385, 97);
            this.ChanceText.Name = "ChanceText";
            this.ChanceText.Size = new System.Drawing.Size(94, 25);
            this.ChanceText.TabIndex = 11;
            this.ChanceText.Text = "Chance:";
            // 
            // GarageB
            // 
            this.GarageB.Location = new System.Drawing.Point(471, 156);
            this.GarageB.Name = "GarageB";
            this.GarageB.Size = new System.Drawing.Size(75, 23);
            this.GarageB.TabIndex = 14;
            this.GarageB.Text = "Garage";
            this.GarageB.UseVisualStyleBackColor = true;
            this.GarageB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.GarageClick);
            // 
            // HealthText
            // 
            this.HealthText.AutoSize = true;
            this.HealthText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HealthText.Location = new System.Drawing.Point(12, 210);
            this.HealthText.Name = "HealthText";
            this.HealthText.Size = new System.Drawing.Size(81, 25);
            this.HealthText.TabIndex = 15;
            this.HealthText.Text = "Health:";
            // 
            // Health
            // 
            this.Health.Location = new System.Drawing.Point(99, 212);
            this.Health.Name = "Health";
            this.Health.Size = new System.Drawing.Size(100, 23);
            this.Health.TabIndex = 16;
            // 
            // HealB
            // 
            this.HealB.Location = new System.Drawing.Point(205, 212);
            this.HealB.Name = "HealB";
            this.HealB.Size = new System.Drawing.Size(75, 23);
            this.HealB.TabIndex = 17;
            this.HealB.Text = "Heal";
            this.HealB.UseVisualStyleBackColor = true;
            this.HealB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.HealClick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 280);
            this.Controls.Add(this.HealB);
            this.Controls.Add(this.Health);
            this.Controls.Add(this.HealthText);
            this.Controls.Add(this.GarageB);
            this.Controls.Add(this.ChanceL);
            this.Controls.Add(this.ChanceText);
            this.Controls.Add(this.StoleB);
            this.Controls.Add(this.StoleCarText);
            this.Controls.Add(this.LevelProgress);
            this.Controls.Add(this.LevelL);
            this.Controls.Add(this.LevelText);
            this.Controls.Add(this.PointsL);
            this.Controls.Add(this.PointsText);
            this.Controls.Add(this.MoneyL);
            this.Controls.Add(this.MoneyText);
            this.Controls.Add(this.GameMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.GameMenu;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cars";
            this.Load += new System.EventHandler(this.MainLoad);
            this.GameMenu.ResumeLayout(false);
            this.GameMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip GameMenu;
        private System.Windows.Forms.ToolStripMenuItem Game;
        private System.Windows.Forms.ToolStripMenuItem NewGame;
        private System.Windows.Forms.ToolStripMenuItem SaveGame;
        private System.Windows.Forms.Label MoneyText;
        private System.Windows.Forms.Label PointsL;
        private System.Windows.Forms.Label PointsText;
        private System.Windows.Forms.Label LevelL;
        private System.Windows.Forms.Label LevelText;
        private System.Windows.Forms.ProgressBar LevelProgress;
        private System.Windows.Forms.Label StoleCarText;
        private System.Windows.Forms.Button StoleB;
        private System.Windows.Forms.Label ChanceL;
        private System.Windows.Forms.Label ChanceText;
        private System.Windows.Forms.Button GarageB;
        public System.Windows.Forms.Label MoneyL;
        private System.Windows.Forms.Label HealthText;
        private System.Windows.Forms.ProgressBar Health;
        private System.Windows.Forms.Button HealB;
    }
}

