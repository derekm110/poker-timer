namespace PokerTimer
{
    partial class frmTimer
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
            this.components = new System.ComponentModel.Container();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTimer = new System.Windows.Forms.Label();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.btnSkip = new System.Windows.Forms.Button();
            this.lblCurrentLevel = new System.Windows.Forms.Label();
            this.btnAction = new System.Windows.Forms.Button();
            this.lblBackground = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblBlinds = new System.Windows.Forms.Label();
            this.lblAnte = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.lblNextAnte = new System.Windows.Forms.Label();
            this.lblNextBlinds = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblNextLevel = new System.Windows.Forms.Label();
            this.lblTimeOfDay = new System.Windows.Forms.Label();
            this.clock = new System.Windows.Forms.Timer(this.components);
            this.pnlHeader.SuspendLayout();
            this.pnlBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(72)))));
            this.pnlHeader.Controls.Add(this.lblLevel);
            this.pnlHeader.Controls.Add(this.label2);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.lblCurrentLevel);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1065, 118);
            this.pnlHeader.TabIndex = 2;
            // 
            // lblTimer
            // 
            this.lblTimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.lblTimer.Font = new System.Drawing.Font("Arial", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(72)))));
            this.lblTimer.Location = new System.Drawing.Point(16, 37);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(472, 109);
            this.lblTimer.TabIndex = 5;
            this.lblTimer.Text = "00:00:00";
            this.lblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlBody
            // 
            this.pnlBody.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(72)))));
            this.pnlBody.Controls.Add(this.lblTimeOfDay);
            this.pnlBody.Controls.Add(this.lblBlinds);
            this.pnlBody.Controls.Add(this.lblNextBlinds);
            this.pnlBody.Controls.Add(this.lblNextLevel);
            this.pnlBody.Controls.Add(this.lblNextAnte);
            this.pnlBody.Controls.Add(this.label10);
            this.pnlBody.Controls.Add(this.label11);
            this.pnlBody.Controls.Add(this.label12);
            this.pnlBody.Controls.Add(this.label13);
            this.pnlBody.Controls.Add(this.label14);
            this.pnlBody.Controls.Add(this.lblAnte);
            this.pnlBody.Controls.Add(this.label5);
            this.pnlBody.Controls.Add(this.label4);
            this.pnlBody.Controls.Add(this.label3);
            this.pnlBody.Controls.Add(this.label1);
            this.pnlBody.Controls.Add(this.lblTimer);
            this.pnlBody.Controls.Add(this.btnSkip);
            this.pnlBody.Controls.Add(this.lblBackground);
            this.pnlBody.Controls.Add(this.btnAction);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 118);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(1065, 473);
            this.pnlBody.TabIndex = 3;
            // 
            // btnSkip
            // 
            this.btnSkip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(29)))), ((int)(((byte)(28)))));
            this.btnSkip.FlatAppearance.BorderSize = 0;
            this.btnSkip.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(14)))), ((int)(((byte)(13)))));
            this.btnSkip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSkip.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSkip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.btnSkip.Location = new System.Drawing.Point(903, 398);
            this.btnSkip.Name = "btnSkip";
            this.btnSkip.Size = new System.Drawing.Size(148, 55);
            this.btnSkip.TabIndex = 14;
            this.btnSkip.Text = "Skip Level";
            this.btnSkip.UseVisualStyleBackColor = false;
            this.btnSkip.Click += new System.EventHandler(this.btnSkip_Click);
            // 
            // lblCurrentLevel
            // 
            this.lblCurrentLevel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(72)))));
            this.lblCurrentLevel.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentLevel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.lblCurrentLevel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCurrentLevel.Location = new System.Drawing.Point(867, 26);
            this.lblCurrentLevel.Name = "lblCurrentLevel";
            this.lblCurrentLevel.Size = new System.Drawing.Size(198, 32);
            this.lblCurrentLevel.TabIndex = 6;
            this.lblCurrentLevel.Text = "Level";
            this.lblCurrentLevel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnAction
            // 
            this.btnAction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(29)))), ((int)(((byte)(28)))));
            this.btnAction.FlatAppearance.BorderSize = 0;
            this.btnAction.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(14)))), ((int)(((byte)(13)))));
            this.btnAction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAction.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.btnAction.Location = new System.Drawing.Point(745, 398);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(148, 55);
            this.btnAction.TabIndex = 0;
            this.btnAction.Text = "Start";
            this.btnAction.UseVisualStyleBackColor = false;
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // lblBackground
            // 
            this.lblBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.lblBackground.Location = new System.Drawing.Point(12, 11);
            this.lblBackground.Name = "lblBackground";
            this.lblBackground.Size = new System.Drawing.Size(1041, 160);
            this.lblBackground.TabIndex = 5;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(494, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1, 139);
            this.label1.TabIndex = 15;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.lblTitle.Location = new System.Drawing.Point(9, 6);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(805, 106);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Poker Tournament Title";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(857, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1, 73);
            this.label2.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(72)))));
            this.label3.Location = new System.Drawing.Point(501, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 57);
            this.label3.TabIndex = 16;
            this.label3.Text = "Blinds";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(501, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(543, 1);
            this.label4.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(72)))));
            this.label5.Location = new System.Drawing.Point(502, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 57);
            this.label5.TabIndex = 18;
            this.label5.Text = "Ante";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblBlinds
            // 
            this.lblBlinds.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.lblBlinds.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlinds.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(72)))));
            this.lblBlinds.Location = new System.Drawing.Point(604, 18);
            this.lblBlinds.Name = "lblBlinds";
            this.lblBlinds.Size = new System.Drawing.Size(449, 68);
            this.lblBlinds.TabIndex = 19;
            this.lblBlinds.Text = "1000/2000";
            this.lblBlinds.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // lblAnte
            // 
            this.lblAnte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.lblAnte.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(72)))));
            this.lblAnte.Location = new System.Drawing.Point(604, 95);
            this.lblAnte.Name = "lblAnte";
            this.lblAnte.Size = new System.Drawing.Size(449, 63);
            this.lblAnte.TabIndex = 20;
            this.lblAnte.Text = "-";
            this.lblAnte.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // lblLevel
            // 
            this.lblLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.lblLevel.Location = new System.Drawing.Point(864, 60);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(172, 47);
            this.lblLevel.TabIndex = 17;
            this.lblLevel.Text = "1";
            this.lblLevel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblNextAnte
            // 
            this.lblNextAnte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(119)))), ((int)(((byte)(116)))));
            this.lblNextAnte.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNextAnte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(72)))));
            this.lblNextAnte.Location = new System.Drawing.Point(604, 269);
            this.lblNextAnte.Name = "lblNextAnte";
            this.lblNextAnte.Size = new System.Drawing.Size(449, 63);
            this.lblNextAnte.TabIndex = 27;
            this.lblNextAnte.Text = "-";
            this.lblNextAnte.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // lblNextBlinds
            // 
            this.lblNextBlinds.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(119)))), ((int)(((byte)(116)))));
            this.lblNextBlinds.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNextBlinds.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(72)))));
            this.lblNextBlinds.Location = new System.Drawing.Point(604, 192);
            this.lblNextBlinds.Name = "lblNextBlinds";
            this.lblNextBlinds.Size = new System.Drawing.Size(449, 68);
            this.lblNextBlinds.TabIndex = 26;
            this.lblNextBlinds.Text = "1000/2000";
            this.lblNextBlinds.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(119)))), ((int)(((byte)(116)))));
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(72)))));
            this.label10.Location = new System.Drawing.Point(502, 272);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 57);
            this.label10.TabIndex = 25;
            this.label10.Text = "Ante";
            this.label10.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(501, 266);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(543, 1);
            this.label11.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(119)))), ((int)(((byte)(116)))));
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(72)))));
            this.label12.Location = new System.Drawing.Point(501, 203);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 57);
            this.label12.TabIndex = 23;
            this.label12.Text = "Blinds";
            this.label12.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(494, 197);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(1, 139);
            this.label13.TabIndex = 22;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(119)))), ((int)(((byte)(116)))));
            this.label14.Location = new System.Drawing.Point(12, 185);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(1041, 160);
            this.label14.TabIndex = 21;
            // 
            // lblNextLevel
            // 
            this.lblNextLevel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(119)))), ((int)(((byte)(116)))));
            this.lblNextLevel.Font = new System.Drawing.Font("Microsoft YaHei UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNextLevel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(72)))));
            this.lblNextLevel.Location = new System.Drawing.Point(16, 211);
            this.lblNextLevel.Name = "lblNextLevel";
            this.lblNextLevel.Size = new System.Drawing.Size(472, 109);
            this.lblNextLevel.TabIndex = 28;
            this.lblNextLevel.Text = "Next Level";
            this.lblNextLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTimeOfDay
            // 
            this.lblTimeOfDay.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeOfDay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.lblTimeOfDay.Location = new System.Drawing.Point(15, 387);
            this.lblTimeOfDay.Name = "lblTimeOfDay";
            this.lblTimeOfDay.Size = new System.Drawing.Size(480, 66);
            this.lblTimeOfDay.TabIndex = 29;
            this.lblTimeOfDay.Text = "1:46 PM";
            this.lblTimeOfDay.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // clock
            // 
            this.clock.Tick += new System.EventHandler(this.clock_Tick);
            // 
            // frmTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(1065, 591);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1081, 629);
            this.Name = "frmTimer";
            this.Text = "Derek\'s Poker Timer";
            this.pnlHeader.ResumeLayout(false);
            this.pnlBody.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lblBackground;
        private System.Windows.Forms.Label lblCurrentLevel;
        private System.Windows.Forms.Button btnSkip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAnte;
        private System.Windows.Forms.Label lblBlinds;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label lblNextAnte;
        private System.Windows.Forms.Label lblNextBlinds;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblNextLevel;
        private System.Windows.Forms.Label lblTimeOfDay;
        private System.Windows.Forms.Timer clock;
    }
}