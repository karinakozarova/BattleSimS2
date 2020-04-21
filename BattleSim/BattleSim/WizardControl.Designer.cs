namespace BattleSim
{
    partial class WizardControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WizardControl));
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pbrPlayerMana = new System.Windows.Forms.ProgressBar();
            this.pbrPlayerHealth = new System.Windows.Forms.ProgressBar();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.pbPlayer = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 291);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 18);
            this.label4.TabIndex = 17;
            this.label4.Text = "Health";
            // 
            // label3
            // 
            this.label3.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 349);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 18);
            this.label3.TabIndex = 16;
            this.label3.Text = "Mana";
            // 
            // pbrPlayerMana
            // 
            this.pbrPlayerMana.BackColor = System.Drawing.Color.Blue;
            this.pbrPlayerMana.Location = new System.Drawing.Point(10, 367);
            this.pbrPlayerMana.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbrPlayerMana.Name = "pbrPlayerMana";
            this.pbrPlayerMana.Size = new System.Drawing.Size(148, 20);
            this.pbrPlayerMana.TabIndex = 15;
            // 
            // pbrPlayerHealth
            // 
            this.pbrPlayerHealth.Location = new System.Drawing.Point(10, 310);
            this.pbrPlayerHealth.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbrPlayerHealth.Name = "pbrPlayerHealth";
            this.pbrPlayerHealth.Size = new System.Drawing.Size(148, 27);
            this.pbrPlayerHealth.TabIndex = 14;
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerName.Location = new System.Drawing.Point(7, 12);
            this.lblPlayerName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(127, 18);
            this.lblPlayerName.TabIndex = 13;
            this.lblPlayerName.Text = "Player 1 - Wizard";
            // 
            // pbPlayer
            // 
            this.pbPlayer.Image = ((System.Drawing.Image)(resources.GetObject("pbPlayer.Image")));
            this.pbPlayer.Location = new System.Drawing.Point(10, 47);
            this.pbPlayer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbPlayer.Name = "pbPlayer";
            this.pbPlayer.Size = new System.Drawing.Size(127, 214);
            this.pbPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPlayer.TabIndex = 12;
            this.pbPlayer.TabStop = false;
            // 
            // WizardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pbrPlayerMana);
            this.Controls.Add(this.pbrPlayerHealth);
            this.Controls.Add(this.lblPlayerName);
            this.Controls.Add(this.pbPlayer);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "WizardControl";
            this.Size = new System.Drawing.Size(164, 393);
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar pbrPlayerMana;
        private System.Windows.Forms.ProgressBar pbrPlayerHealth;
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.PictureBox pbPlayer;
    }
}
