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
            lst_to_book.Items.AddRange(File.ReadAllLines(@"..\..\cars_info\book_drive.txt"));
            lst_booked.Items.AddRange(File.ReadAllLines(@"..\..\cars_info\booked_drive.txt"));
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

            if (tbx_name.Text.Equals("") || tbx_name.Text.Equals(""))
            {
                MessageBox.Show("Proszę podać imię i nazwisko. ", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (lst_to_book.SelectedItem is null)
            {
                MessageBox.Show("Proszę wybrać pojazd.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (int.TryParse(tbx_hour.Text, out hour) == false || int.TryParse(tbx_minutes.Text, out minutes) == false)
            {
                MessageBox.Show("Wybrana godzina jest niepoprawna.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbx_minutes.Text = String.Empty;
                tbx_hour.Text = String.Empty;
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

            foreach (string date in lst_booked.Items)
            {
                if (date.Contains(monthCalendar1.SelectionStart.Date.AddHours(hour).AddMinutes(minutes).ToString("dd/MM/yyyy HH:mm")) && date.Contains(tbx_name.Text + " " + tbx_surname.Text))
                {
                   MessageBox.Show("Jazda próbna została już zarejestrowana na tę godzinę.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   return;
                }
            }

            string final_string = lst_to_book.SelectedItem + " " + monthCalendar1.SelectionStart.Date.AddHours(hour).AddMinutes(minutes).ToString("dd/MM/yyyy HH:mm ") + tbx_name.Text + " " + tbx_surname.Text;
            lst_booked.Items.Add(final_string);

            string filename = @"..\..\cars_info\book_drive.txt";
            File.WriteAllLines(filename, File.ReadAllLines(filename).Where(line => !line.Equals(lst_to_book.SelectedItem)).ToList());
            lst_to_book.Items.Remove(lst_to_book.SelectedItem);
            File.WriteAllText(@"..\..\cars_info\booked_drive.txt", final_string + "\n");

        }
    }
}
