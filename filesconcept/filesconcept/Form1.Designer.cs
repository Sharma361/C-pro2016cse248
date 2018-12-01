namespace filesconcept
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
            this.Create = new System.Windows.Forms.Button();
            this.Write = new System.Windows.Forms.Button();
            this.Read = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Info = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(56, 161);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(108, 34);
            this.Create.TabIndex = 0;
            this.Create.Text = "create";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // Write
            // 
            this.Write.Location = new System.Drawing.Point(185, 161);
            this.Write.Name = "Write";
            this.Write.Size = new System.Drawing.Size(105, 34);
            this.Write.TabIndex = 1;
            this.Write.Text = "write";
            this.Write.UseVisualStyleBackColor = true;
            // 
            // Read
            // 
            this.Read.Location = new System.Drawing.Point(311, 161);
            this.Read.Name = "Read";
            this.Read.Size = new System.Drawing.Size(101, 34);
            this.Read.TabIndex = 2;
            this.Read.Text = "read";
            this.Read.UseVisualStyleBackColor = true;
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(432, 161);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(98, 34);
            this.Delete.TabIndex = 3;
            this.Delete.Text = "delete";
            this.Delete.UseVisualStyleBackColor = true;
            // 
            // Info
            // 
            this.Info.Location = new System.Drawing.Point(158, 221);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(277, 120);
            this.Info.TabIndex = 4;
            this.Info.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Info);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Read);
            this.Controls.Add(this.Write);
            this.Controls.Add(this.Create);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.Button Write;
        private System.Windows.Forms.Button Read;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.RichTextBox Info;
    }
}

