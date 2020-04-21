namespace BattleSim
{
    partial class Form1
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
            this.btnStartGame = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCreateWeaponsAndSpells = new System.Windows.Forms.Button();
            this.btnAddPlayer1 = new System.Windows.Forms.Button();
            this.btnAddPlayer2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStartGame
            // 
            this.btnStartGame.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartGame.Location = new System.Drawing.Point(221, 183);
            this.btnStartGame.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(257, 64);
            this.btnStartGame.TabIndex = 0;
            this.btnStartGame.Text = "Start Game";
            this.btnStartGame.UseVisualStyleBackColor = true;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(221, 352);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(257, 68);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // btnCreateWeaponsAndSpells
            // 
            this.btnCreateWeaponsAndSpells.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateWeaponsAndSpells.Location = new System.Drawing.Point(221, 265);
            this.btnCreateWeaponsAndSpells.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCreateWeaponsAndSpells.Name = "btnCreateWeaponsAndSpells";
            this.btnCreateWeaponsAndSpells.Size = new System.Drawing.Size(257, 69);
            this.btnCreateWeaponsAndSpells.TabIndex = 2;
            this.btnCreateWeaponsAndSpells.Text = "Create Weapons and Spells";
            this.btnCreateWeaponsAndSpells.UseVisualStyleBackColor = true;
            this.btnCreateWeaponsAndSpells.Click += new System.EventHandler(this.btnCreateWeaponsAndSpells_Click);
            // 
            // btnAddPlayer1
            // 
            this.btnAddPlayer1.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPlayer1.Location = new System.Drawing.Point(221, 12);
            this.btnAddPlayer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddPlayer1.Name = "btnAddPlayer1";
            this.btnAddPlayer1.Size = new System.Drawing.Size(257, 64);
            this.btnAddPlayer1.TabIndex = 3;
            this.btnAddPlayer1.Text = "Add Player 1";
            this.btnAddPlayer1.UseVisualStyleBackColor = true;
            this.btnAddPlayer1.Click += new System.EventHandler(this.btnAddPlayer1_Click);
            // 
            // btnAddPlayer2
            // 
            this.btnAddPlayer2.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPlayer2.Location = new System.Drawing.Point(221, 100);
            this.btnAddPlayer2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddPlayer2.Name = "btnAddPlayer2";
            this.btnAddPlayer2.Size = new System.Drawing.Size(257, 64);
            this.btnAddPlayer2.TabIndex = 4;
            this.btnAddPlayer2.Text = "Add Player 2";
            this.btnAddPlayer2.UseVisualStyleBackColor = true;
            this.btnAddPlayer2.Click += new System.EventHandler(this.btnAddPlayer2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 449);
            this.Controls.Add(this.btnAddPlayer2);
            this.Controls.Add(this.btnAddPlayer1);
            this.Controls.Add(this.btnCreateWeaponsAndSpells);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnStartGame);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCreateWeaponsAndSpells;
        private System.Windows.Forms.Button btnAddPlayer1;
        private System.Windows.Forms.Button btnAddPlayer2;
    }
}

