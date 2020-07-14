namespace NervousBreakdown
{
    partial class FormResultNPC
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
            this.shohai = new System.Windows.Forms.Label();
            this.player = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.maisu1 = new System.Windows.Forms.Label();
            this.maisu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // shohai
            // 
            this.shohai.AutoSize = true;
            this.shohai.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.shohai.ForeColor = System.Drawing.Color.White;
            this.shohai.Location = new System.Drawing.Point(336, 164);
            this.shohai.Name = "shohai";
            this.shohai.Size = new System.Drawing.Size(51, 20);
            this.shohai.TabIndex = 0;
            this.shohai.Text = "勝敗";
            // 
            // player
            // 
            this.player.AutoSize = true;
            this.player.ForeColor = System.Drawing.Color.White;
            this.player.Location = new System.Drawing.Point(190, 214);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(36, 12);
            this.player.TabIndex = 1;
            this.player.Text = "player";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(520, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "NPC";
            // 
            // maisu1
            // 
            this.maisu1.AutoSize = true;
            this.maisu1.ForeColor = System.Drawing.Color.White;
            this.maisu1.Location = new System.Drawing.Point(191, 269);
            this.maisu1.Name = "maisu1";
            this.maisu1.Size = new System.Drawing.Size(29, 12);
            this.maisu1.TabIndex = 3;
            this.maisu1.Text = "枚数";
            // 
            // maisu
            // 
            this.maisu.AutoSize = true;
            this.maisu.ForeColor = System.Drawing.Color.White;
            this.maisu.Location = new System.Drawing.Point(519, 269);
            this.maisu.Name = "maisu";
            this.maisu.Size = new System.Drawing.Size(29, 12);
            this.maisu.TabIndex = 4;
            this.maisu.Text = "枚数";
            // 
            // FormResultNPC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.maisu);
            this.Controls.Add(this.maisu1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.player);
            this.Controls.Add(this.shohai);
            this.Name = "FormResultNPC";
            this.Text = "FormResultNPC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label shohai;
        private System.Windows.Forms.Label player;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label maisu1;
        private System.Windows.Forms.Label maisu;
    }
}