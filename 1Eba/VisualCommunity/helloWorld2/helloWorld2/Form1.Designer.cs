namespace helloWorld2
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
            this.btnKaixo = new System.Windows.Forms.Button();
            this.btnItxi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKaixo
            // 
            this.btnKaixo.Location = new System.Drawing.Point(26, 101);
            this.btnKaixo.Name = "btnKaixo";
            this.btnKaixo.Size = new System.Drawing.Size(75, 23);
            this.btnKaixo.TabIndex = 0;
            this.btnKaixo.Text = "Kaixo";
            this.btnKaixo.UseVisualStyleBackColor = true;
            this.btnKaixo.Click += new System.EventHandler(this.btnKaixo_Click);
            // 
            // btnItxi
            // 
            this.btnItxi.Location = new System.Drawing.Point(216, 101);
            this.btnItxi.Name = "btnItxi";
            this.btnItxi.Size = new System.Drawing.Size(75, 23);
            this.btnItxi.TabIndex = 1;
            this.btnItxi.Text = "Itxi";
            this.btnItxi.UseVisualStyleBackColor = true;
            this.btnItxi.Click += new System.EventHandler(this.btnItxi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnItxi);
            this.Controls.Add(this.btnKaixo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnKaixo;
        private Button btnItxi;
    }
}