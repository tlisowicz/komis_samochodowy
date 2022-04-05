using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace komis_samochodowy
{
    public partial class Menu : Form
    {
        Section1 section1;
        Section2 section2;
        Section3 section3;
        bool section1_enabled = false;
        bool section2_enabled = false;
        bool section3_enabled = false;
        public Menu()
        {
            InitializeComponent();
            this.section1 = new Section1(this, section3);
            this.section2 = new Section2(this);
            this.section3 = new Section3(this, section1);
        }

        public bool Section1_enabled { get => section1_enabled; set => section1_enabled = value; }
        public bool Section2_enabled { get => section2_enabled; set => section2_enabled = value; }
        public bool Section3_enabled { get => section3_enabled; set => section3_enabled = value; }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void to_section1_Click(object sender, EventArgs e)
        {
            if (!section1.IsAccessible)
            {
                this.section1 = new Section1(this, section3);
            }
            if (!Section1_enabled)
            {
                section1.Show();
                Section1_enabled = true;
            }
        }

        private void to_section2_Click(object sender, EventArgs e)
        {
            if (!section2.IsAccessible)
            {
                this.section2 = new Section2(this);
            }
            if (!Section2_enabled)
            {
                section2.Show();
                Section2_enabled = true;
            }
        }

        private void to_section3_Click(object sender, EventArgs e)
        {
            if (!section3.IsAccessible)
            {
                this.section3 = new Section3(this, section1);
            }
            if (!Section3_enabled)
            {
                section3.Show();
                Section3_enabled = true;
            }
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Zakończyć?", "Zamykanie", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
