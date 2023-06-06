namespace CarsMain
{
    partial class Garage
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
            this.CarGarage = new System.Windows.Forms.ListBox();
            this.DamageText = new System.Windows.Forms.Label();
            this.DamageL = new System.Windows.Forms.Label();
            this.RepairPriceL = new System.Windows.Forms.Label();
            this.RepairText = new System.Windows.Forms.Label();
            this.SellPriceL = new System.Windows.Forms.Label();
            this.SellText = new System.Windows.Forms.Label();
            this.RepairB = new System.Windows.Forms.Button();
            this.SellB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CarGarage
            // 
            this.CarGarage.FormattingEnabled = true;
            this.CarGarage.Location = new System.Drawing.Point(12, 12);
            this.CarGarage.Name = "CarGarage";
            this.CarGarage.Size = new System.Drawing.Size(245, 420);
            this.CarGarage.TabIndex = 0;
            this.CarGarage.SelectedIndexChanged += new System.EventHandler(this.CarGarage_SelectedIndexChanged);
            // 
            // DamageText
            // 
            this.DamageText.AutoSize = true;
            this.DamageText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DamageText.Location = new System.Drawing.Point(263, 12);
            this.DamageText.Name = "DamageText";
            this.DamageText.Size = new System.Drawing.Size(99, 25);
            this.DamageText.TabIndex = 1;
            this.DamageText.Text = "Damage:";
            // 
            // DamageL
            // 
            this.DamageL.AutoSize = true;
            this.DamageL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DamageL.Location = new System.Drawing.Point(368, 12);
            this.DamageL.Name = "DamageL";
            this.DamageL.Size = new System.Drawing.Size(49, 25);
            this.DamageL.TabIndex = 2;
            this.DamageL.Text = "0 %";
            // 
            // RepairPriceL
            // 
            this.RepairPriceL.AutoSize = true;
            this.RepairPriceL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RepairPriceL.Location = new System.Drawing.Point(405, 58);
            this.RepairPriceL.Name = "RepairPriceL";
            this.RepairPriceL.Size = new System.Drawing.Size(42, 25);
            this.RepairPriceL.TabIndex = 5;
            this.RepairPriceL.Text = "0 $";
            // 
            // RepairText
            // 
            this.RepairText.AutoSize = true;
            this.RepairText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RepairText.Location = new System.Drawing.Point(263, 58);
            this.RepairText.Name = "RepairText";
            this.RepairText.Size = new System.Drawing.Size(136, 25);
            this.RepairText.TabIndex = 4;
            this.RepairText.Text = "Repair Price:";
            // 
            // SellPriceL
            // 
            this.SellPriceL.AutoSize = true;
            this.SellPriceL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SellPriceL.Location = new System.Drawing.Point(380, 108);
            this.SellPriceL.Name = "SellPriceL";
            this.SellPriceL.Size = new System.Drawing.Size(42, 25);
            this.SellPriceL.TabIndex = 8;
            this.SellPriceL.Text = "0 $";
            // 
            // SellText
            // 
            this.SellText.AutoSize = true;
            this.SellText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SellText.Location = new System.Drawing.Point(263, 108);
            this.SellText.Name = "SellText";
            this.SellText.Size = new System.Drawing.Size(111, 25);
            this.SellText.TabIndex = 7;
            this.SellText.Text = "Sell Price:";
            // 
            // RepairB
            // 
            this.RepairB.Location = new System.Drawing.Point(268, 163);
            this.RepairB.Name = "RepairB";
            this.RepairB.Size = new System.Drawing.Size(75, 23);
            this.RepairB.TabIndex = 10;
            this.RepairB.Text = "Repair";
            this.RepairB.UseVisualStyleBackColor = true;
            this.RepairB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.RepairClick);
            // 
            // SellB
            // 
            this.SellB.Location = new System.Drawing.Point(349, 163);
            this.SellB.Name = "SellB";
            this.SellB.Size = new System.Drawing.Size(75, 23);
            this.SellB.TabIndex = 11;
            this.SellB.Text = "Sell";
            this.SellB.UseVisualStyleBackColor = true;
            this.SellB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SellClick);
            // 
            // Garage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 450);
            this.Controls.Add(this.SellB);
            this.Controls.Add(this.RepairB);
            this.Controls.Add(this.SellPriceL);
            this.Controls.Add(this.SellText);
            this.Controls.Add(this.RepairPriceL);
            this.Controls.Add(this.RepairText);
            this.Controls.Add(this.DamageL);
            this.Controls.Add(this.DamageText);
            this.Controls.Add(this.CarGarage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Garage";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Garage";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GarageClosed);
            this.Load += new System.EventHandler(this.GarageLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label DamageText;
        private System.Windows.Forms.Label DamageL;
        private System.Windows.Forms.Label RepairPriceL;
        private System.Windows.Forms.Label RepairText;
        private System.Windows.Forms.Label SellPriceL;
        private System.Windows.Forms.Label SellText;
        private System.Windows.Forms.Button RepairB;
        private System.Windows.Forms.Button SellB;
        public System.Windows.Forms.ListBox CarGarage;
    }
}