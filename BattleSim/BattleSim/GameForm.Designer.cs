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
            this.btnWeaponAttack = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnSpellAttack = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.flpPlayer1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flpPlayer2 = new System.Windows.Forms.FlowLayoutPanel();
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
            // flpPlayer1
            // 
            this.flpPlayer1.Location = new System.Drawing.Point(12, 27);
            this.flpPlayer1.Name = "flpPlayer1";
            this.flpPlayer1.Size = new System.Drawing.Size(222, 506);
            this.flpPlayer1.TabIndex = 18;
            // 
            // flpPlayer2
            // 
            this.flpPlayer2.Location = new System.Drawing.Point(668, 27);
            this.flpPlayer2.Name = "flpPlayer2";
            this.flpPlayer2.Size = new System.Drawing.Size(222, 506);
            this.flpPlayer2.TabIndex = 19;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 545);
            this.Controls.Add(this.flpPlayer2);
            this.Controls.Add(this.flpPlayer1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnSpellAttack);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnWeaponAttack);
            this.Name = "GameForm";
            this.Text = "GameForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWeaponAttack;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnSpellAttack;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.FlowLayoutPanel flpPlayer1;
        private System.Windows.Forms.FlowLayoutPanel flpPlayer2;
    }
}