
namespace komis_samochodowy
{
    partial class Menu
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.title = new System.Windows.Forms.Label();
            this.to_section1 = new System.Windows.Forms.Button();
            this.to_section2 = new System.Windows.Forms.Button();
            this.to_section3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.Font = new System.Drawing.Font("Candara", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(12, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(272, 87);
            this.title.TabIndex = 0;
            this.title.Text = "Komis samochodowy";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // to_section1
            // 
            this.to_section1.AutoSize = true;
            this.to_section1.Location = new System.Drawing.Point(82, 118);
            this.to_section1.Name = "to_section1";
            this.to_section1.Size = new System.Drawing.Size(124, 23);
            this.to_section1.TabIndex = 1;
            this.to_section1.Text = "Wybierz samochód";
            this.to_section1.UseVisualStyleBackColor = true;
            this.to_section1.Click += new System.EventHandler(this.to_section1_Click);
            // 
            // to_section2
            // 
            this.to_section2.AutoSize = true;
            this.to_section2.Location = new System.Drawing.Point(82, 158);
            this.to_section2.Name = "to_section2";
            this.to_section2.Size = new System.Drawing.Size(124, 23);
            this.to_section2.TabIndex = 2;
            this.to_section2.Text = "Dodaj samochód";
            this.to_section2.UseVisualStyleBackColor = true;
            this.to_section2.Click += new System.EventHandler(this.to_section2_Click);
            // 
            // to_section3
            // 
            this.to_section3.Location = new System.Drawing.Point(82, 200);
            this.to_section3.Name = "to_section3";
            this.to_section3.Size = new System.Drawing.Size(124, 36);
            this.to_section3.TabIndex = 3;
            this.to_section3.Text = "Zarezerwuj termin jazdy próbnej";
            this.to_section3.UseVisualStyleBackColor = true;
            this.to_section3.Click += new System.EventHandler(this.to_section3_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 256);
            this.Controls.Add(this.to_section3);
            this.Controls.Add(this.to_section2);
            this.Controls.Add(this.to_section1);
            this.Controls.Add(this.title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Menu_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button to_section1;
        private System.Windows.Forms.Button to_section2;
        private System.Windows.Forms.Button to_section3;
    }
}

