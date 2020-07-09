namespace NervousBreakdown
{
    partial class FormResult
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
            this.ResultTextlabel = new System.Windows.Forms.Label();
            this.TurnResultLabel = new System.Windows.Forms.Label();
            this.WinResultLabel = new System.Windows.Forms.Label();
            this.ExitResultLabel = new System.Windows.Forms.Label();
            this.LoseResultLabel = new System.Windows.Forms.Label();
            this.ScoreResultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ResultTextlabel
            // 
            this.ResultTextlabel.AutoSize = true;
            this.ResultTextlabel.Font = new System.Drawing.Font("MS UI Gothic", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ResultTextlabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ResultTextlabel.Location = new System.Drawing.Point(464, 273);
            this.ResultTextlabel.Name = "ResultTextlabel";
            this.ResultTextlabel.Size = new System.Drawing.Size(190, 34);
            this.ResultTextlabel.TabIndex = 2;
            this.ResultTextlabel.Text = "ターンでクリア";
            this.ResultTextlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TurnResultLabel
            // 
            this.TurnResultLabel.AutoSize = true;
            this.TurnResultLabel.Font = new System.Drawing.Font("MS UI Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TurnResultLabel.Location = new System.Drawing.Point(406, 267);
            this.TurnResultLabel.Name = "TurnResultLabel";
            this.TurnResultLabel.Size = new System.Drawing.Size(37, 40);
            this.TurnResultLabel.TabIndex = 3;
            this.TurnResultLabel.Text = "0";
            // 
            // WinResultLabel
            // 
            this.WinResultLabel.AutoSize = true;
            this.WinResultLabel.Font = new System.Drawing.Font("HGS創英角ﾎﾟｯﾌﾟ体", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.WinResultLabel.Location = new System.Drawing.Point(276, 106);
            this.WinResultLabel.Name = "WinResultLabel";
            this.WinResultLabel.Size = new System.Drawing.Size(540, 67);
            this.WinResultLabel.TabIndex = 4;
            this.WinResultLabel.Text = "congratulation!!";
            // 
            // ExitResultLabel
            // 
            this.ExitResultLabel.AutoSize = true;
            this.ExitResultLabel.Location = new System.Drawing.Point(917, 515);
            this.ExitResultLabel.Name = "ExitResultLabel";
            this.ExitResultLabel.Size = new System.Drawing.Size(102, 12);
            this.ExitResultLabel.TabIndex = 5;
            this.ExitResultLabel.Text = "画面をクリックで終了";
            // 
            // LoseResultLabel
            // 
            this.LoseResultLabel.AutoSize = true;
            this.LoseResultLabel.Location = new System.Drawing.Point(190, 216);
            this.LoseResultLabel.Name = "LoseResultLabel";
            this.LoseResultLabel.Size = new System.Drawing.Size(101, 12);
            this.LoseResultLabel.TabIndex = 6;
            this.LoseResultLabel.Text = "(NPC、負けた時用）";
            this.LoseResultLabel.Visible = false;
            // 
            // ScoreResultLabel
            // 
            this.ScoreResultLabel.AutoSize = true;
            this.ScoreResultLabel.Location = new System.Drawing.Point(192, 243);
            this.ScoreResultLabel.Name = "ScoreResultLabel";
            this.ScoreResultLabel.Size = new System.Drawing.Size(166, 12);
            this.ScoreResultLabel.TabIndex = 7;
            this.ScoreResultLabel.Text = "(NPC、何枚獲得できたか表示用)";
            this.ScoreResultLabel.Visible = false;
            // 
            // FormResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 536);
            this.Controls.Add(this.ScoreResultLabel);
            this.Controls.Add(this.LoseResultLabel);
            this.Controls.Add(this.ExitResultLabel);
            this.Controls.Add(this.WinResultLabel);
            this.Controls.Add(this.TurnResultLabel);
            this.Controls.Add(this.ResultTextlabel);
            this.Name = "FormResult";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormResult_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FormResult_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label ResultTextlabel;
        private System.Windows.Forms.Label TurnResultLabel;
        private System.Windows.Forms.Label WinResultLabel;
        private System.Windows.Forms.Label ExitResultLabel;
        private System.Windows.Forms.Label LoseResultLabel;
        private System.Windows.Forms.Label ScoreResultLabel;
    }
}