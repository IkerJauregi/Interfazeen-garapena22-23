namespace Esaldi1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.esaldi3 = new System.Windows.Forms.Button();
            this.esaldi2 = new System.Windows.Forms.Button();
            this.esaldi1 = new System.Windows.Forms.Button();
            this.esaldi4 = new System.Windows.Forms.Button();
            this.esaldi5 = new System.Windows.Forms.Button();
            this.lotu = new System.Windows.Forms.Button();
            this.garbitu = new System.Windows.Forms.Button();
            this.irten = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // esaldi3
            // 
            this.esaldi3.Enabled = false;
            this.esaldi3.Location = new System.Drawing.Point(574, 216);
            this.esaldi3.Name = "esaldi3";
            this.esaldi3.Size = new System.Drawing.Size(90, 30);
            this.esaldi3.TabIndex = 0;
            this.esaldi3.Text = "Esaldi 3";
            this.esaldi3.UseVisualStyleBackColor = true;
            this.esaldi3.Click += new System.EventHandler(this.esaldi3_Click);
            // 
            // esaldi2
            // 
            this.esaldi2.Enabled = false;
            this.esaldi2.Location = new System.Drawing.Point(352, 216);
            this.esaldi2.Name = "esaldi2";
            this.esaldi2.Size = new System.Drawing.Size(90, 30);
            this.esaldi2.TabIndex = 1;
            this.esaldi2.Text = "Esaldi 2";
            this.esaldi2.UseVisualStyleBackColor = true;
            this.esaldi2.Click += new System.EventHandler(this.esaldi2_Click);
            // 
            // esaldi1
            // 
            this.esaldi1.Location = new System.Drawing.Point(137, 216);
            this.esaldi1.Name = "esaldi1";
            this.esaldi1.Size = new System.Drawing.Size(90, 30);
            this.esaldi1.TabIndex = 2;
            this.esaldi1.Text = "Esaldi 1";
            this.esaldi1.UseVisualStyleBackColor = true;
            this.esaldi1.Click += new System.EventHandler(this.esaldi1_Click);
            // 
            // esaldi4
            // 
            this.esaldi4.Enabled = false;
            this.esaldi4.Location = new System.Drawing.Point(137, 278);
            this.esaldi4.Name = "esaldi4";
            this.esaldi4.Size = new System.Drawing.Size(90, 30);
            this.esaldi4.TabIndex = 3;
            this.esaldi4.Text = "Esaldi 4";
            this.esaldi4.UseVisualStyleBackColor = true;
            this.esaldi4.Click += new System.EventHandler(this.esaldi4_Click);
            // 
            // esaldi5
            // 
            this.esaldi5.Enabled = false;
            this.esaldi5.Location = new System.Drawing.Point(352, 278);
            this.esaldi5.Name = "esaldi5";
            this.esaldi5.Size = new System.Drawing.Size(90, 30);
            this.esaldi5.TabIndex = 4;
            this.esaldi5.Text = "Esaldi 5";
            this.esaldi5.UseVisualStyleBackColor = true;
            this.esaldi5.Click += new System.EventHandler(this.esaldi5_Click);
            // 
            // lotu
            // 
            this.lotu.Enabled = false;
            this.lotu.Location = new System.Drawing.Point(574, 278);
            this.lotu.Name = "lotu";
            this.lotu.Size = new System.Drawing.Size(90, 30);
            this.lotu.TabIndex = 5;
            this.lotu.Text = "Lotu";
            this.lotu.UseVisualStyleBackColor = true;
            this.lotu.Click += new System.EventHandler(this.lotu_Click);
            // 
            // garbitu
            // 
            this.garbitu.Location = new System.Drawing.Point(137, 361);
            this.garbitu.Name = "garbitu";
            this.garbitu.Size = new System.Drawing.Size(90, 30);
            this.garbitu.TabIndex = 6;
            this.garbitu.Text = "Garbitu";
            this.garbitu.UseVisualStyleBackColor = true;
            this.garbitu.Click += new System.EventHandler(this.garbitu_Click);
            // 
            // irten
            // 
            this.irten.Location = new System.Drawing.Point(574, 361);
            this.irten.Name = "irten";
            this.irten.Size = new System.Drawing.Size(90, 30);
            this.irten.TabIndex = 7;
            this.irten.Text = "Irten";
            this.irten.UseVisualStyleBackColor = true;
            this.irten.Click += new System.EventHandler(this.irten_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(137, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(512, 175);
            this.textBox1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.irten);
            this.Controls.Add(this.garbitu);
            this.Controls.Add(this.lotu);
            this.Controls.Add(this.esaldi5);
            this.Controls.Add(this.esaldi4);
            this.Controls.Add(this.esaldi1);
            this.Controls.Add(this.esaldi2);
            this.Controls.Add(this.esaldi3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button esaldi3;
        private Button esaldi2;
        private Button esaldi1;
        private Button esaldi4;
        private Button esaldi5;
        private Button lotu;
        private Button garbitu;
        private Button irten;
        private TextBox textBox1;
    }
}