namespace ctrlAlarmLib
{
    partial class ctrlAlarmClock
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
            this.lblAlarmTime = new System.Windows.Forms.Label();
            this.btnAlarmOff = new System.Windows.Forms.Button();
            this.dtpAlarm = new System.Windows.Forms.DateTimePicker();
            this.lblSetAlarm = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnGame = new System.Windows.Forms.Button();
            this.lblSelectGane = new System.Windows.Forms.Label();
            this.cmbSelectGame = new System.Windows.Forms.ComboBox();
            this.btnSetGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAlarmTime
            // 
            this.lblAlarmTime.AutoSize = true;
            this.lblAlarmTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlarmTime.Location = new System.Drawing.Point(101, 79);
            this.lblAlarmTime.Name = "lblAlarmTime";
            this.lblAlarmTime.Size = new System.Drawing.Size(0, 16);
            this.lblAlarmTime.TabIndex = 7;
            this.lblAlarmTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAlarmTime.Visible = false;
            // 
            // btnAlarmOff
            // 
            this.btnAlarmOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlarmOff.Location = new System.Drawing.Point(322, 76);
            this.btnAlarmOff.Name = "btnAlarmOff";
            this.btnAlarmOff.Size = new System.Drawing.Size(75, 29);
            this.btnAlarmOff.TabIndex = 8;
            this.btnAlarmOff.Text = "Alarm Off";
            this.btnAlarmOff.UseVisualStyleBackColor = true;
            this.btnAlarmOff.Click += new System.EventHandler(this.btnAlarmOff_Click);
            // 
            // dtpAlarm
            // 
            this.dtpAlarm.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpAlarm.Location = new System.Drawing.Point(119, 190);
            this.dtpAlarm.Name = "dtpAlarm";
            this.dtpAlarm.Size = new System.Drawing.Size(141, 20);
            this.dtpAlarm.TabIndex = 9;
            this.dtpAlarm.ValueChanged += new System.EventHandler(this.dtpAlarm_ValueChanged);
            // 
            // lblSetAlarm
            // 
            this.lblSetAlarm.AutoSize = true;
            this.lblSetAlarm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSetAlarm.Location = new System.Drawing.Point(11, 190);
            this.lblSetAlarm.Name = "lblSetAlarm";
            this.lblSetAlarm.Size = new System.Drawing.Size(83, 20);
            this.lblSetAlarm.TabIndex = 10;
            this.lblSetAlarm.Text = "Set Alarm:";
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Location = new System.Drawing.Point(284, 187);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(74, 28);
            this.btnOk.TabIndex = 11;
            this.btnOk.Text = "Set Alarm";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnGame
            // 
            this.btnGame.Location = new System.Drawing.Point(204, 266);
            this.btnGame.Name = "btnGame";
            this.btnGame.Size = new System.Drawing.Size(81, 41);
            this.btnGame.TabIndex = 12;
            this.btnGame.Text = "Preview Game";
            this.btnGame.UseVisualStyleBackColor = true;
            this.btnGame.Click += new System.EventHandler(this.btnGame_Click);
            // 
            // lblSelectGane
            // 
            this.lblSelectGane.AutoSize = true;
            this.lblSelectGane.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectGane.Location = new System.Drawing.Point(11, 243);
            this.lblSelectGane.Name = "lblSelectGane";
            this.lblSelectGane.Size = new System.Drawing.Size(91, 20);
            this.lblSelectGane.TabIndex = 13;
            this.lblSelectGane.Text = "Select Game:";
            // 
            // cmbSelectGame
            // 
            this.cmbSelectGame.FormattingEnabled = true;
            this.cmbSelectGame.Items.AddRange(new object[] {
            "Matching Game",
            "Music Game"});
            this.cmbSelectGame.Location = new System.Drawing.Point(15, 277);
            this.cmbSelectGame.Name = "cmbSelectGame";
            this.cmbSelectGame.Size = new System.Drawing.Size(159, 21);
            this.cmbSelectGame.TabIndex = 14;
            // 
            // btnSetGame
            // 
            this.btnSetGame.Location = new System.Drawing.Point(305, 268);
            this.btnSetGame.Name = "btnSetGame";
            this.btnSetGame.Size = new System.Drawing.Size(80, 38);
            this.btnSetGame.TabIndex = 15;
            this.btnSetGame.Text = "Set Game";
            this.btnSetGame.UseVisualStyleBackColor = true;
            // 
            // ctrlAlarmClock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Controls.Add(this.btnSetGame);
            this.Controls.Add(this.cmbSelectGame);
            this.Controls.Add(this.lblSelectGane);
            this.Controls.Add(this.btnGame);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblSetAlarm);
            this.Controls.Add(this.dtpAlarm);
            this.Controls.Add(this.btnAlarmOff);
            this.Controls.Add(this.lblAlarmTime);
            this.Name = "ctrlAlarmClock";
            this.Controls.SetChildIndex(this.lblAlarmTime, 0);
            this.Controls.SetChildIndex(this.btnAlarmOff, 0);
            this.Controls.SetChildIndex(this.dtpAlarm, 0);
            this.Controls.SetChildIndex(this.lblSetAlarm, 0);
            this.Controls.SetChildIndex(this.btnOk, 0);
            this.Controls.SetChildIndex(this.btnGame, 0);
            this.Controls.SetChildIndex(this.lblSelectGane, 0);
            this.Controls.SetChildIndex(this.cmbSelectGame, 0);
            this.Controls.SetChildIndex(this.btnSetGame, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAlarmTime;
        private System.Windows.Forms.Button btnAlarmOff;
        private System.Windows.Forms.DateTimePicker dtpAlarm;
        private System.Windows.Forms.Label lblSetAlarm;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnGame;
        private System.Windows.Forms.Label lblSelectGane;
        private System.Windows.Forms.ComboBox cmbSelectGame;
        private System.Windows.Forms.Button btnSetGame;
    }
}
