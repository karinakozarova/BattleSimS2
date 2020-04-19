namespace BattleSim
{
    partial class CreateWeaponsAndSpells
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
            this.label4 = new System.Windows.Forms.Label();
            this.tbWeaponSpellName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rbSpell = new System.Windows.Forms.RadioButton();
            this.rbWeapon = new System.Windows.Forms.RadioButton();
            this.btnCreate = new System.Windows.Forms.Button();
            this.manaLbl = new System.Windows.Forms.Label();
            this.tbWeaponSpellDamage = new System.Windows.Forms.NumericUpDown();
            this.tbManaCost = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.tbWeaponSpellDamage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbManaCost)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(62, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(270, 33);
            this.label4.TabIndex = 11;
            this.label4.Text = "Create Weapon/Spell";
            // 
            // tbWeaponSpellName
            // 
            this.tbWeaponSpellName.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbWeaponSpellName.Location = new System.Drawing.Point(66, 239);
            this.tbWeaponSpellName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbWeaponSpellName.Multiline = true;
            this.tbWeaponSpellName.Name = "tbWeaponSpellName";
            this.tbWeaponSpellName.Size = new System.Drawing.Size(222, 33);
            this.tbWeaponSpellName.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(145, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 29);
            this.label1.TabIndex = 14;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(134, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 29);
            this.label2.TabIndex = 16;
            this.label2.Text = "Damage";
            // 
            // rbSpell
            // 
            this.rbSpell.AutoSize = true;
            this.rbSpell.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSpell.Location = new System.Drawing.Point(206, 121);
            this.rbSpell.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbSpell.Name = "rbSpell";
            this.rbSpell.Size = new System.Drawing.Size(90, 33);
            this.rbSpell.TabIndex = 18;
            this.rbSpell.TabStop = true;
            this.rbSpell.Text = "Spell";
            this.rbSpell.UseVisualStyleBackColor = true;
            this.rbSpell.CheckedChanged += new System.EventHandler(this.rbSpell_CheckedChanged);
            // 
            // rbWeapon
            // 
            this.rbWeapon.AutoSize = true;
            this.rbWeapon.Checked = true;
            this.rbWeapon.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbWeapon.Location = new System.Drawing.Point(81, 121);
            this.rbWeapon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbWeapon.Name = "rbWeapon";
            this.rbWeapon.Size = new System.Drawing.Size(126, 33);
            this.rbWeapon.TabIndex = 17;
            this.rbWeapon.TabStop = true;
            this.rbWeapon.Text = "Weapon";
            this.rbWeapon.UseVisualStyleBackColor = true;
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(128, 522);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(120, 40);
            this.btnCreate.TabIndex = 19;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // manaLbl
            // 
            this.manaLbl.AutoSize = true;
            this.manaLbl.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manaLbl.Location = new System.Drawing.Point(134, 422);
            this.manaLbl.Name = "manaLbl";
            this.manaLbl.Size = new System.Drawing.Size(124, 29);
            this.manaLbl.TabIndex = 21;
            this.manaLbl.Text = "Mana Cost";
            // 
            // tbWeaponSpellDamage
            // 
            this.tbWeaponSpellDamage.Location = new System.Drawing.Point(66, 365);
            this.tbWeaponSpellDamage.Name = "tbWeaponSpellDamage";
            this.tbWeaponSpellDamage.Size = new System.Drawing.Size(230, 26);
            this.tbWeaponSpellDamage.TabIndex = 22;
            // 
            // tbManaCost
            // 
            this.tbManaCost.Location = new System.Drawing.Point(58, 454);
            this.tbManaCost.Name = "tbManaCost";
            this.tbManaCost.Size = new System.Drawing.Size(230, 26);
            this.tbManaCost.TabIndex = 23;
            // 
            // CreateWeaponsAndSpells
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 592);
            this.Controls.Add(this.tbManaCost);
            this.Controls.Add(this.tbWeaponSpellDamage);
            this.Controls.Add(this.manaLbl);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.rbSpell);
            this.Controls.Add(this.rbWeapon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbWeaponSpellName);
            this.Controls.Add(this.label4);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CreateWeaponsAndSpells";
            this.Text = "CreateWeaponsAndSpells";
            this.Load += new System.EventHandler(this.CreateWeaponsAndSpells_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbWeaponSpellDamage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbManaCost)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbWeaponSpellName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbSpell;
        private System.Windows.Forms.RadioButton rbWeapon;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label manaLbl;
        private System.Windows.Forms.NumericUpDown tbWeaponSpellDamage;
        private System.Windows.Forms.NumericUpDown tbManaCost;
    }
}