namespace Weight_Converter
{
    partial class WeightConverter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WeightConverter));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.weightpicture = new System.Windows.Forms.PictureBox();
            this.Ibs_Textbox = new System.Windows.Forms.TextBox();
            this.Ibs_label = new System.Windows.Forms.Label();
            this.kg_label = new System.Windows.Forms.Label();
            this.kg_textBox = new System.Windows.Forms.TextBox();
            this.exit = new System.Windows.Forms.Label();
            this.convertbtn = new System.Windows.Forms.Button();
            this.Clearbtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weightpicture)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.weightpicture);
            this.panel1.Location = new System.Drawing.Point(-2, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(410, 568);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(97, 381);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ibs to Kg Converter";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // weightpicture
            // 
            this.weightpicture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("weightpicture.BackgroundImage")));
            this.weightpicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.weightpicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.weightpicture.Enabled = false;
            this.weightpicture.Location = new System.Drawing.Point(-38, 3);
            this.weightpicture.Name = "weightpicture";
            this.weightpicture.Size = new System.Drawing.Size(448, 633);
            this.weightpicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.weightpicture.TabIndex = 0;
            this.weightpicture.TabStop = false;
            this.weightpicture.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Ibs_Textbox
            // 
            this.Ibs_Textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ibs_Textbox.ForeColor = System.Drawing.Color.Teal;
            this.Ibs_Textbox.Location = new System.Drawing.Point(650, 149);
            this.Ibs_Textbox.Multiline = true;
            this.Ibs_Textbox.Name = "Ibs_Textbox";
            this.Ibs_Textbox.Size = new System.Drawing.Size(202, 56);
            this.Ibs_Textbox.TabIndex = 1;
            this.Ibs_Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Ibs_Textbox.TextChanged += new System.EventHandler(this.Ibs_Textbox_TextChanged);
            // 
            // Ibs_label
            // 
            this.Ibs_label.AutoSize = true;
            this.Ibs_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ibs_label.Location = new System.Drawing.Point(499, 168);
            this.Ibs_label.Name = "Ibs_label";
            this.Ibs_label.Size = new System.Drawing.Size(43, 25);
            this.Ibs_label.TabIndex = 2;
            this.Ibs_label.Text = "Ibs";
            // 
            // kg_label
            // 
            this.kg_label.AutoSize = true;
            this.kg_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kg_label.Location = new System.Drawing.Point(502, 316);
            this.kg_label.Name = "kg_label";
            this.kg_label.Size = new System.Drawing.Size(40, 25);
            this.kg_label.TabIndex = 3;
            this.kg_label.Text = "Kg";
            // 
            // kg_textBox
            // 
            this.kg_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kg_textBox.ForeColor = System.Drawing.Color.Teal;
            this.kg_textBox.Location = new System.Drawing.Point(650, 299);
            this.kg_textBox.Multiline = true;
            this.kg_textBox.Name = "kg_textBox";
            this.kg_textBox.Size = new System.Drawing.Size(202, 54);
            this.kg_textBox.TabIndex = 4;
            this.kg_textBox.TextChanged += new System.EventHandler(this.kg_textBox_TextChanged);
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(887, 0);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(27, 25);
            this.exit.TabIndex = 5;
            this.exit.Text = "X";
            this.exit.Click += new System.EventHandler(this.label2_Click);
            // 
            // convertbtn
            // 
            this.convertbtn.BackColor = System.Drawing.Color.Teal;
            this.convertbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.convertbtn.Location = new System.Drawing.Point(472, 456);
            this.convertbtn.Name = "convertbtn";
            this.convertbtn.Size = new System.Drawing.Size(141, 55);
            this.convertbtn.TabIndex = 6;
            this.convertbtn.Text = "Convert";
            this.convertbtn.UseVisualStyleBackColor = false;
            this.convertbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Clearbtn
            // 
            this.Clearbtn.BackColor = System.Drawing.Color.Teal;
            this.Clearbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clearbtn.ForeColor = System.Drawing.Color.Snow;
            this.Clearbtn.Location = new System.Drawing.Point(730, 456);
            this.Clearbtn.Name = "Clearbtn";
            this.Clearbtn.Size = new System.Drawing.Size(148, 55);
            this.Clearbtn.TabIndex = 7;
            this.Clearbtn.Text = "Clear";
            this.Clearbtn.UseVisualStyleBackColor = false;
            this.Clearbtn.Click += new System.EventHandler(this.Clearbtn_Click);
            // 
            // WeightConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 565);
            this.Controls.Add(this.Clearbtn);
            this.Controls.Add(this.convertbtn);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.kg_textBox);
            this.Controls.Add(this.kg_label);
            this.Controls.Add(this.Ibs_label);
            this.Controls.Add(this.Ibs_Textbox);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WeightConverter";
            this.Text = "weight_form";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weightpicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox weightpicture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Ibs_Textbox;
        private System.Windows.Forms.Label Ibs_label;
        private System.Windows.Forms.Label kg_label;
        private System.Windows.Forms.TextBox kg_textBox;
        private System.Windows.Forms.Label exit;
        private System.Windows.Forms.Button convertbtn;
        private System.Windows.Forms.Button Clearbtn;
    }
}

