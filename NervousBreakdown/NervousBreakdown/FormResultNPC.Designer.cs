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
            this.ResultLabel = new System.Windows.Forms.Label();
            this.playerLabel = new System.Windows.Forms.Label();
            this.npcLabel = new System.Windows.Forms.Label();
            this.playerPoint = new System.Windows.Forms.Label();
            this.npcPoint = new System.Windows.Forms.Label();
            this.ExitResultLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Font = new System.Drawing.Font("ＭＳ ゴシック", 55.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ResultLabel.ForeColor = System.Drawing.Color.White;
            this.ResultLabel.Location = new System.Drawing.Point(425, 57);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(186, 75);
            this.ResultLabel.TabIndex = 0;
            this.ResultLabel.Text = "勝敗";
            // 
            // playerLabel
            // 
            this.playerLabel.AutoSize = true;
            this.playerLabel.Font = new System.Drawing.Font("ＭＳ ゴシック", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.playerLabel.ForeColor = System.Drawing.Color.White;
            this.playerLabel.Location = new System.Drawing.Point(284, 149);
            this.playerLabel.Name = "playerLabel";
            this.playerLabel.Size = new System.Drawing.Size(117, 33);
            this.playerLabel.TabIndex = 1;
            this.playerLabel.Text = "PLAYER";
            // 
            // npcLabel
            // 
            this.npcLabel.AutoSize = true;
            this.npcLabel.Font = new System.Drawing.Font("ＭＳ ゴシック", 24F, System.Drawing.FontStyle.Bold);
            this.npcLabel.ForeColor = System.Drawing.Color.White;
            this.npcLabel.Location = new System.Drawing.Point(639, 149);
            this.npcLabel.Name = "npcLabel";
            this.npcLabel.Size = new System.Drawing.Size(66, 33);
            this.npcLabel.TabIndex = 2;
            this.npcLabel.Text = "NPC";
            // 
            // playerPoint
            // 
            this.playerPoint.AutoSize = true;
            this.playerPoint.Font = new System.Drawing.Font("ＭＳ ゴシック", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.playerPoint.ForeColor = System.Drawing.Color.White;
            this.playerPoint.Location = new System.Drawing.Point(316, 203);
            this.playerPoint.Name = "playerPoint";
            this.playerPoint.Size = new System.Drawing.Size(49, 33);
            this.playerPoint.TabIndex = 3;
            this.playerPoint.Text = "00";
            // 
            // npcPoint
            // 
            this.npcPoint.AutoSize = true;
            this.npcPoint.Font = new System.Drawing.Font("ＭＳ ゴシック", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.npcPoint.ForeColor = System.Drawing.Color.White;
            this.npcPoint.Location = new System.Drawing.Point(646, 203);
            this.npcPoint.Name = "npcPoint";
            this.npcPoint.Size = new System.Drawing.Size(49, 33);
            this.npcPoint.TabIndex = 4;
            this.npcPoint.Text = "00";
            // 
            // ExitResultLabel
            // 
            this.ExitResultLabel.AutoSize = true;
            this.ExitResultLabel.ForeColor = System.Drawing.Color.White;
            this.ExitResultLabel.Location = new System.Drawing.Point(808, 435);
            this.ExitResultLabel.Name = "ExitResultLabel";
            this.ExitResultLabel.Size = new System.Drawing.Size(102, 12);
            this.ExitResultLabel.TabIndex = 6;
            this.ExitResultLabel.Text = "画面をクリックで終了";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::NervousBreakdown.Properties.Resources.character_boy_normal;
            this.pictureBox1.Location = new System.Drawing.Point(250, 259);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 163);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::NervousBreakdown.Properties.Resources.omocha_robot;
            this.pictureBox2.Location = new System.Drawing.Point(597, 259);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(166, 163);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // FormResultNPC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(1015, 536);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ExitResultLabel);
            this.Controls.Add(this.npcPoint);
            this.Controls.Add(this.playerPoint);
            this.Controls.Add(this.npcLabel);
            this.Controls.Add(this.playerLabel);
            this.Controls.Add(this.ResultLabel);
            this.Name = "FormResultNPC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormResultNPC";
            this.Load += new System.EventHandler(this.FormResultNPC_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FormResultNPC_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.Label playerLabel;
        private System.Windows.Forms.Label npcLabel;
        private System.Windows.Forms.Label playerPoint;
        private System.Windows.Forms.Label npcPoint;
        private System.Windows.Forms.Label ExitResultLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}