namespace Greenhorn_Innkeeper_
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.labelBeerNumber = new System.Windows.Forms.Label();
            this.labelFoodNumber = new System.Windows.Forms.Label();
            this.timerTime = new System.Windows.Forms.Timer(this.components);
            this.labelGoldNumber = new System.Windows.Forms.Label();
            this.pictureBoxFood = new System.Windows.Forms.PictureBox();
            this.pictureBoxBeer = new System.Windows.Forms.PictureBox();
            this.pictureBoxGold = new System.Windows.Forms.PictureBox();
            this.labelDrinkingGame = new System.Windows.Forms.Label();
            this.buttonDrinkingGame = new System.Windows.Forms.Button();
            this.labelPoker = new System.Windows.Forms.Label();
            this.buttonPoker = new System.Windows.Forms.Button();
            this.labelRoom1 = new System.Windows.Forms.Label();
            this.labelRoom2 = new System.Windows.Forms.Label();
            this.labelRoom3 = new System.Windows.Forms.Label();
            this.labelRoom4 = new System.Windows.Forms.Label();
            this.buttonResupply = new System.Windows.Forms.Button();
            this.listViewGuests = new System.Windows.Forms.ListView();
            this.groupBoxGuests = new System.Windows.Forms.GroupBox();
            this.labelDay = new System.Windows.Forms.Label();
            this.progressBarDay = new System.Windows.Forms.ProgressBar();
            this.buttonPause = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBeer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGold)).BeginInit();
            this.groupBoxGuests.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelBeerNumber
            // 
            this.labelBeerNumber.AutoSize = true;
            this.labelBeerNumber.BackColor = System.Drawing.Color.Transparent;
            this.labelBeerNumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelBeerNumber.Font = new System.Drawing.Font("Segoe Script", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBeerNumber.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelBeerNumber.Location = new System.Drawing.Point(150, 736);
            this.labelBeerNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBeerNumber.Name = "labelBeerNumber";
            this.labelBeerNumber.Size = new System.Drawing.Size(84, 95);
            this.labelBeerNumber.TabIndex = 2;
            this.labelBeerNumber.Text = "0";
            // 
            // labelFoodNumber
            // 
            this.labelFoodNumber.AutoSize = true;
            this.labelFoodNumber.BackColor = System.Drawing.Color.Transparent;
            this.labelFoodNumber.Font = new System.Drawing.Font("Segoe Script", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFoodNumber.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelFoodNumber.Location = new System.Drawing.Point(150, 849);
            this.labelFoodNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFoodNumber.Name = "labelFoodNumber";
            this.labelFoodNumber.Size = new System.Drawing.Size(84, 95);
            this.labelFoodNumber.TabIndex = 3;
            this.labelFoodNumber.Text = "0";
            // 
            // timerTime
            // 
            this.timerTime.Tick += new System.EventHandler(this.timerTime_Tick);
            // 
            // labelGoldNumber
            // 
            this.labelGoldNumber.AutoSize = true;
            this.labelGoldNumber.BackColor = System.Drawing.Color.Transparent;
            this.labelGoldNumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelGoldNumber.Font = new System.Drawing.Font("Segoe Script", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGoldNumber.ForeColor = System.Drawing.Color.Gold;
            this.labelGoldNumber.Location = new System.Drawing.Point(150, 628);
            this.labelGoldNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelGoldNumber.Name = "labelGoldNumber";
            this.labelGoldNumber.Size = new System.Drawing.Size(84, 95);
            this.labelGoldNumber.TabIndex = 5;
            this.labelGoldNumber.Text = "0";
            // 
            // pictureBoxFood
            // 
            this.pictureBoxFood.BackgroundImage = global::Greenhorn_Innkeeper_.Properties.Resources.Food;
            this.pictureBoxFood.Location = new System.Drawing.Point(28, 849);
            this.pictureBoxFood.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxFood.Name = "pictureBoxFood";
            this.pictureBoxFood.Size = new System.Drawing.Size(114, 95);
            this.pictureBoxFood.TabIndex = 6;
            this.pictureBoxFood.TabStop = false;
            // 
            // pictureBoxBeer
            // 
            this.pictureBoxBeer.BackgroundImage = global::Greenhorn_Innkeeper_.Properties.Resources.MugOfBeer;
            this.pictureBoxBeer.Location = new System.Drawing.Point(28, 736);
            this.pictureBoxBeer.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxBeer.Name = "pictureBoxBeer";
            this.pictureBoxBeer.Size = new System.Drawing.Size(105, 95);
            this.pictureBoxBeer.TabIndex = 7;
            this.pictureBoxBeer.TabStop = false;
            // 
            // pictureBoxGold
            // 
            this.pictureBoxGold.BackgroundImage = global::Greenhorn_Innkeeper_.Properties.Resources.Coins;
            this.pictureBoxGold.Location = new System.Drawing.Point(28, 628);
            this.pictureBoxGold.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxGold.Name = "pictureBoxGold";
            this.pictureBoxGold.Size = new System.Drawing.Size(105, 95);
            this.pictureBoxGold.TabIndex = 8;
            this.pictureBoxGold.TabStop = false;
            // 
            // labelDrinkingGame
            // 
            this.labelDrinkingGame.AutoSize = true;
            this.labelDrinkingGame.BackColor = System.Drawing.Color.Transparent;
            this.labelDrinkingGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelDrinkingGame.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDrinkingGame.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelDrinkingGame.Location = new System.Drawing.Point(1244, 605);
            this.labelDrinkingGame.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDrinkingGame.Name = "labelDrinkingGame";
            this.labelDrinkingGame.Size = new System.Drawing.Size(261, 32);
            this.labelDrinkingGame.TabIndex = 9;
            this.labelDrinkingGame.Text = "Zorganizuj pijacką grę!";
            // 
            // buttonDrinkingGame
            // 
            this.buttonDrinkingGame.BackColor = System.Drawing.Color.Sienna;
            this.buttonDrinkingGame.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDrinkingGame.ForeColor = System.Drawing.Color.White;
            this.buttonDrinkingGame.Location = new System.Drawing.Point(1339, 640);
            this.buttonDrinkingGame.Name = "buttonDrinkingGame";
            this.buttonDrinkingGame.Size = new System.Drawing.Size(75, 28);
            this.buttonDrinkingGame.TabIndex = 10;
            this.buttonDrinkingGame.Text = "Pijmy!";
            this.buttonDrinkingGame.UseVisualStyleBackColor = false;
            this.buttonDrinkingGame.Click += new System.EventHandler(this.buttonDrinkingGame_Click);
            // 
            // labelPoker
            // 
            this.labelPoker.AutoSize = true;
            this.labelPoker.BackColor = System.Drawing.Color.Transparent;
            this.labelPoker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelPoker.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPoker.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelPoker.Location = new System.Drawing.Point(545, 400);
            this.labelPoker.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPoker.Name = "labelPoker";
            this.labelPoker.Size = new System.Drawing.Size(138, 32);
            this.labelPoker.TabIndex = 11;
            this.labelPoker.Text = "Noc pokera!";
            // 
            // buttonPoker
            // 
            this.buttonPoker.BackColor = System.Drawing.Color.Sienna;
            this.buttonPoker.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPoker.ForeColor = System.Drawing.Color.White;
            this.buttonPoker.Location = new System.Drawing.Point(577, 435);
            this.buttonPoker.Name = "buttonPoker";
            this.buttonPoker.Size = new System.Drawing.Size(75, 28);
            this.buttonPoker.TabIndex = 12;
            this.buttonPoker.Text = "Grajmy!";
            this.buttonPoker.UseVisualStyleBackColor = false;
            this.buttonPoker.Click += new System.EventHandler(this.buttonPoker_Click);
            // 
            // labelRoom1
            // 
            this.labelRoom1.AutoSize = true;
            this.labelRoom1.BackColor = System.Drawing.Color.Transparent;
            this.labelRoom1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelRoom1.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelRoom1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelRoom1.Location = new System.Drawing.Point(740, 19);
            this.labelRoom1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRoom1.Name = "labelRoom1";
            this.labelRoom1.Size = new System.Drawing.Size(85, 32);
            this.labelRoom1.TabIndex = 13;
            this.labelRoom1.Text = "Wolne!";
            // 
            // labelRoom2
            // 
            this.labelRoom2.AutoSize = true;
            this.labelRoom2.BackColor = System.Drawing.Color.Transparent;
            this.labelRoom2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelRoom2.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelRoom2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelRoom2.Location = new System.Drawing.Point(1004, 39);
            this.labelRoom2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRoom2.Name = "labelRoom2";
            this.labelRoom2.Size = new System.Drawing.Size(85, 32);
            this.labelRoom2.TabIndex = 14;
            this.labelRoom2.Text = "Wolne!";
            // 
            // labelRoom3
            // 
            this.labelRoom3.AutoSize = true;
            this.labelRoom3.BackColor = System.Drawing.Color.Transparent;
            this.labelRoom3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelRoom3.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelRoom3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelRoom3.Location = new System.Drawing.Point(1343, 73);
            this.labelRoom3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRoom3.Name = "labelRoom3";
            this.labelRoom3.Size = new System.Drawing.Size(85, 32);
            this.labelRoom3.TabIndex = 15;
            this.labelRoom3.Text = "Wolne!";
            // 
            // labelRoom4
            // 
            this.labelRoom4.AutoSize = true;
            this.labelRoom4.BackColor = System.Drawing.Color.Transparent;
            this.labelRoom4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelRoom4.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelRoom4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelRoom4.Location = new System.Drawing.Point(1782, 102);
            this.labelRoom4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRoom4.Name = "labelRoom4";
            this.labelRoom4.Size = new System.Drawing.Size(85, 32);
            this.labelRoom4.TabIndex = 16;
            this.labelRoom4.Text = "Wolne!";
            // 
            // buttonResupply
            // 
            this.buttonResupply.AutoSize = true;
            this.buttonResupply.BackColor = System.Drawing.Color.DarkRed;
            this.buttonResupply.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonResupply.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonResupply.ForeColor = System.Drawing.Color.White;
            this.buttonResupply.Location = new System.Drawing.Point(1105, 890);
            this.buttonResupply.Name = "buttonResupply";
            this.buttonResupply.Size = new System.Drawing.Size(274, 54);
            this.buttonResupply.TabIndex = 17;
            this.buttonResupply.Text = "Uzupełnienie zapasów!";
            this.buttonResupply.UseVisualStyleBackColor = false;
            this.buttonResupply.Click += new System.EventHandler(this.buttonResupply_Click);
            // 
            // listViewGuests
            // 
            this.listViewGuests.BackColor = System.Drawing.Color.SaddleBrown;
            this.listViewGuests.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listViewGuests.ForeColor = System.Drawing.SystemColors.Window;
            this.listViewGuests.HideSelection = false;
            this.listViewGuests.Location = new System.Drawing.Point(0, 21);
            this.listViewGuests.Name = "listViewGuests";
            this.listViewGuests.Size = new System.Drawing.Size(287, 295);
            this.listViewGuests.TabIndex = 18;
            this.listViewGuests.UseCompatibleStateImageBehavior = false;
            // 
            // groupBoxGuests
            // 
            this.groupBoxGuests.BackColor = System.Drawing.Color.BurlyWood;
            this.groupBoxGuests.Controls.Add(this.listViewGuests);
            this.groupBoxGuests.Font = new System.Drawing.Font("Segoe Script", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxGuests.Location = new System.Drawing.Point(1692, 628);
            this.groupBoxGuests.Name = "groupBoxGuests";
            this.groupBoxGuests.Size = new System.Drawing.Size(293, 316);
            this.groupBoxGuests.TabIndex = 19;
            this.groupBoxGuests.TabStop = false;
            this.groupBoxGuests.Text = "Lista gości:";
            // 
            // labelDay
            // 
            this.labelDay.AutoSize = true;
            this.labelDay.BackColor = System.Drawing.Color.Transparent;
            this.labelDay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelDay.Font = new System.Drawing.Font("Segoe Script", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDay.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelDay.Location = new System.Drawing.Point(19, 39);
            this.labelDay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDay.Name = "labelDay";
            this.labelDay.Size = new System.Drawing.Size(177, 52);
            this.labelDay.TabIndex = 20;
            this.labelDay.Text = "Dzień: 0";
            // 
            // progressBarDay
            // 
            this.progressBarDay.Location = new System.Drawing.Point(33, 82);
            this.progressBarDay.Name = "progressBarDay";
            this.progressBarDay.Size = new System.Drawing.Size(100, 23);
            this.progressBarDay.TabIndex = 21;
            // 
            // buttonPause
            // 
            this.buttonPause.AutoSize = true;
            this.buttonPause.BackColor = System.Drawing.Color.DarkRed;
            this.buttonPause.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPause.ForeColor = System.Drawing.Color.White;
            this.buttonPause.Location = new System.Drawing.Point(910, 713);
            this.buttonPause.Name = "buttonPause";
            this.buttonPause.Size = new System.Drawing.Size(274, 54);
            this.buttonPause.TabIndex = 22;
            this.buttonPause.Text = "Odpauzuj!";
            this.buttonPause.UseVisualStyleBackColor = false;
            this.buttonPause.Visible = false;
            this.buttonPause.Click += new System.EventHandler(this.buttonPause_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Greenhorn_Innkeeper_.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(1924, 936);
            this.Controls.Add(this.buttonPause);
            this.Controls.Add(this.progressBarDay);
            this.Controls.Add(this.labelDay);
            this.Controls.Add(this.groupBoxGuests);
            this.Controls.Add(this.buttonResupply);
            this.Controls.Add(this.labelRoom4);
            this.Controls.Add(this.labelRoom3);
            this.Controls.Add(this.labelRoom2);
            this.Controls.Add(this.labelRoom1);
            this.Controls.Add(this.buttonPoker);
            this.Controls.Add(this.labelPoker);
            this.Controls.Add(this.buttonDrinkingGame);
            this.Controls.Add(this.labelDrinkingGame);
            this.Controls.Add(this.pictureBoxGold);
            this.Controls.Add(this.pictureBoxBeer);
            this.Controls.Add(this.pictureBoxFood);
            this.Controls.Add(this.labelGoldNumber);
            this.Controls.Add(this.labelFoodNumber);
            this.Controls.Add(this.labelBeerNumber);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.Text = "Greenhorn Innkeeper!";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBeer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGold)).EndInit();
            this.groupBoxGuests.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelBeerNumber;
        private System.Windows.Forms.Label labelFoodNumber;
        private System.Windows.Forms.Timer timerTime;
        private System.Windows.Forms.Label labelGoldNumber;
        private System.Windows.Forms.PictureBox pictureBoxFood;
        private System.Windows.Forms.PictureBox pictureBoxBeer;
        private System.Windows.Forms.PictureBox pictureBoxGold;
        private System.Windows.Forms.Label labelDrinkingGame;
        private System.Windows.Forms.Button buttonDrinkingGame;
        private System.Windows.Forms.Label labelPoker;
        private System.Windows.Forms.Button buttonPoker;
        private System.Windows.Forms.Label labelRoom1;
        private System.Windows.Forms.Label labelRoom2;
        private System.Windows.Forms.Label labelRoom3;
        private System.Windows.Forms.Label labelRoom4;
        private System.Windows.Forms.Button buttonResupply;
        private System.Windows.Forms.ListView listViewGuests;
        private System.Windows.Forms.GroupBox groupBoxGuests;
        private System.Windows.Forms.Label labelDay;
        private System.Windows.Forms.ProgressBar progressBarDay;
        private System.Windows.Forms.Button buttonPause;
    }
}

