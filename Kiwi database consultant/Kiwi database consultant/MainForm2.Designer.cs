namespace Kiwi_database_consultant
{
    partial class Appointment
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
            this.buttonAppointment = new System.Windows.Forms.Button();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.buttonInstructor = new System.Windows.Forms.Button();
            this.buttonClient = new System.Windows.Forms.Button();
            this.buttonVechile = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAppointment
            // 
            this.buttonAppointment.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAppointment.Location = new System.Drawing.Point(48, 50);
            this.buttonAppointment.Name = "buttonAppointment";
            this.buttonAppointment.Size = new System.Drawing.Size(100, 33);
            this.buttonAppointment.TabIndex = 0;
            this.buttonAppointment.Text = "Appointment";
            this.buttonAppointment.UseVisualStyleBackColor = true;
            this.buttonAppointment.Click += new System.EventHandler(this.buttonAppointment_Click);
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.Location = new System.Drawing.Point(516, 407);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(100, 33);
            this.buttonLogOut.TabIndex = 1;
            this.buttonLogOut.Text = "Log out";
            this.buttonLogOut.UseVisualStyleBackColor = true;
            // 
            // buttonInstructor
            // 
            this.buttonInstructor.Location = new System.Drawing.Point(350, 171);
            this.buttonInstructor.Name = "buttonInstructor";
            this.buttonInstructor.Size = new System.Drawing.Size(100, 33);
            this.buttonInstructor.TabIndex = 2;
            this.buttonInstructor.Text = "Instructor";
            this.buttonInstructor.UseVisualStyleBackColor = true;
            this.buttonInstructor.Click += new System.EventHandler(this.buttonInstructor_Click);
            // 
            // buttonClient
            // 
            this.buttonClient.Location = new System.Drawing.Point(350, 51);
            this.buttonClient.Name = "buttonClient";
            this.buttonClient.Size = new System.Drawing.Size(100, 33);
            this.buttonClient.TabIndex = 3;
            this.buttonClient.Text = "Client";
            this.buttonClient.UseVisualStyleBackColor = true;
            this.buttonClient.Click += new System.EventHandler(this.buttonClient_Click);
            // 
            // buttonVechile
            // 
            this.buttonVechile.Location = new System.Drawing.Point(21, 171);
            this.buttonVechile.Name = "buttonVechile";
            this.buttonVechile.Size = new System.Drawing.Size(100, 33);
            this.buttonVechile.TabIndex = 4;
            this.buttonVechile.Text = "Vechile";
            this.buttonVechile.UseVisualStyleBackColor = true;
            this.buttonVechile.Click += new System.EventHandler(this.buttonVechile_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.CalendarDimensions = new System.Drawing.Size(2, 1);
            this.monthCalendar1.Location = new System.Drawing.Point(12, 278);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 5;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Teal;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.Window;
            this.button3.Location = new System.Drawing.Point(12, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(198, 109);
            this.button3.TabIndex = 11;
            this.button3.Text = "Appointment";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.Window;
            this.button5.Location = new System.Drawing.Point(272, 144);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(198, 109);
            this.button5.TabIndex = 15;
            this.button5.Text = "Instructor";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Green;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Window;
            this.button2.Location = new System.Drawing.Point(12, 144);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(198, 109);
            this.button2.TabIndex = 14;
            this.button2.Text = "Vechile";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Firebrick;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Window;
            this.button1.Location = new System.Drawing.Point(272, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(198, 109);
            this.button1.TabIndex = 13;
            this.button1.Text = "Client";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Appointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 458);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.buttonVechile);
            this.Controls.Add(this.buttonClient);
            this.Controls.Add(this.buttonInstructor);
            this.Controls.Add(this.buttonLogOut);
            this.Controls.Add(this.buttonAppointment);
            this.Name = "Appointment";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Appointment_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAppointment;
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.Button buttonInstructor;
        private System.Windows.Forms.Button buttonClient;
        private System.Windows.Forms.Button buttonVechile;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}