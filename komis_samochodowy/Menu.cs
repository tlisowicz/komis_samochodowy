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
        public Menu()
        {
            InitializeComponent();
            this.section1 = new Section1(this);
            this.section2 = new Section2(this);
            this.section3 = new Section3(this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void to_section1_Click(object sender, EventArgs e)
        {
            if (!section1.IsAccessible)
            {
                this.section1 = new Section1(this);
            }
            section1.Show();
        }

        private void to_section2_Click(object sender, EventArgs e)
        {
            if (!section2.IsAccessible)
            {
                this.section2 = new Section2(this);
            }
            section2.Show();
        }

        private void to_section3_Click(object sender, EventArgs e)
        {
            if (!section3.IsAccessible)
            {
                this.section3 = new Section3(this);
            }
            section3.Show();
        }
    }
}
