namespace Kursovaya
{
    partial class Add_Form
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
            this.First_Name = new System.Windows.Forms.TextBox();
            this.Second_Name = new System.Windows.Forms.TextBox();
            this.Room = new System.Windows.Forms.TextBox();
            this.Criminality = new System.Windows.Forms.TextBox();
            this.Temper = new System.Windows.Forms.TextBox();
            this.Relatives = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Day = new System.Windows.Forms.TextBox();
            this.Month = new System.Windows.Forms.TextBox();
            this.Year = new System.Windows.Forms.TextBox();
            this.Add_button = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.PITPH = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // FirstName
            // 
            this.First_Name.Location = new System.Drawing.Point(12, 27);
            this.First_Name.Name = "First_Name";
            this.First_Name.Size = new System.Drawing.Size(273, 20);
            this.First_Name.TabIndex = 0;
            // 
            // SecondName
            // 
            this.Second_Name.Location = new System.Drawing.Point(12, 66);
            this.Second_Name.Name = "Second_Name";
            this.Second_Name.Size = new System.Drawing.Size(273, 20);
            this.Second_Name.TabIndex = 1;
            // 
            // Room
            // 
            this.Room.Location = new System.Drawing.Point(12, 105);
            this.Room.Name = "Room";
            this.Room.Size = new System.Drawing.Size(273, 20);
            this.Room.TabIndex = 2;
            this.Room.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.check);
            // 
            // Criminality
            // 
            this.Criminality.Location = new System.Drawing.Point(12, 147);
            this.Criminality.Name = "Criminality";
            this.Criminality.Size = new System.Drawing.Size(273, 20);
            this.Criminality.TabIndex = 3;
            // 
            // Temper
            // 
            this.Temper.Location = new System.Drawing.Point(12, 306);
            this.Temper.Name = "Temper";
            this.Temper.Size = new System.Drawing.Size(273, 20);
            this.Temper.TabIndex = 6;
            // 
            // Relatives
            // 
            this.Relatives.Location = new System.Drawing.Point(12, 265);
            this.Relatives.Name = "Relatives";
            this.Relatives.Size = new System.Drawing.Size(273, 20);
            this.Relatives.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Фамилия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Камера";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Статья";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Дата заключения (ДД/ММ/ГГГГ)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Место в тюремной иерархии";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 249);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Родственики";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 288);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Характер";
            // 
            // Day
            // 
            this.Day.Location = new System.Drawing.Point(25, 187);
            this.Day.Name = "Day";
            this.Day.Size = new System.Drawing.Size(69, 20);
            this.Day.TabIndex = 16;
            this.Day.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.check);
            // 
            // Month
            // 
            this.Month.Location = new System.Drawing.Point(100, 187);
            this.Month.Name = "Month";
            this.Month.Size = new System.Drawing.Size(69, 20);
            this.Month.TabIndex = 17;
            this.Month.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.check);
            // 
            // Year
            // 
            this.Year.Location = new System.Drawing.Point(175, 187);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(95, 20);
            this.Year.TabIndex = 18;
            this.Year.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.check);
            // 
            // Add_button
            // 
            this.Add_button.Location = new System.Drawing.Point(12, 337);
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(99, 23);
            this.Add_button.TabIndex = 19;
            this.Add_button.Text = "Добавить";
            this.Add_button.UseVisualStyleBackColor = true;
            this.Add_button.Click += new System.EventHandler(this.Add_button_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(186, 337);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(99, 23);
            this.cancelButton.TabIndex = 20;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // PITPH
            // 
            this.PITPH.FormattingEnabled = true;
            this.PITPH.Items.AddRange(new object[] {
            "Бугор",
            "Пахан",
            "Шестерка",
            "Чёрт",
            "Блатной",
            "Петух",
            "Вор в законе(Батя)",
            "Козел"});
            this.PITPH.Location = new System.Drawing.Point(12, 225);
            this.PITPH.Name = "PITPH";
            this.PITPH.Size = new System.Drawing.Size(273, 21);
            this.PITPH.TabIndex = 21;
            // 
            // Add_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 372);
            this.Controls.Add(this.PITPH);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.Add_button);
            this.Controls.Add(this.Year);
            this.Controls.Add(this.Month);
            this.Controls.Add(this.Day);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Relatives);
            this.Controls.Add(this.Temper);
            this.Controls.Add(this.Criminality);
            this.Controls.Add(this.Room);
            this.Controls.Add(this.Second_Name);
            this.Controls.Add(this.First_Name);
            this.Name = "Add_Form";
            this.Text = "Add";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox First_Name;
        private System.Windows.Forms.TextBox Second_Name;
        private System.Windows.Forms.TextBox Room;
        private System.Windows.Forms.TextBox Criminality;
        private System.Windows.Forms.TextBox Temper;
        private System.Windows.Forms.TextBox Relatives;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Day;
        private System.Windows.Forms.TextBox Month;
        private System.Windows.Forms.TextBox Year;
        private System.Windows.Forms.Button Add_button;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ComboBox PITPH;
    }
}