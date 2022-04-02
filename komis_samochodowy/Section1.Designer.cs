
namespace komis_samochodowy
{
    partial class Section1
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
            this.cb_brand = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_model = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_engine = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_color = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bt_pick = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_brand
            // 
            this.cb_brand.BackColor = System.Drawing.SystemColors.Window;
            this.cb_brand.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_brand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_brand.FormattingEnabled = true;
            this.cb_brand.Location = new System.Drawing.Point(28, 115);
            this.cb_brand.Name = "cb_brand";
            this.cb_brand.Size = new System.Drawing.Size(121, 21);
            this.cb_brand.TabIndex = 0;
            this.cb_brand.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cb_DrawItem);
            this.cb_brand.SelectedIndexChanged += new System.EventHandler(this.cb_brand_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Marka";
            // 
            // cb_model
            // 
            this.cb_model.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_model.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_model.FormattingEnabled = true;
            this.cb_model.Location = new System.Drawing.Point(28, 177);
            this.cb_model.Name = "cb_model";
            this.cb_model.Size = new System.Drawing.Size(121, 21);
            this.cb_model.TabIndex = 2;
            this.cb_model.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cb_DrawItem);
            this.cb_model.SelectedIndexChanged += new System.EventHandler(this.cb_model_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Model";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Silnik";
            // 
            // cb_engine
            // 
            this.cb_engine.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_engine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_engine.FormattingEnabled = true;
            this.cb_engine.Location = new System.Drawing.Point(28, 245);
            this.cb_engine.Name = "cb_engine";
            this.cb_engine.Size = new System.Drawing.Size(121, 21);
            this.cb_engine.TabIndex = 4;
            this.cb_engine.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cb_DrawItem);
            this.cb_engine.SelectedIndexChanged += new System.EventHandler(this.cb_engine_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Kolor";
            // 
            // cb_color
            // 
            this.cb_color.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_color.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_color.FormattingEnabled = true;
            this.cb_color.Location = new System.Drawing.Point(28, 302);
            this.cb_color.Name = "cb_color";
            this.cb_color.Size = new System.Drawing.Size(121, 21);
            this.cb_color.TabIndex = 6;
            this.cb_color.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cb_DrawItem);
            this.cb_color.SelectedIndexChanged += new System.EventHandler(this.cb_color_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(245, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(505, 335);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // bt_pick
            // 
            this.bt_pick.Location = new System.Drawing.Point(28, 369);
            this.bt_pick.Name = "bt_pick";
            this.bt_pick.Size = new System.Drawing.Size(116, 23);
            this.bt_pick.TabIndex = 9;
            this.bt_pick.Text = "Wybierz";
            this.bt_pick.UseVisualStyleBackColor = true;
            this.bt_pick.Click += new System.EventHandler(this.bt_pick_Click);
            // 
            // Section1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_pick);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cb_color);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_engine);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_model);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_brand);
            this.Name = "Section1";
            this.Text = "Section1";
            this.Load += new System.EventHandler(this.Section1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox cb_engine;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.ComboBox cb_color;
        public System.Windows.Forms.ComboBox cb_brand;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cb_model;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bt_pick;
    }
}