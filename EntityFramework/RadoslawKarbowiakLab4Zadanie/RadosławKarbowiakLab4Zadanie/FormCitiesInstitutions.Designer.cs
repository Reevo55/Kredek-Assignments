namespace RadosławKarbowiakLab4Zadanie
{
    partial class FormCitiesInstitutions
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
            this.dataGridViewInstitutions = new System.Windows.Forms.DataGridView();
            this.dataGridViewCities = new System.Windows.Forms.DataGridView();
            this.labelInstitutions = new System.Windows.Forms.Label();
            this.labelCities = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInstitutions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCities)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewInstitutions
            // 
            this.dataGridViewInstitutions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInstitutions.Location = new System.Drawing.Point(0, 44);
            this.dataGridViewInstitutions.Name = "dataGridViewInstitutions";
            this.dataGridViewInstitutions.RowTemplate.Height = 24;
            this.dataGridViewInstitutions.Size = new System.Drawing.Size(797, 232);
            this.dataGridViewInstitutions.TabIndex = 0;
            // 
            // dataGridViewCities
            // 
            this.dataGridViewCities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCities.Location = new System.Drawing.Point(0, 326);
            this.dataGridViewCities.Name = "dataGridViewCities";
            this.dataGridViewCities.RowTemplate.Height = 24;
            this.dataGridViewCities.Size = new System.Drawing.Size(797, 232);
            this.dataGridViewCities.TabIndex = 1;
            // 
            // labelInstitutions
            // 
            this.labelInstitutions.AutoSize = true;
            this.labelInstitutions.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelInstitutions.Location = new System.Drawing.Point(337, 9);
            this.labelInstitutions.Name = "labelInstitutions";
            this.labelInstitutions.Size = new System.Drawing.Size(128, 32);
            this.labelInstitutions.TabIndex = 2;
            this.labelInstitutions.Text = "Placówki";
            // 
            // labelCities
            // 
            this.labelCities.AutoSize = true;
            this.labelCities.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCities.Location = new System.Drawing.Point(337, 291);
            this.labelCities.Name = "labelCities";
            this.labelCities.Size = new System.Drawing.Size(99, 32);
            this.labelCities.TabIndex = 3;
            this.labelCities.Text = "Miasta";
            // 
            // FormCitiesInstitutions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 557);
            this.Controls.Add(this.labelCities);
            this.Controls.Add(this.labelInstitutions);
            this.Controls.Add(this.dataGridViewCities);
            this.Controls.Add(this.dataGridViewInstitutions);
            this.Name = "FormCitiesInstitutions";
            this.Text = "FormCitiesInstitutions";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInstitutions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCities)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewInstitutions;
        private System.Windows.Forms.DataGridView dataGridViewCities;
        private System.Windows.Forms.Label labelInstitutions;
        private System.Windows.Forms.Label labelCities;
    }
}