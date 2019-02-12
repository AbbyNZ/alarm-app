namespace Test
{
    partial class Test
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
            this.ctrlAlarmClock1 = new ctrlAlarmLib.ctrlAlarmClock();
            this.ctrlAlarmClock2 = new ctrlAlarmLib.ctrlAlarmClock();
            this.SuspendLayout();
            // 
            // ctrlAlarmClock1
            // 
            this.ctrlAlarmClock1.AlarmSet = false;
            this.ctrlAlarmClock1.AlarmTime = new System.DateTime(((long)(0)));
            this.ctrlAlarmClock1.ClockForeColor = System.Drawing.Color.Empty;
            this.ctrlAlarmClock1.Location = new System.Drawing.Point(298, 211);
            this.ctrlAlarmClock1.Name = "ctrlAlarmClock1";
            this.ctrlAlarmClock1.Size = new System.Drawing.Size(8, 8);
            this.ctrlAlarmClock1.TabIndex = 0;
            // 
            // ctrlAlarmClock2
            // 
            this.ctrlAlarmClock2.AlarmSet = false;
            this.ctrlAlarmClock2.AlarmTime = new System.DateTime(((long)(0)));
            this.ctrlAlarmClock2.ClockForeColor = System.Drawing.Color.Empty;
            this.ctrlAlarmClock2.Location = new System.Drawing.Point(12, 3);
            this.ctrlAlarmClock2.Name = "ctrlAlarmClock2";
            this.ctrlAlarmClock2.Size = new System.Drawing.Size(408, 327);
            this.ctrlAlarmClock2.TabIndex = 1;
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 342);
            this.Controls.Add(this.ctrlAlarmClock2);
            this.Controls.Add(this.ctrlAlarmClock1);
            this.Name = "Test";
            this.Text = "Test Form";
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlAlarmLib.ctrlAlarmClock ctrlAlarmClock1;
        private ctrlAlarmLib.ctrlAlarmClock ctrlAlarmClock2;
    }
}

