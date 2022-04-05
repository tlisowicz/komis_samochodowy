using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.ObjectModel;
using System.IO;

namespace komis_samochodowy
{
    public partial class Section3 : Form
    {
        Menu menu;
        Section1 section1;
        public Section3(Menu menu, Section1 section1)
        {
            InitializeComponent();
            this.menu = menu;
            this.section1 = section1;
        }

        private void Section3_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            listBox1.Items.AddRange(File.ReadAllLines(@"..\..\cars_info\book_drive.txt"));
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            monthCalendar1.SelectionEnd = monthCalendar1.SelectionStart;
        }

        private void Section3_FormClosing(object sender, FormClosingEventArgs e)
        {
            menu.Section3_enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int hour;
            int minutes;

            if (listBox1.SelectedItem is null)
            {
                MessageBox.Show("Prosze wybrać pojazd.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (int.TryParse(textBox1.Text, out hour) == false || int.TryParse(textBox2.Text, out minutes) == false)
            {
                MessageBox.Show("Wybrana godzina jest niepoprawna.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox2.Text = String.Empty;
                textBox1.Text = String.Empty;
                return;
            }

            if (hour < 8 || hour > 19 || minutes > 59 || minutes < 0)
            {
                MessageBox.Show("Komis jest czynny w godzinach 8:00 - 20:00. Proszę wybrać odpowiednią godzinę.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (monthCalendar1.SelectionStart < DateTime.Now.AddDays(-1))
            {
                MessageBox.Show("Wybrany dzień jest niepoprawny.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (string date in listBox2.Items)
            {
                if (date.Contains(monthCalendar1.SelectionStart.Date.AddHours(hour).AddMinutes(minutes).ToString("dd/MM/yyyy HH:mm")))
                {
                   MessageBox.Show("Jazda próbna została już zarejestrowana na tę godzinę.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   return;
                }
            }

            string final_string = listBox1.SelectedItem + " " + monthCalendar1.SelectionStart.Date.AddHours(hour).AddMinutes(minutes).ToString("dd/MM/yyyy HH:mm");
            listBox2.Items.Add(final_string);

            string filename = @"..\..\cars_info\book_drive.txt";
            File.WriteAllLines(filename, File.ReadAllLines(filename).Where(line => !line.Equals(listBox1.SelectedItem)).ToList());
            listBox1.Items.Remove(listBox1.SelectedItem);

        }
    }
}
