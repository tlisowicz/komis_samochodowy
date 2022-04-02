
namespace komis_samochodowy
{
    partial class Section2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Section2));
            this.bt_add = new System.Windows.Forms.Button();
            this.bt_cancel = new System.Windows.Forms.Button();
            this.bt_close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbx_brand = new System.Windows.Forms.TextBox();
            this.tbx_model = new System.Windows.Forms.TextBox();
            this.tbx_engine = new System.Windows.Forms.TextBox();
            this.tbx_color = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_add
            // 
            this.bt_add.AccessibleRole = System.Windows.Forms.AccessibleRole.PageTabList;
            this.bt_add.Location = new System.Drawing.Point(337, 304);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(75, 23);
            this.bt_add.TabIndex = 0;
            this.bt_add.Text = "Dodaj";
            this.bt_add.UseVisualStyleBackColor = true;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // bt_cancel
            // 
            this.bt_cancel.AutoSize = true;
            this.bt_cancel.Location = new System.Drawing.Point(431, 304);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(87, 23);
            this.bt_cancel.TabIndex = 1;
            this.bt_cancel.Text = "Wyczyść dane";
            this.bt_cancel.UseVisualStyleBackColor = true;
            // 
            // bt_close
            // 
            this.bt_close.Location = new System.Drawing.Point(542, 304);
            this.bt_close.Name = "bt_close";
            this.bt_close.Size = new System.Drawing.Size(75, 23);
            this.bt_close.TabIndex = 2;
            this.bt_close.Text = "Zrezygnuj";
            this.bt_close.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Marka:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Model:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Typ silnika:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Kolor:";
            // 
            // tbx_brand
            // 
            this.tbx_brand.Location = new System.Drawing.Point(105, 39);
            this.tbx_brand.Name = "tbx_brand";
            this.tbx_brand.Size = new System.Drawing.Size(100, 20);
            this.tbx_brand.TabIndex = 7;
            // 
            // tbx_model
            // 
            this.tbx_model.Location = new System.Drawing.Point(105, 84);
            this.tbx_model.Name = "tbx_model";
            this.tbx_model.Size = new System.Drawing.Size(100, 20);
            this.tbx_model.TabIndex = 8;
            // 
            // tbx_engine
            // 
            this.tbx_engine.Location = new System.Drawing.Point(105, 128);
            this.tbx_engine.Name = "tbx_engine";
            this.tbx_engine.Size = new System.Drawing.Size(100, 20);
            this.tbx_engine.TabIndex = 9;
            // 
            // tbx_color
            // 
            this.tbx_color.Location = new System.Drawing.Point(105, 171);
            this.tbx_color.Name = "tbx_color";
            this.tbx_color.Size = new System.Drawing.Size(100, 20);
            this.tbx_color.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(296, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(363, 264);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // Section2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 355);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbx_color);
            this.Controls.Add(this.tbx_engine);
            this.Controls.Add(this.tbx_model);
            this.Controls.Add(this.tbx_brand);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_close);
            this.Controls.Add(this.bt_cancel);
            this.Controls.Add(this.bt_add);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Section2";
            this.Text = "Section2";
            this.Load += new System.EventHandler(this.Section2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_add;
        private System.Windows.Forms.Button bt_cancel;
        private System.Windows.Forms.Button bt_close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbx_brand;
        private System.Windows.Forms.TextBox tbx_model;
        private System.Windows.Forms.TextBox tbx_engine;
        private System.Windows.Forms.TextBox tbx_color;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}