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
            this.pbrEnemyAbility = new System.Windows.Forms.ProgressBar();
            this.pbEnemy = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pbrEnemyHealth = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnemy)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 428);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "Shield Power";
            // 
            // pbrEnemyAbility
            // 
            this.pbrEnemyAbility.Location = new System.Drawing.Point(12, 451);
            this.pbrEnemyAbility.Name = "pbrEnemyAbility";
            this.pbrEnemyAbility.Size = new System.Drawing.Size(197, 25);
            this.pbrEnemyAbility.TabIndex = 21;
            // 
            // pbEnemy
            // 
            this.pbEnemy.Image = ((System.Drawing.Image)(resources.GetObject("pbEnemy.Image")));
            this.pbEnemy.Location = new System.Drawing.Point(12, 52);
            this.pbEnemy.Name = "pbEnemy";
            this.pbEnemy.Size = new System.Drawing.Size(169, 264);
            this.pbEnemy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEnemy.TabIndex = 20;
            this.pbEnemy.TabStop = false;
            // 
            // label5
            // 
            this.label5.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 357);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Enemy Health";
            // 
            // pbrEnemyHealth
            // 
            this.pbrEnemyHealth.Location = new System.Drawing.Point(12, 380);
            this.pbrEnemyHealth.Name = "pbrEnemyHealth";
            this.pbrEnemyHealth.Size = new System.Drawing.Size(197, 33);
            this.pbrEnemyHealth.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Player 2 - Knight";
            // 
            // KnightControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pbrEnemyAbility);
            this.Controls.Add(this.pbEnemy);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pbrEnemyHealth);
            this.Controls.Add(this.label2);
            this.Name = "KnightControl";
            this.Size = new System.Drawing.Size(219, 490);
            ((System.ComponentModel.ISupportInitialize)(this.pbEnemy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ProgressBar pbrEnemyAbility;
        private System.Windows.Forms.PictureBox pbEnemy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar pbrEnemyHealth;
        private System.Windows.Forms.Label label2;
    }
}
