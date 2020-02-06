namespace Greenhorn_Innkeeper_
{
    partial class FormMarketPlace
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMarketPlace));
            this.labelMarketPlace = new System.Windows.Forms.Label();
            this.pictureBoxGold = new System.Windows.Forms.PictureBox();
            this.labelGoldNumber = new System.Windows.Forms.Label();
            this.pictureBoxBeer = new System.Windows.Forms.PictureBox();
            this.pictureBoxFood = new System.Windows.Forms.PictureBox();
            this.labelBeerNumber = new System.Windows.Forms.Label();
            this.labelFoodNumber = new System.Windows.Forms.Label();
            this.buttonPlusBeer = new System.Windows.Forms.Button();
            this.buttonPlusFood = new System.Windows.Forms.Button();
            this.buttonMinusBeer = new System.Windows.Forms.Button();
            this.buttonMinusFood = new System.Windows.Forms.Button();
            this.labelPrice = new System.Windows.Forms.Label();
            this.buttonBuy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBeer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFood)).BeginInit();
            this.SuspendLayout();
            // 
            // labelMarketPlace
            // 
            this.labelMarketPlace.AutoSize = true;
            this.labelMarketPlace.BackColor = System.Drawing.Color.Transparent;
            this.labelMarketPlace.Font = new System.Drawing.Font("Segoe Script", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMarketPlace.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelMarketPlace.Location = new System.Drawing.Point(260, 9);
            this.labelMarketPlace.Name = "labelMarketPlace";
            this.labelMarketPlace.Size = new System.Drawing.Size(387, 52);
            this.labelMarketPlace.TabIndex = 1;
            this.labelMarketPlace.Text = "Jesteś na targowisku!";
            // 
            // pictureBoxGold
            // 
            this.pictureBoxGold.BackgroundImage = global::Greenhorn_Innkeeper_.Properties.Resources.Coins;
            this.pictureBoxGold.Location = new System.Drawing.Point(13, 13);
            this.pictureBoxGold.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxGold.Name = "pictureBoxGold";
            this.pictureBoxGold.Size = new System.Drawing.Size(105, 95);
            this.pictureBoxGold.TabIndex = 9;
            this.pictureBoxGold.TabStop = false;
            // 
            // labelGoldNumber
            // 
            this.labelGoldNumber.AutoSize = true;
            this.labelGoldNumber.BackColor = System.Drawing.Color.Transparent;
            this.labelGoldNumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelGoldNumber.Font = new System.Drawing.Font("Segoe Script", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGoldNumber.ForeColor = System.Drawing.Color.Gold;
            this.labelGoldNumber.Location = new System.Drawing.Point(126, 13);
            this.labelGoldNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelGoldNumber.Name = "labelGoldNumber";
            this.labelGoldNumber.Size = new System.Drawing.Size(84, 95);
            this.labelGoldNumber.TabIndex = 10;
            this.labelGoldNumber.Text = "0";
            // 
            // pictureBoxBeer
            // 
            this.pictureBoxBeer.BackgroundImage = global::Greenhorn_Innkeeper_.Properties.Resources.MugOfBeer;
            this.pictureBoxBeer.Location = new System.Drawing.Point(218, 270);
            this.pictureBoxBeer.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxBeer.Name = "pictureBoxBeer";
            this.pictureBoxBeer.Size = new System.Drawing.Size(105, 95);
            this.pictureBoxBeer.TabIndex = 11;
            this.pictureBoxBeer.TabStop = false;
            // 
            // pictureBoxFood
            // 
            this.pictureBoxFood.BackgroundImage = global::Greenhorn_Innkeeper_.Properties.Resources.Food;
            this.pictureBoxFood.Location = new System.Drawing.Point(599, 270);
            this.pictureBoxFood.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxFood.Name = "pictureBoxFood";
            this.pictureBoxFood.Size = new System.Drawing.Size(114, 95);
            this.pictureBoxFood.TabIndex = 12;
            this.pictureBoxFood.TabStop = false;
            // 
            // labelBeerNumber
            // 
            this.labelBeerNumber.AutoSize = true;
            this.labelBeerNumber.BackColor = System.Drawing.Color.Transparent;
            this.labelBeerNumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelBeerNumber.Font = new System.Drawing.Font("Segoe Script", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBeerNumber.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelBeerNumber.Location = new System.Drawing.Point(230, 171);
            this.labelBeerNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBeerNumber.Name = "labelBeerNumber";
            this.labelBeerNumber.Size = new System.Drawing.Size(84, 95);
            this.labelBeerNumber.TabIndex = 13;
            this.labelBeerNumber.Text = "0";
            // 
            // labelFoodNumber
            // 
            this.labelFoodNumber.AutoSize = true;
            this.labelFoodNumber.BackColor = System.Drawing.Color.Transparent;
            this.labelFoodNumber.Font = new System.Drawing.Font("Segoe Script", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFoodNumber.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelFoodNumber.Location = new System.Drawing.Point(616, 171);
            this.labelFoodNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFoodNumber.Name = "labelFoodNumber";
            this.labelFoodNumber.Size = new System.Drawing.Size(84, 95);
            this.labelFoodNumber.TabIndex = 14;
            this.labelFoodNumber.Text = "0";
            // 
            // buttonPlusBeer
            // 
            this.buttonPlusBeer.BackColor = System.Drawing.Color.Transparent;
            this.buttonPlusBeer.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPlusBeer.Location = new System.Drawing.Point(341, 289);
            this.buttonPlusBeer.Name = "buttonPlusBeer";
            this.buttonPlusBeer.Size = new System.Drawing.Size(85, 61);
            this.buttonPlusBeer.TabIndex = 15;
            this.buttonPlusBeer.Text = "+";
            this.buttonPlusBeer.UseVisualStyleBackColor = false;
            this.buttonPlusBeer.Click += new System.EventHandler(this.buttonPlusBeer_Click);
            // 
            // buttonPlusFood
            // 
            this.buttonPlusFood.BackColor = System.Drawing.Color.Transparent;
            this.buttonPlusFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPlusFood.Location = new System.Drawing.Point(736, 289);
            this.buttonPlusFood.Name = "buttonPlusFood";
            this.buttonPlusFood.Size = new System.Drawing.Size(85, 61);
            this.buttonPlusFood.TabIndex = 16;
            this.buttonPlusFood.Text = "+";
            this.buttonPlusFood.UseVisualStyleBackColor = false;
            this.buttonPlusFood.Click += new System.EventHandler(this.buttonPlusFood_Click);
            // 
            // buttonMinusBeer
            // 
            this.buttonMinusBeer.BackColor = System.Drawing.Color.Transparent;
            this.buttonMinusBeer.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonMinusBeer.Location = new System.Drawing.Point(115, 289);
            this.buttonMinusBeer.Name = "buttonMinusBeer";
            this.buttonMinusBeer.Size = new System.Drawing.Size(85, 61);
            this.buttonMinusBeer.TabIndex = 17;
            this.buttonMinusBeer.Text = "-";
            this.buttonMinusBeer.UseVisualStyleBackColor = false;
            this.buttonMinusBeer.Click += new System.EventHandler(this.buttonMinusBeer_Click);
            // 
            // buttonMinusFood
            // 
            this.buttonMinusFood.BackColor = System.Drawing.Color.Transparent;
            this.buttonMinusFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonMinusFood.Location = new System.Drawing.Point(493, 289);
            this.buttonMinusFood.Name = "buttonMinusFood";
            this.buttonMinusFood.Size = new System.Drawing.Size(85, 61);
            this.buttonMinusFood.TabIndex = 18;
            this.buttonMinusFood.Text = "-";
            this.buttonMinusFood.UseVisualStyleBackColor = false;
            this.buttonMinusFood.Click += new System.EventHandler(this.buttonMinusFood_Click);
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.BackColor = System.Drawing.Color.Transparent;
            this.labelPrice.Font = new System.Drawing.Font("Segoe Script", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPrice.ForeColor = System.Drawing.Color.Red;
            this.labelPrice.Location = new System.Drawing.Point(260, 430);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(244, 52);
            this.labelPrice.TabIndex = 19;
            this.labelPrice.Text = "Cała cena to:";
            // 
            // buttonBuy
            // 
            this.buttonBuy.BackColor = System.Drawing.Color.Transparent;
            this.buttonBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonBuy.Location = new System.Drawing.Point(671, 423);
            this.buttonBuy.Name = "buttonBuy";
            this.buttonBuy.Size = new System.Drawing.Size(85, 61);
            this.buttonBuy.TabIndex = 20;
            this.buttonBuy.Text = "Kupuje!";
            this.buttonBuy.UseVisualStyleBackColor = false;
            this.buttonBuy.Click += new System.EventHandler(this.buttonBuy_Click);
            // 
            // FormMarketPlace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Greenhorn_Innkeeper_.Properties.Resources.Marketplace;
            this.ClientSize = new System.Drawing.Size(891, 527);
            this.Controls.Add(this.buttonBuy);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.buttonMinusFood);
            this.Controls.Add(this.buttonMinusBeer);
            this.Controls.Add(this.buttonPlusFood);
            this.Controls.Add(this.buttonPlusBeer);
            this.Controls.Add(this.labelFoodNumber);
            this.Controls.Add(this.labelBeerNumber);
            this.Controls.Add(this.pictureBoxFood);
            this.Controls.Add(this.pictureBoxBeer);
            this.Controls.Add(this.labelGoldNumber);
            this.Controls.Add(this.pictureBoxGold);
            this.Controls.Add(this.labelMarketPlace);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMarketPlace";
            this.Text = "Marketplace";
            this.Load += new System.EventHandler(this.FormMarketPlace_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBeer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFood)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMarketPlace;
        private System.Windows.Forms.PictureBox pictureBoxGold;
        private System.Windows.Forms.Label labelGoldNumber;
        private System.Windows.Forms.PictureBox pictureBoxBeer;
        private System.Windows.Forms.PictureBox pictureBoxFood;
        private System.Windows.Forms.Label labelBeerNumber;
        private System.Windows.Forms.Label labelFoodNumber;
        private System.Windows.Forms.Button buttonPlusBeer;
        private System.Windows.Forms.Button buttonPlusFood;
        private System.Windows.Forms.Button buttonMinusBeer;
        private System.Windows.Forms.Button buttonMinusFood;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Button buttonBuy;
    }
}