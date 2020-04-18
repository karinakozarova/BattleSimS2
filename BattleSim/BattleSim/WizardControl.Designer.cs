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
            this.pbrPlayerAbility = new System.Windows.Forms.ProgressBar();
            this.pbrPlayerHealth = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.pbPlayer = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 358);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Health";
            // 
            // label3
            // 
            this.label3.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 429);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Mana";
            // 
            // pbrPlayerAbility
            // 
            this.pbrPlayerAbility.Location = new System.Drawing.Point(13, 452);
            this.pbrPlayerAbility.Name = "pbrPlayerAbility";
            this.pbrPlayerAbility.Size = new System.Drawing.Size(197, 25);
            this.pbrPlayerAbility.TabIndex = 15;
            // 
            // pbrPlayerHealth
            // 
            this.pbrPlayerHealth.Location = new System.Drawing.Point(13, 381);
            this.pbrPlayerHealth.Name = "pbrPlayerHealth";
            this.pbrPlayerHealth.Size = new System.Drawing.Size(197, 33);
            this.pbrPlayerHealth.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Player 1 - Wizard";
            // 
            // pbPlayer
            // 
            this.pbPlayer.Image = ((System.Drawing.Image)(resources.GetObject("pbPlayer.Image")));
            this.pbPlayer.Location = new System.Drawing.Point(13, 58);
            this.pbPlayer.Name = "pbPlayer";
            this.pbPlayer.Size = new System.Drawing.Size(169, 264);
            this.pbPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPlayer.TabIndex = 12;
            this.pbPlayer.TabStop = false;
            // 
            // WizardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pbrPlayerAbility);
            this.Controls.Add(this.pbrPlayerHealth);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbPlayer);
            this.Name = "WizardControl";
            this.Size = new System.Drawing.Size(219, 484);
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar pbrPlayerAbility;
        private System.Windows.Forms.ProgressBar pbrPlayerHealth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbPlayer;
    }
}
