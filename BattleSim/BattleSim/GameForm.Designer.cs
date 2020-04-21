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
            this.btnAttack = new System.Windows.Forms.Button();
            this.lbxAttacksLog = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.flpPlayer1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flpPlayer2 = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // btnAttack
            // 
            this.btnAttack.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttack.Location = new System.Drawing.Point(352, 421);
            this.btnAttack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(207, 46);
            this.btnAttack.TabIndex = 0;
            this.btnAttack.Text = "Attack";
            this.btnAttack.UseVisualStyleBackColor = true;
            this.btnAttack.Click += new System.EventHandler(this.btnAttack_Click);
            // 
            // lbxAttacksLog
            // 
            this.lbxAttacksLog.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxAttacksLog.FormattingEnabled = true;
            this.lbxAttacksLog.ItemHeight = 20;
            this.lbxAttacksLog.Location = new System.Drawing.Point(240, 95);
            this.lbxAttacksLog.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbxAttacksLog.Name = "lbxAttacksLog";
            this.lbxAttacksLog.Size = new System.Drawing.Size(423, 244);
            this.lbxAttacksLog.TabIndex = 5;
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
            this.flpPlayer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flpPlayer1.Name = "flpPlayer1";
            this.flpPlayer1.Size = new System.Drawing.Size(221, 506);
            this.flpPlayer1.TabIndex = 18;
            // 
            // flpPlayer2
            // 
            this.flpPlayer2.Location = new System.Drawing.Point(668, 27);
            this.flpPlayer2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flpPlayer2.Name = "flpPlayer2";
            this.flpPlayer2.Size = new System.Drawing.Size(221, 506);
            this.flpPlayer2.TabIndex = 19;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 545);
            this.Controls.Add(this.flpPlayer2);
            this.Controls.Add(this.flpPlayer1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbxAttacksLog);
            this.Controls.Add(this.btnAttack);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "GameForm";
            this.Text = "GameForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAttack;
        private System.Windows.Forms.ListBox lbxAttacksLog;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.FlowLayoutPanel flpPlayer1;
        private System.Windows.Forms.FlowLayoutPanel flpPlayer2;
    }
}