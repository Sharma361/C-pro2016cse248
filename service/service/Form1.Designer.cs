namespace service
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.city = new System.Windows.Forms.TextBox();
            this.Getweather = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.show = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.store = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter City";
            // 
            // city
            // 
            this.city.Location = new System.Drawing.Point(183, 138);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(206, 20);
            this.city.TabIndex = 1;
            // 
            // Getweather
            // 
            this.Getweather.Location = new System.Drawing.Point(78, 178);
            this.Getweather.Name = "Getweather";
            this.Getweather.Size = new System.Drawing.Size(275, 61);
            this.Getweather.TabIndex = 2;
            this.Getweather.Text = "Weather";
            this.Getweather.UseVisualStyleBackColor = true;
            this.Getweather.Click += new System.EventHandler(this.Getweather_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(458, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(187, 163);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // show
            // 
            this.show.Location = new System.Drawing.Point(445, 261);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(200, 23);
            this.show.TabIndex = 5;
            this.show.Text = "show Image";
            this.show.UseVisualStyleBackColor = true;
            this.show.Click += new System.EventHandler(this.button1_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(438, 225);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(107, 25);
            this.save.TabIndex = 6;
            this.save.Text = "save image";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // store
            // 
            this.store.Location = new System.Drawing.Point(557, 229);
            this.store.Name = "store";
            this.store.Size = new System.Drawing.Size(103, 20);
            this.store.TabIndex = 7;
            this.store.Text = "store image";
            this.store.UseVisualStyleBackColor = true;
            this.store.Click += new System.EventHandler(this.store_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.store);
            this.Controls.Add(this.save);
            this.Controls.Add(this.show);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Getweather);
            this.Controls.Add(this.city);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox city;
        private System.Windows.Forms.Button Getweather;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button show;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button store;
    }
}

