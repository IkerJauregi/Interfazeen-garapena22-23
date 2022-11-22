namespace Kalkulagailua
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
            this.kenketa = new System.Windows.Forms.Button();
            this.gehiketa = new System.Windows.Forms.Button();
            this.zatiketa = new System.Windows.Forms.Button();
            this.biderketa = new System.Windows.Forms.Button();
            this.zen2 = new System.Windows.Forms.TextBox();
            this.zen1 = new System.Windows.Forms.TextBox();
            this.irten = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // kenketa
            // 
            this.kenketa.Location = new System.Drawing.Point(209, 229);
            this.kenketa.Name = "kenketa";
            this.kenketa.Size = new System.Drawing.Size(75, 23);
            this.kenketa.TabIndex = 0;
            this.kenketa.Text = "-";
            this.kenketa.UseVisualStyleBackColor = true;
            this.kenketa.Click += new System.EventHandler(this.kenketa_Click);
            // 
            // gehiketa
            // 
            this.gehiketa.Location = new System.Drawing.Point(209, 152);
            this.gehiketa.Name = "gehiketa";
            this.gehiketa.Size = new System.Drawing.Size(75, 23);
            this.gehiketa.TabIndex = 1;
            this.gehiketa.Text = "+";
            this.gehiketa.UseVisualStyleBackColor = true;
            this.gehiketa.Click += new System.EventHandler(this.gehiketa_Click);
            // 
            // zatiketa
            // 
            this.zatiketa.Location = new System.Drawing.Point(431, 229);
            this.zatiketa.Name = "zatiketa";
            this.zatiketa.Size = new System.Drawing.Size(75, 23);
            this.zatiketa.TabIndex = 2;
            this.zatiketa.Text = "/";
            this.zatiketa.UseVisualStyleBackColor = true;
            this.zatiketa.Click += new System.EventHandler(this.zatiketa_Click);
            // 
            // biderketa
            // 
            this.biderketa.Location = new System.Drawing.Point(431, 152);
            this.biderketa.Name = "biderketa";
            this.biderketa.Size = new System.Drawing.Size(75, 23);
            this.biderketa.TabIndex = 3;
            this.biderketa.Text = "*";
            this.biderketa.UseVisualStyleBackColor = true;
            this.biderketa.Click += new System.EventHandler(this.biderketa_Click);
            // 
            // zen2
            // 
            this.zen2.Location = new System.Drawing.Point(406, 55);
            this.zen2.Name = "zen2";
            this.zen2.Size = new System.Drawing.Size(100, 23);
            this.zen2.TabIndex = 4;
            this.zen2.TextChanged += new System.EventHandler(this.zen2_TextChanged);
            // 
            // zen1
            // 
            this.zen1.Location = new System.Drawing.Point(147, 55);
            this.zen1.Name = "zen1";
            this.zen1.Size = new System.Drawing.Size(100, 23);
            this.zen1.TabIndex = 5;
            this.zen1.TextChanged += new System.EventHandler(this.zen1_TextChanged);
            // 
            // irten
            // 
            this.irten.Location = new System.Drawing.Point(696, 387);
            this.irten.Name = "irten";
            this.irten.Size = new System.Drawing.Size(75, 23);
            this.irten.TabIndex = 6;
            this.irten.Text = "Irten";
            this.irten.UseVisualStyleBackColor = true;
            this.irten.Click += new System.EventHandler(this.irten_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.irten);
            this.Controls.Add(this.zen1);
            this.Controls.Add(this.zen2);
            this.Controls.Add(this.biderketa);
            this.Controls.Add(this.zatiketa);
            this.Controls.Add(this.gehiketa);
            this.Controls.Add(this.kenketa);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button kenketa;
        private Button gehiketa;
        private Button zatiketa;
        private Button biderketa;
        private TextBox zen2;
        private TextBox zen1;
        private Button irten;
    }
}