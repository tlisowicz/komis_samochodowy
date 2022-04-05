using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace komis_samochodowy
{
    public partial class Section1 : Form
    {
        Menu menu;
        Section3 section3;
        public Section1(Menu menu, Section3 section3)
        {
            InitializeComponent();
            this.menu = menu;
            this.section3 = section3;
        }

        private string [] take_cars_info(string path, string pattern)
        {
            string[] result = File.ReadLines(path)
                                .SkipWhile(line => !line.Contains("[" + pattern  + "]"))
                                .Skip(1)
                                .TakeWhile(line => !line.Equals("----"))
                                .ToArray();        
            return result;
        }
        private void change_picture()
        {
            if (cb_brand.SelectedItem != null && cb_model.SelectedItem != null && cb_engine.SelectedItem != null && cb_color.SelectedItem != null)
            {
                string path = "..\\..\\cars_info\\cars\\" + cb_brand.SelectedItem.ToString() + " " + cb_model.SelectedItem.ToString() + " " + cb_color.SelectedItem.ToString() + ".jpg";
                try
                {
                    pictureBox1.BackgroundImage = Image.FromFile(path);
                    pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
                } catch (FileNotFoundException)
                {                   
                    pictureBox1.BackgroundImage = Image.FromFile("..\\..\\cars_info\\brak_podgladu.jpg");
                    pictureBox1.BackgroundImageLayout = ImageLayout.Center;
                }
            }

        }

        private void Section1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }

        private void Section1_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            string main_path = "..\\..\\cars_info";
            List<string> brands = new List<string>(File.ReadAllLines(main_path +"\\brands.txt"));
            cb_brand.Items.AddRange(brands.ToArray());
            cb_brand.SelectedItem = cb_brand.Items[0];
        }

        private void cb_DrawItem(object sender, DrawItemEventArgs e)
        {
            ComboBox cbx = sender as ComboBox;
            if (cbx != null)
            {
                e.DrawBackground();

                if (e.Index >= 0)
                {
                    StringFormat sf = new StringFormat();
                    sf.LineAlignment = StringAlignment.Center;
                    sf.Alignment = StringAlignment.Center;

                    Brush brush = new SolidBrush(cbx.ForeColor);

                    if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                        brush = SystemBrushes.HighlightText;

                    e.Graphics.DrawString(cbx.Items[e.Index].ToString(), cbx.Font, brush, e.Bounds, sf);
                }
            }
        }

        private void cb_brand_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_model.Items.Clear();
            cb_model.Items.AddRange(take_cars_info("..\\..\\cars_info\\models.txt", cb_brand.SelectedItem.ToString()));
            cb_model.SelectedItem = cb_model.Items[0];
            change_picture();
        }

        private void cb_model_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_engine.Items.Clear();
            cb_engine.Items.AddRange(take_cars_info("..\\..\\cars_info\\engines.txt", cb_model.SelectedItem.ToString()));
            cb_engine.SelectedItem = cb_engine.Items[0];

            cb_color.Items.Clear();
            cb_color.Items.AddRange(take_cars_info("..\\..\\cars_info\\colors.txt", cb_model.SelectedItem.ToString()));
            cb_color.SelectedItem = cb_color.Items[0];
            change_picture();

            checkedListBox1.Items.Clear();
            checkedListBox1.Items.AddRange(take_cars_info("..\\..\\cars_info\\accessories.txt", cb_model.SelectedItem.ToString()));

        }

        private void cb_engine_SelectedIndexChanged(object sender, EventArgs e)
        {
            change_picture();
        }

        private void cb_color_SelectedIndexChanged(object sender, EventArgs e)
        {
            change_picture();
        }

        private void bt_pick_Click(object sender, EventArgs e)
        {
            string model = cb_brand.Text + " " + cb_model.Text + " " + "silnik: " + cb_engine.Text + " kolor: " + cb_color.Text;
            List<string> book_drive = new List<string>(File.ReadAllLines(@"..\..\cars_info\book_drive.txt"));
            if (!book_drive.Contains(model))
            {

                File.AppendAllText(@"..\..\cars_info\book_drive.txt", model + "\n");
                MessageBox.Show("Wybrano model. Proszę przejść do sekcji menu, w celu skonsultowania terminu jazdy próbnej", "Wybrano model");
            } else
            {
                MessageBox.Show("Ten samochód został już wybrany.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkedListBox1.Visible)
            {
                checkedListBox1.Show();
            } else
            {
                checkedListBox1.Hide();
            }
        }

        private void Section1_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            menu.Section1_enabled = false;
        }
    }
}
