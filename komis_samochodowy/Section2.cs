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
using System.Collections.ObjectModel;

namespace komis_samochodowy
{
    public partial class Section2 : Form
    {
        Menu menu;
        public Section2(Menu menu)
        {
            InitializeComponent();
            this.menu = menu;
            openFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
            this.CenterToScreen();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            if (openFileDialog1.FileName.EndsWith(".jpg", StringComparison.CurrentCultureIgnoreCase) || openFileDialog1.FileName.EndsWith(".png", StringComparison.CurrentCultureIgnoreCase))
            {
                pictureBox1.BackgroundImage = Image.FromFile(openFileDialog1.FileName);
                
            } else
            {
                MessageBox.Show("Wybrano nieodpowiedni plik.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void Section2_Load(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = Image.FromFile("..\\..\\cars_info\\brak_podgladu.jpg");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            if (tbx_brand.Text.Equals("") || tbx_color.Equals("") || tbx_engine.Equals("") || tbx_model.Equals(""))
            {
                MessageBox.Show("Żadne pole nie moze być puste.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string main_path = "..\\..\\cars_info\\";

            add_brad(main_path);

            if (add_model(main_path) == true)
            {
                add_color(main_path);
                add_engine(main_path);
                pictureBox1.BackgroundImage.Save("..\\..\\cars_info\\cars\\" + tbx_brand.Text + " " + tbx_model.Text + " " + tbx_color.Text + ".jpg");
                MessageBox.Show("Pomyślnie dodano pojazd.", "Powodzenie");
            }
            if (checkBox1.Checked)
            {
                add_accessories(main_path);
            }

        }

        private void add_brad(string path)
        {
            string[] brands = File.ReadAllLines(path + "brands.txt");

            if (!brands.Contains(tbx_brand.Text)) 
            {
                brands = brands.Append(tbx_brand.Text).ToArray();
                File.WriteAllLines(path + "\\brands.txt", brands);
            }
        }

        private bool add_model(string path)
        {
            ObservableCollection<string> models = new ObservableCollection<string>(File.ReadAllLines(path + "models.txt"));
            bool isError = instert_to_file(models, tbx_brand, tbx_model);
            File.WriteAllLines(path + "\\models.txt", models);
            return isError;
        }
        private bool add_color(string path)
        {
            ObservableCollection<string> colors = new ObservableCollection<string>(File.ReadAllLines(path + "colors.txt"));
            bool isError = instert_to_file(colors, tbx_model, tbx_color);
            File.WriteAllLines(path + "\\colors.txt", colors);
            return isError;
        }

        private bool add_engine(string path)
        {
            ObservableCollection<string> engines = new ObservableCollection<string>(File.ReadAllLines(path + "engines.txt"));
            bool isError = instert_to_file(engines, tbx_model, tbx_engine);
            File.WriteAllLines(path + "\\engines.txt", engines);
            return isError;
        }

        private bool add_accessories(string path)
        {
            ObservableCollection<string> accessories = new ObservableCollection<string>(File.ReadAllLines(path + "accessories.txt"));
            bool isError = instert_to_file(accessories, tbx_model, richTextBox1);
            File.WriteAllLines(path + "\\accessories.txt", accessories);
            return isError;
        }
        private bool instert_to_file(ObservableCollection<string> file_content, TextBox parent_tbx, Control child_tbx)
        {
            if (!file_content.Contains("[" + parent_tbx.Text + "]"))
            {
                file_content.Add("[" + parent_tbx.Text + "]");
                file_content.Add("----");
            }
            int pos = file_content.IndexOf("[" + parent_tbx.Text + "]");
            for (int i = pos; i < file_content.Count; ++i)
            {
                string current_line = file_content.ElementAt(i);
                if (current_line == child_tbx.Text)
                {
                    MessageBox.Show("Taki samochód jest już zarejetrowany w komisie", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (current_line.Equals("----"))
                {
                    file_content.Insert(i, child_tbx.Text);
                    return true;
                }
            }
            return false;
        }

        private void bt_close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Na pewno przerwać proces dodawania?", "Zamykanie", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            tbx_brand.Text = String.Empty;
            tbx_model.Text = String.Empty;
            tbx_engine.Text = String.Empty;
            tbx_color.Text = String.Empty;
            richTextBox1.Text = String.Empty;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!richTextBox1.Visible)
            {
                richTextBox1.Show();
            }
            else
            {
                richTextBox1.Hide();
            }
        }

        private void Section2_FormClosing(object sender, FormClosingEventArgs e)
        {
            menu.Section2_enabled = false;
        }
    }
}
