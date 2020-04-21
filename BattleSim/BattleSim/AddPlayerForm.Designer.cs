namespace BattleSim
{
    partial class AddPlayerForm
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
            this.tbPlayerName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbKnight = new System.Windows.Forms.RadioButton();
            this.rbWizard = new System.Windows.Forms.RadioButton();
            this.cbChooseWeapon = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblChooseSpell = new System.Windows.Forms.Label();
            this.cbChooseSpell = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddPlayer = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tbCharacterName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbPlayerName
            // 
            this.tbPlayerName.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPlayerName.Location = new System.Drawing.Point(109, 65);
            this.tbPlayerName.Margin = new System.Windows.Forms.Padding(2);
            this.tbPlayerName.Multiline = true;
            this.tbPlayerName.Name = "tbPlayerName";
            this.tbPlayerName.Size = new System.Drawing.Size(137, 23);
            this.tbPlayerName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(127, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Player Name";
            // 
            // rbKnight
            // 
            this.rbKnight.AutoSize = true;
            this.rbKnight.Checked = true;
            this.rbKnight.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbKnight.Location = new System.Drawing.Point(93, 223);
            this.rbKnight.Margin = new System.Windows.Forms.Padding(2);
            this.rbKnight.Name = "rbKnight";
            this.rbKnight.Size = new System.Drawing.Size(73, 22);
            this.rbKnight.TabIndex = 2;
            this.rbKnight.TabStop = true;
            this.rbKnight.Text = "Knight";
            this.rbKnight.UseVisualStyleBackColor = true;
            this.rbKnight.CheckedChanged += new System.EventHandler(this.rbKnight_CheckedChanged);
            // 
            // rbWizard
            // 
            this.rbWizard.AutoSize = true;
            this.rbWizard.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbWizard.Location = new System.Drawing.Point(185, 223);
            this.rbWizard.Margin = new System.Windows.Forms.Padding(2);
            this.rbWizard.Name = "rbWizard";
            this.rbWizard.Size = new System.Drawing.Size(76, 22);
            this.rbWizard.TabIndex = 4;
            this.rbWizard.TabStop = true;
            this.rbWizard.Text = "Wizard";
            this.rbWizard.UseVisualStyleBackColor = true;
            this.rbWizard.CheckedChanged += new System.EventHandler(this.rbWizard_CheckedChanged);
            // 
            // cbChooseWeapon
            // 
            this.cbChooseWeapon.FormattingEnabled = true;
            this.cbChooseWeapon.Location = new System.Drawing.Point(154, 260);
            this.cbChooseWeapon.Margin = new System.Windows.Forms.Padding(2);
            this.cbChooseWeapon.Name = "cbChooseWeapon";
            this.cbChooseWeapon.Size = new System.Drawing.Size(194, 21);
            this.cbChooseWeapon.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 260);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Choose Weapon";
            // 
            // lblChooseSpell
            // 
            this.lblChooseSpell.AutoSize = true;
            this.lblChooseSpell.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChooseSpell.Location = new System.Drawing.Point(26, 294);
            this.lblChooseSpell.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblChooseSpell.Name = "lblChooseSpell";
            this.lblChooseSpell.Size = new System.Drawing.Size(100, 18);
            this.lblChooseSpell.TabIndex = 7;
            this.lblChooseSpell.Text = "Choose Spell";
            // 
            // cbChooseSpell
            // 
            this.cbChooseSpell.FormattingEnabled = true;
            this.cbChooseSpell.Location = new System.Drawing.Point(154, 291);
            this.cbChooseSpell.Margin = new System.Windows.Forms.Padding(2);
            this.cbChooseSpell.Name = "cbChooseSpell";
            this.cbChooseSpell.Size = new System.Drawing.Size(194, 21);
            this.cbChooseSpell.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(98, 187);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Choose your character";
            // 
            // btnAddPlayer
            // 
            this.btnAddPlayer.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPlayer.Location = new System.Drawing.Point(109, 340);
            this.btnAddPlayer.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddPlayer.Name = "btnAddPlayer";
            this.btnAddPlayer.Size = new System.Drawing.Size(144, 30);
            this.btnAddPlayer.TabIndex = 10;
            this.btnAddPlayer.Text = "Add Player";
            this.btnAddPlayer.UseVisualStyleBackColor = true;
            this.btnAddPlayer.Click += new System.EventHandler(this.btnAddPlayer_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(119, 106);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "Character Name";
            // 
            // tbCharacterName
            // 
            this.tbCharacterName.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCharacterName.Location = new System.Drawing.Point(109, 141);
            this.tbCharacterName.Margin = new System.Windows.Forms.Padding(2);
            this.tbCharacterName.Multiline = true;
            this.tbCharacterName.Name = "tbCharacterName";
            this.tbCharacterName.Size = new System.Drawing.Size(137, 23);
            this.tbCharacterName.TabIndex = 11;
            // 
            // AddPlayerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 394);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbCharacterName);
            this.Controls.Add(this.btnAddPlayer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbChooseSpell);
            this.Controls.Add(this.lblChooseSpell);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbChooseWeapon);
            this.Controls.Add(this.rbWizard);
            this.Controls.Add(this.rbKnight);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPlayerName);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddPlayerForm";
            this.Text = "AddPlayerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPlayerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbKnight;
        private System.Windows.Forms.RadioButton rbWizard;
        private System.Windows.Forms.ComboBox cbChooseWeapon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblChooseSpell;
        private System.Windows.Forms.ComboBox cbChooseSpell;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddPlayer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbCharacterName;
    }
}