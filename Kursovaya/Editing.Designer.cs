namespace Kursovaya
{
    partial class Editing
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
            this.secondName = new System.Windows.Forms.TextBox();
            this.Room = new System.Windows.Forms.TextBox();
            this.Criminality = new System.Windows.Forms.TextBox();
            this.Relatives = new System.Windows.Forms.TextBox();
            this.firstName = new System.Windows.Forms.TextBox();
            this.Day = new System.Windows.Forms.TextBox();
            this.Temper = new System.Windows.Forms.TextBox();
            this.Month = new System.Windows.Forms.TextBox();
            this.Year = new System.Windows.Forms.TextBox();
            this.PITPH = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // secondName
            // 
            this.secondName.Location = new System.Drawing.Point(12, 72);
            this.secondName.Name = "secondName";
            this.secondName.Size = new System.Drawing.Size(193, 20);
            this.secondName.TabIndex = 0;
            // 
            // Room
            // 
            this.Room.Location = new System.Drawing.Point(12, 113);
            this.Room.Name = "Room";
            this.Room.Size = new System.Drawing.Size(193, 20);
            this.Room.TabIndex = 1;
            // 
            // Criminality
            // 
            this.Criminality.Location = new System.Drawing.Point(12, 156);
            this.Criminality.Name = "Criminality";
            this.Criminality.Size = new System.Drawing.Size(193, 20);
            this.Criminality.TabIndex = 2;
            // 
            // Relatives
            // 
            this.Relatives.Location = new System.Drawing.Point(12, 279);
            this.Relatives.Name = "Relatives";
            this.Relatives.Size = new System.Drawing.Size(193, 20);
            this.Relatives.TabIndex = 3;
            // 
            // firstName
            // 
            this.firstName.Location = new System.Drawing.Point(12, 33);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(193, 20);
            this.firstName.TabIndex = 4;
            // 
            // Day
            // 
            this.Day.Location = new System.Drawing.Point(12, 198);
            this.Day.Name = "Day";
            this.Day.Size = new System.Drawing.Size(46, 20);
            this.Day.TabIndex = 5;
            // 
            // Temper
            // 
            this.Temper.Location = new System.Drawing.Point(12, 317);
            this.Temper.Name = "Temper";
            this.Temper.Size = new System.Drawing.Size(193, 20);
            this.Temper.TabIndex = 6;
            // 
            // Month
            // 
            this.Month.Location = new System.Drawing.Point(89, 198);
            this.Month.Name = "Month";
            this.Month.Size = new System.Drawing.Size(46, 20);
            this.Month.TabIndex = 7;
            // 
            // Year
            // 
            this.Year.Location = new System.Drawing.Point(159, 198);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(46, 20);
            this.Year.TabIndex = 8;
            // 
            // PITPH
            // 
            this.PITPH.Location = new System.Drawing.Point(12, 238);
            this.PITPH.Name = "PITPH";
            this.PITPH.Size = new System.Drawing.Size(193, 20);
            this.PITPH.TabIndex = 9;
            // 
            // Editing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 369);
            this.Controls.Add(this.PITPH);
            this.Controls.Add(this.Year);
            this.Controls.Add(this.Month);
            this.Controls.Add(this.Temper);
            this.Controls.Add(this.Day);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.Relatives);
            this.Controls.Add(this.Criminality);
            this.Controls.Add(this.Room);
            this.Controls.Add(this.secondName);
            this.Name = "Editing";
            this.Text = "Editing";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox secondName;
        private System.Windows.Forms.TextBox Room;
        private System.Windows.Forms.TextBox Criminality;
        private System.Windows.Forms.TextBox Relatives;
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.TextBox Day;
        private System.Windows.Forms.TextBox Temper;
        private System.Windows.Forms.TextBox Month;
        private System.Windows.Forms.TextBox Year;
        private System.Windows.Forms.TextBox PITPH;
    }
}