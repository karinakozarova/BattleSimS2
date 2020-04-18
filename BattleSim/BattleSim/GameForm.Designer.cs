namespace BattleSim
{
    partial class GameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.btnWeaponAttack = new System.Windows.Forms.Button();
            this.pbPlayer = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.pbrPlayerHealth = new System.Windows.Forms.ProgressBar();
            this.btnSpellAttack = new System.Windows.Forms.Button();
            this.pbrPlayerAbility = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pbrEnemyHealth = new System.Windows.Forms.ProgressBar();
            this.pbEnemy = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pbrEnemyAbility = new System.Windows.Forms.ProgressBar();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnemy)).BeginInit();
            this.SuspendLayout();
            // 
            // btnWeaponAttack
            // 
            this.btnWeaponAttack.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWeaponAttack.Location = new System.Drawing.Point(353, 405);
            this.btnWeaponAttack.Name = "btnWeaponAttack";
            this.btnWeaponAttack.Size = new System.Drawing.Size(207, 46);
            this.btnWeaponAttack.TabIndex = 0;
            this.btnWeaponAttack.Text = "Weapon Attack";
            this.btnWeaponAttack.UseVisualStyleBackColor = true;
            // 
            // pbPlayer
            // 
            this.pbPlayer.Image = ((System.Drawing.Image)(resources.GetObject("pbPlayer.Image")));
            this.pbPlayer.Location = new System.Drawing.Point(25, 95);
            this.pbPlayer.Name = "pbPlayer";
            this.pbPlayer.Size = new System.Drawing.Size(169, 264);
            this.pbPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPlayer.TabIndex = 1;
            this.pbPlayer.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Player 1 - Wizard";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(704, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Player 2 - Knight";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(240, 95);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(422, 264);
            this.listBox1.TabIndex = 5;
            // 
            // pbrPlayerHealth
            // 
            this.pbrPlayerHealth.Location = new System.Drawing.Point(25, 418);
            this.pbrPlayerHealth.Name = "pbrPlayerHealth";
            this.pbrPlayerHealth.Size = new System.Drawing.Size(197, 33);
            this.pbrPlayerHealth.TabIndex = 6;
            // 
            // btnSpellAttack
            // 
            this.btnSpellAttack.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpellAttack.Location = new System.Drawing.Point(353, 468);
            this.btnSpellAttack.Name = "btnSpellAttack";
            this.btnSpellAttack.Size = new System.Drawing.Size(207, 46);
            this.btnSpellAttack.TabIndex = 8;
            this.btnSpellAttack.Text = "Spell Attack";
            this.btnSpellAttack.UseVisualStyleBackColor = true;
            // 
            // pbrPlayerAbility
            // 
            this.pbrPlayerAbility.Location = new System.Drawing.Point(25, 489);
            this.pbrPlayerAbility.Name = "pbrPlayerAbility";
            this.pbrPlayerAbility.Size = new System.Drawing.Size(197, 25);
            this.pbrPlayerAbility.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 466);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Mana";
            // 
            // label4
            // 
            this.label4.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 395);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Health";
            // 
            // label5
            // 
            this.label5.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(676, 395);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Enemy Health";
            // 
            // pbrEnemyHealth
            // 
            this.pbrEnemyHealth.Location = new System.Drawing.Point(680, 418);
            this.pbrEnemyHealth.Name = "pbrEnemyHealth";
            this.pbrEnemyHealth.Size = new System.Drawing.Size(197, 33);
            this.pbrEnemyHealth.TabIndex = 12;
            // 
            // pbEnemy
            // 
            this.pbEnemy.Image = ((System.Drawing.Image)(resources.GetObject("pbEnemy.Image")));
            this.pbEnemy.Location = new System.Drawing.Point(708, 95);
            this.pbEnemy.Name = "pbEnemy";
            this.pbEnemy.Size = new System.Drawing.Size(169, 264);
            this.pbEnemy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEnemy.TabIndex = 14;
            this.pbEnemy.TabStop = false;
            // 
            // label6
            // 
            this.label6.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(676, 466);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Shield Power";
            // 
            // pbrEnemyAbility
            // 
            this.pbrEnemyAbility.Location = new System.Drawing.Point(680, 489);
            this.pbrEnemyAbility.Name = "pbrEnemyAbility";
            this.pbrEnemyAbility.Size = new System.Drawing.Size(197, 25);
            this.pbrEnemyAbility.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(373, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 24);
            this.label7.TabIndex = 17;
            this.label7.Text = "Battle Ground";
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 545);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pbrEnemyAbility);
            this.Controls.Add(this.pbEnemy);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pbrEnemyHealth);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pbrPlayerAbility);
            this.Controls.Add(this.btnSpellAttack);
            this.Controls.Add(this.pbrPlayerHealth);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbPlayer);
            this.Controls.Add(this.btnWeaponAttack);
            this.Name = "GameForm";
            this.Text = "GameForm";
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnemy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWeaponAttack;
        private System.Windows.Forms.PictureBox pbPlayer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ProgressBar pbrPlayerHealth;
        private System.Windows.Forms.Button btnSpellAttack;
        private System.Windows.Forms.ProgressBar pbrPlayerAbility;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar pbrEnemyHealth;
        private System.Windows.Forms.PictureBox pbEnemy;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ProgressBar pbrEnemyAbility;
        private System.Windows.Forms.Label label7;
    }
}