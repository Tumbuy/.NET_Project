namespace Notes
{
    partial class Reminder
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
            this.button1 = new System.Windows.Forms.Button();
            this.MyMonthCalendar = new System.Windows.Forms.MonthCalendar();
            this.MyTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(55, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MyMonthCalendar
            // 
            this.MyMonthCalendar.Location = new System.Drawing.Point(9, 44);
            this.MyMonthCalendar.Name = "MyMonthCalendar";
            this.MyMonthCalendar.TabIndex = 4;
            // 
            // MyTimePicker
            // 
            this.MyTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.MyTimePicker.Location = new System.Drawing.Point(55, 12);
            this.MyTimePicker.Name = "MyTimePicker";
            this.MyTimePicker.ShowUpDown = true;
            this.MyTimePicker.Size = new System.Drawing.Size(72, 20);
            this.MyTimePicker.TabIndex = 3;
            // 
            // Reminder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 249);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MyMonthCalendar);
            this.Controls.Add(this.MyTimePicker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Reminder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Reminder";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.MonthCalendar MyMonthCalendar;
        public System.Windows.Forms.DateTimePicker MyTimePicker;
    }
}