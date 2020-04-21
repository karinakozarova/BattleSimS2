namespace BattleSim
{
    partial class KnightControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KnightControl));
            this.label6 = new System.Windows.Forms.Label();
            this.pbrShieldPower = new System.Windows.Forms.ProgressBar();
            this.pbEnemy = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pbrPlayerHealth = new System.Windows.Forms.ProgressBar();
            this.lblPlayerName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnemy)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 348);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 18);
            this.label6.TabIndex = 22;
            this.label6.Text = "Shield Power";
            // 
            // pbrShieldPower
            // 
            this.pbrShieldPower.Location = new System.Drawing.Point(9, 366);
            this.pbrShieldPower.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbrShieldPower.Name = "pbrShieldPower";
            this.pbrShieldPower.Size = new System.Drawing.Size(148, 20);
            this.pbrShieldPower.TabIndex = 21;
            // 
            // pbEnemy
            // 
            this.pbEnemy.Image = ((System.Drawing.Image)(resources.GetObject("pbEnemy.Image")));
            this.pbEnemy.Location = new System.Drawing.Point(9, 42);
            this.pbEnemy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbEnemy.Name = "pbEnemy";
            this.pbEnemy.Size = new System.Drawing.Size(127, 214);
            this.pbEnemy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEnemy.TabIndex = 20;
            this.pbEnemy.TabStop = false;
            // 
            // label5
            // 
            this.label5.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 290);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 18);
            this.label5.TabIndex = 19;
            this.label5.Text = "Enemy Health";
            // 
            // pbrPlayerHealth
            // 
            this.pbrPlayerHealth.Location = new System.Drawing.Point(9, 309);
            this.pbrPlayerHealth.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbrPlayerHealth.Name = "pbrPlayerHealth";
            this.pbrPlayerHealth.Size = new System.Drawing.Size(148, 27);
            this.pbrPlayerHealth.TabIndex = 18;
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerName.Location = new System.Drawing.Point(6, 11);
            this.lblPlayerName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(127, 18);
            this.lblPlayerName.TabIndex = 17;
            this.lblPlayerName.Text = "Player 2 - Knight";
            // 
            // KnightControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pbrShieldPower);
            this.Controls.Add(this.pbEnemy);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pbrPlayerHealth);
            this.Controls.Add(this.lblPlayerName);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "KnightControl";
            this.Size = new System.Drawing.Size(164, 398);
            ((System.ComponentModel.ISupportInitialize)(this.pbEnemy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ProgressBar pbrShieldPower;
        private System.Windows.Forms.PictureBox pbEnemy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar pbrPlayerHealth;
        private System.Windows.Forms.Label lblPlayerName;
    }
}
