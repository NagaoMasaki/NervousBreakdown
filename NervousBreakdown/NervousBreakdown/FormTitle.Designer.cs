namespace NervousBreakdown
{
    partial class FormTitle
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
            this.box = new System.Windows.Forms.PictureBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.OnePlayButton = new System.Windows.Forms.Button();
            this.CPUPlayButton = new System.Windows.Forms.Button();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.box)).BeginInit();
            this.SuspendLayout();
            // 
            // box
            // 
            this.box.BackColor = System.Drawing.Color.DarkGreen;
            this.box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.box.Location = new System.Drawing.Point(0, 0);
            this.box.Name = "box";
            this.box.Size = new System.Drawing.Size(1015, 536);
            this.box.TabIndex = 3;
            this.box.TabStop = false;
            // 
            // TitleLabel
            // 
            this.TitleLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.BackColor = System.Drawing.Color.DarkGreen;
            this.TitleLabel.Font = new System.Drawing.Font("ＭＳ ゴシック", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.Color.White;
            this.TitleLabel.Location = new System.Drawing.Point(282, 73);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(426, 97);
            this.TitleLabel.TabIndex = 4;
            this.TitleLabel.Text = "神経衰弱";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OnePlayButton
            // 
            this.OnePlayButton.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.OnePlayButton.Location = new System.Drawing.Point(214, 356);
            this.OnePlayButton.Name = "OnePlayButton";
            this.OnePlayButton.Size = new System.Drawing.Size(182, 61);
            this.OnePlayButton.TabIndex = 5;
            this.OnePlayButton.Text = "一人で";
            this.OnePlayButton.UseVisualStyleBackColor = true;
            this.OnePlayButton.Click += new System.EventHandler(this.OnePlayButton_Click);
            // 
            // CPUPlayButton
            // 
            this.CPUPlayButton.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.CPUPlayButton.Location = new System.Drawing.Point(594, 356);
            this.CPUPlayButton.Name = "CPUPlayButton";
            this.CPUPlayButton.Size = new System.Drawing.Size(208, 61);
            this.CPUPlayButton.TabIndex = 6;
            this.CPUPlayButton.Text = "CPUと";
            this.CPUPlayButton.UseVisualStyleBackColor = true;
            this.CPUPlayButton.Click += new System.EventHandler(this.CPUPlayButton_Click);
            // 
            // NameBox
            // 
            this.NameBox.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.NameBox.Location = new System.Drawing.Point(495, 267);
            this.NameBox.Multiline = true;
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(144, 33);
            this.NameBox.TabIndex = 7;
            this.NameBox.Text = "テスト01";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkGreen;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(359, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 48);
            this.label2.TabIndex = 8;
            this.label2.Text = "名前を入力\r\nしてください。\r\n";
            // 
            // FormTitle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 536);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.CPUPlayButton);
            this.Controls.Add(this.OnePlayButton);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.box);
            this.Name = "FormTitle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTitle";
            ((System.ComponentModel.ISupportInitialize)(this.box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox box;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Button OnePlayButton;
        private System.Windows.Forms.Button CPUPlayButton;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label label2;
    }
}