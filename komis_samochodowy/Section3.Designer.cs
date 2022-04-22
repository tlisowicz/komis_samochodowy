
namespace komis_samochodowy
{
    partial class Section3
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.lst_to_book = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lst_booked = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbx_hour = new System.Windows.Forms.TextBox();
            this.tbx_minutes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tbx_name = new System.Windows.Forms.TextBox();
            this.tbx_surname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(264, 66);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // lst_to_book
            // 
            this.lst_to_book.FormattingEnabled = true;
            this.lst_to_book.HorizontalScrollbar = true;
            this.lst_to_book.Location = new System.Drawing.Point(11, 127);
            this.lst_to_book.Name = "lst_to_book";
            this.lst_to_book.Size = new System.Drawing.Size(205, 95);
            this.lst_to_book.TabIndex = 1;
            this.lst_to_book.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Wybrane samochody: ";
            // 
            // lst_booked
            // 
            this.lst_booked.FormattingEnabled = true;
            this.lst_booked.HorizontalScrollbar = true;
            this.lst_booked.Location = new System.Drawing.Point(11, 268);
            this.lst_booked.Name = "lst_booked";
            this.lst_booked.Size = new System.Drawing.Size(205, 95);
            this.lst_booked.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Zarezerwowane terminy jazd:";
            // 
            // tbx_hour
            // 
            this.tbx_hour.Location = new System.Drawing.Point(380, 34);
            this.tbx_hour.Name = "tbx_hour";
            this.tbx_hour.Size = new System.Drawing.Size(33, 20);
            this.tbx_hour.TabIndex = 5;
            this.tbx_hour.Text = "08";
            // 
            // tbx_minutes
            // 
            this.tbx_minutes.Location = new System.Drawing.Point(431, 34);
            this.tbx_minutes.Name = "tbx_minutes";
            this.tbx_minutes.Size = new System.Drawing.Size(33, 20);
            this.tbx_minutes.TabIndex = 6;
            this.tbx_minutes.Text = "00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(415, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = ":";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(325, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Godzina:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(361, 251);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Zarezerwuj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbx_name
            // 
            this.tbx_name.Location = new System.Drawing.Point(87, 46);
            this.tbx_name.Name = "tbx_name";
            this.tbx_name.Size = new System.Drawing.Size(100, 20);
            this.tbx_name.TabIndex = 10;
            // 
            // tbx_surname
            // 
            this.tbx_surname.Location = new System.Drawing.Point(87, 76);
            this.tbx_surname.Name = "tbx_surname";
            this.tbx_surname.Size = new System.Drawing.Size(100, 20);
            this.tbx_surname.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(92, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Dane do rejestracji";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Imię:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Nazwisko:";
            // 
            // Section3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 420);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbx_surname);
            this.Controls.Add(this.tbx_name);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbx_minutes);
            this.Controls.Add(this.tbx_hour);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lst_booked);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lst_to_book);
            this.Controls.Add(this.monthCalendar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Section3";
            this.Text = "Section3";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Section3_FormClosing);
            this.Load += new System.EventHandler(this.Section3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.MonthCalendar monthCalendar1;
        public System.Windows.Forms.ListBox lst_to_book;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ListBox lst_booked;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbx_hour;
        private System.Windows.Forms.TextBox tbx_minutes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbx_name;
        private System.Windows.Forms.TextBox tbx_surname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}