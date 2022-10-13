namespace ariketa3
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
            this.mota = new System.Windows.Forms.GroupBox();
            this.kontaktua = new System.Windows.Forms.RadioButton();
            this.bezeroa = new System.Windows.Forms.RadioButton();
            this.langilea = new System.Windows.Forms.RadioButton();
            this.izena = new System.Windows.Forms.TextBox();
            this.nan = new System.Windows.Forms.TextBox();
            this.abizena = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.segurtasunSoziala = new System.Windows.Forms.TextBox();
            this.soldata = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.kategoria = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.soldata4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gorde = new System.Windows.Forms.Button();
            this.irten = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.mota.SuspendLayout();
            this.SuspendLayout();
            // 
            // mota
            // 
            this.mota.Controls.Add(this.kontaktua);
            this.mota.Controls.Add(this.bezeroa);
            this.mota.Controls.Add(this.langilea);
            this.mota.Location = new System.Drawing.Point(521, 64);
            this.mota.Name = "mota";
            this.mota.Size = new System.Drawing.Size(248, 155);
            this.mota.TabIndex = 4;
            this.mota.TabStop = false;
            this.mota.Text = "Mota";
            // 
            // kontaktua
            // 
            this.kontaktua.AutoSize = true;
            this.kontaktua.Location = new System.Drawing.Point(17, 29);
            this.kontaktua.Name = "kontaktua";
            this.kontaktua.Size = new System.Drawing.Size(79, 19);
            this.kontaktua.TabIndex = 5;
            this.kontaktua.TabStop = true;
            this.kontaktua.Text = "Kontaktua";
            this.kontaktua.UseVisualStyleBackColor = true;
            // 
            // bezeroa
            // 
            this.bezeroa.AutoSize = true;
            this.bezeroa.Location = new System.Drawing.Point(17, 58);
            this.bezeroa.Name = "bezeroa";
            this.bezeroa.Size = new System.Drawing.Size(66, 19);
            this.bezeroa.TabIndex = 6;
            this.bezeroa.TabStop = true;
            this.bezeroa.Text = "Bezeroa";
            this.bezeroa.UseVisualStyleBackColor = true;
            // 
            // langilea
            // 
            this.langilea.AutoSize = true;
            this.langilea.Location = new System.Drawing.Point(17, 83);
            this.langilea.Name = "langilea";
            this.langilea.Size = new System.Drawing.Size(69, 19);
            this.langilea.TabIndex = 7;
            this.langilea.TabStop = true;
            this.langilea.Text = "Langilea";
            this.langilea.UseVisualStyleBackColor = true;
            // 
            // izena
            // 
            this.izena.Location = new System.Drawing.Point(100, 89);
            this.izena.Name = "izena";
            this.izena.Size = new System.Drawing.Size(100, 23);
            this.izena.TabIndex = 0;
            // 
            // nan
            // 
            this.nan.Location = new System.Drawing.Point(100, 47);
            this.nan.Name = "nan";
            this.nan.Size = new System.Drawing.Size(100, 23);
            this.nan.TabIndex = 1;
            // 
            // abizena
            // 
            this.abizena.Location = new System.Drawing.Point(100, 126);
            this.abizena.Name = "abizena";
            this.abizena.Size = new System.Drawing.Size(100, 23);
            this.abizena.TabIndex = 2;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(100, 172);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(100, 23);
            this.email.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(521, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Langilea";
            // 
            // segurtasunSoziala
            // 
            this.segurtasunSoziala.Location = new System.Drawing.Point(525, 356);
            this.segurtasunSoziala.Name = "segurtasunSoziala";
            this.segurtasunSoziala.Size = new System.Drawing.Size(210, 23);
            this.segurtasunSoziala.TabIndex = 10;
            // 
            // soldata
            // 
            this.soldata.Location = new System.Drawing.Point(573, 309);
            this.soldata.Name = "soldata";
            this.soldata.Size = new System.Drawing.Size(162, 23);
            this.soldata.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Bezeroa";
            // 
            // kategoria
            // 
            this.kategoria.FormattingEnabled = true;
            this.kategoria.Location = new System.Drawing.Point(50, 338);
            this.kategoria.Name = "kategoria";
            this.kategoria.Size = new System.Drawing.Size(121, 23);
            this.kategoria.TabIndex = 12;
            this.kategoria.SelectedIndexChanged += new System.EventHandler(this.kategoria_SelectedIndexChanged_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 320);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Kategoria";
            // 
            // soldata4
            // 
            this.soldata4.AutoSize = true;
            this.soldata4.Location = new System.Drawing.Point(521, 312);
            this.soldata4.Name = "soldata4";
            this.soldata4.Size = new System.Drawing.Size(46, 15);
            this.soldata4.TabIndex = 14;
            this.soldata4.Text = "Soldata";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(521, 338);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "Segurtasun soziala:";
            // 
            // gorde
            // 
            this.gorde.Location = new System.Drawing.Point(206, 403);
            this.gorde.Name = "gorde";
            this.gorde.Size = new System.Drawing.Size(75, 23);
            this.gorde.TabIndex = 16;
            this.gorde.Text = "Gorde";
            this.gorde.UseVisualStyleBackColor = true;
            this.gorde.Click += new System.EventHandler(this.gorde_Click);
            // 
            // irten
            // 
            this.irten.Location = new System.Drawing.Point(461, 403);
            this.irten.Name = "irten";
            this.irten.Size = new System.Drawing.Size(75, 23);
            this.irten.TabIndex = 17;
            this.irten.Text = "Irten";
            this.irten.UseVisualStyleBackColor = true;
            this.irten.Click += new System.EventHandler(this.irten_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 15);
            this.label4.TabIndex = 18;
            this.label4.Text = "Nan";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 15);
            this.label6.TabIndex = 19;
            this.label6.Text = "Izena";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(50, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 15);
            this.label7.TabIndex = 20;
            this.label7.Text = "Abizena";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(50, 180);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 15);
            this.label8.TabIndex = 21;
            this.label8.Text = "Email";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.irten);
            this.Controls.Add(this.gorde);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.soldata4);
            this.Controls.Add(this.segurtasunSoziala);
            this.Controls.Add(this.soldata);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.kategoria);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.email);
            this.Controls.Add(this.abizena);
            this.Controls.Add(this.izena);
            this.Controls.Add(this.nan);
            this.Controls.Add(this.mota);
            this.Name = "Form1";
            this.Text = "Form1";
            this.mota.ResumeLayout(false);
            this.mota.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private GroupBox mota;
        private RadioButton kontaktua;
        private RadioButton bezeroa;
        private RadioButton langilea;
        private TextBox soldata;
        private TextBox segurtasunSoziala;
        private TextBox izena;
        private TextBox nan;
        private TextBox abizena;
        private TextBox email;
        private Label label2;
        private Label label1;
        private ComboBox kategoria;
        private Label label3;
        private Label soldata4;
        private Label label5;
        private Button gorde;
        private Button irten;
        private Label label4;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}