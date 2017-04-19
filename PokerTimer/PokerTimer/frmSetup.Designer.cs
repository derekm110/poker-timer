namespace PokerTimer
{
    partial class frmSetup
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
            this.txtSchedule = new System.Windows.Forms.TextBox();
            this.txtTimePerLevel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblBanerTitle = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSchedule
            // 
            this.txtSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchedule.Location = new System.Drawing.Point(322, 240);
            this.txtSchedule.Multiline = true;
            this.txtSchedule.Name = "txtSchedule";
            this.txtSchedule.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSchedule.Size = new System.Drawing.Size(285, 280);
            this.txtSchedule.TabIndex = 3;
            // 
            // txtTimePerLevel
            // 
            this.txtTimePerLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimePerLevel.Location = new System.Drawing.Point(322, 186);
            this.txtTimePerLevel.Multiline = true;
            this.txtTimePerLevel.Name = "txtTimePerLevel";
            this.txtTimePerLevel.Size = new System.Drawing.Size(285, 30);
            this.txtTimePerLevel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(44, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Time Per Level (minutes)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(44, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tournament Name";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(322, 128);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(285, 30);
            this.txtName.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(44, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 26);
            this.label5.TabIndex = 10;
            this.label5.Text = "Blind Structure";
            // 
            // lblBanerTitle
            // 
            this.lblBanerTitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBanerTitle.ForeColor = System.Drawing.Color.Black;
            this.lblBanerTitle.Location = new System.Drawing.Point(26, 6);
            this.lblBanerTitle.Name = "lblBanerTitle";
            this.lblBanerTitle.Size = new System.Drawing.Size(592, 85);
            this.lblBanerTitle.TabIndex = 11;
            this.lblBanerTitle.Text = "Derek\'s Mediocre Poker Timer";
            this.lblBanerTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(30, 641);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(585, 51);
            this.btnStart.TabIndex = 12;
            this.btnStart.Text = "Next";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(322, 529);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(285, 39);
            this.btnOpenFile.TabIndex = 13;
            this.btnOpenFile.Text = "Import Custom Structure...";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // frmSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(644, 704);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblBanerTitle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTimePerLevel);
            this.Controls.Add(this.txtSchedule);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmSetup";
            this.Text = "Derek\'s Poker Timer - Setup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtSchedule;
        private System.Windows.Forms.TextBox txtTimePerLevel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblBanerTitle;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnOpenFile;
    }
}

