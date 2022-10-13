namespace ariketa2
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
            this.zen1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.hurrengokoa = new System.Windows.Forms.Button();
            this.garbitu = new System.Windows.Forms.Button();
            this.irten = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.zen3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.zen2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // zen1
            // 
            this.zen1.Location = new System.Drawing.Point(142, 43);
            this.zen1.Name = "zen1";
            this.zen1.Size = new System.Drawing.Size(563, 23);
            this.zen1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "1. Zenbakia";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // hurrengokoa
            // 
            this.hurrengokoa.Location = new System.Drawing.Point(69, 362);
            this.hurrengokoa.Name = "hurrengokoa";
            this.hurrengokoa.Size = new System.Drawing.Size(100, 50);
            this.hurrengokoa.TabIndex = 2;
            this.hurrengokoa.Text = "Hurrengokoa";
            this.hurrengokoa.UseVisualStyleBackColor = true;
            this.hurrengokoa.Click += new System.EventHandler(this.hurrengokoa_Click);
            // 
            // garbitu
            // 
            this.garbitu.Location = new System.Drawing.Point(339, 362);
            this.garbitu.Name = "garbitu";
            this.garbitu.Size = new System.Drawing.Size(100, 50);
            this.garbitu.TabIndex = 3;
            this.garbitu.Text = "Garbitu";
            this.garbitu.UseVisualStyleBackColor = true;
            this.garbitu.Click += new System.EventHandler(this.garbitu_Click);
            // 
            // irten
            // 
            this.irten.Location = new System.Drawing.Point(611, 362);
            this.irten.Name = "irten";
            this.irten.Size = new System.Drawing.Size(100, 50);
            this.irten.TabIndex = 4;
            this.irten.Text = "Irten";
            this.irten.UseVisualStyleBackColor = true;
            this.irten.Click += new System.EventHandler(this.irten_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "3. Zenbakia";
            // 
            // zen3
            // 
            this.zen3.Location = new System.Drawing.Point(142, 164);
            this.zen3.Name = "zen3";
            this.zen3.Size = new System.Drawing.Size(563, 23);
            this.zen3.TabIndex = 5;
            this.zen3.TextChanged += new System.EventHandler(this.zen3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "2. Zenbakia";
            // 
            // zen2
            // 
            this.zen2.Location = new System.Drawing.Point(142, 100);
            this.zen2.Name = "zen2";
            this.zen2.Size = new System.Drawing.Size(563, 23);
            this.zen2.TabIndex = 7;
            this.zen2.TextChanged += new System.EventHandler(this.zen2_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.zen2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.zen3);
            this.Controls.Add(this.irten);
            this.Controls.Add(this.garbitu);
            this.Controls.Add(this.hurrengokoa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.zen1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox zen1;
        private Label label1;
        private Button hurrengokoa;
        private Button garbitu;
        private Button irten;
        private Label label2;
        private TextBox zen3;
        private Label label3;
        private TextBox zen2;
    }
}