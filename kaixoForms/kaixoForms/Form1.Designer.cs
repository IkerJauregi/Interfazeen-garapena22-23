namespace kaixoForms
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
            this.btnErakutsi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnErakutsi
            // 
            this.btnErakutsi.Location = new System.Drawing.Point(210, 162);
            this.btnErakutsi.Name = "btnErakutsi";
            this.btnErakutsi.Size = new System.Drawing.Size(330, 136);
            this.btnErakutsi.TabIndex = 0;
            this.btnErakutsi.Text = "Mezua erakutsi";
            this.btnErakutsi.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnErakutsi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnErakutsi;
    }
}

