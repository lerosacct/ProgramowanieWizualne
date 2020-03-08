namespace BMR
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.w = new System.Windows.Forms.TextBox();
            this.h = new System.Windows.Forms.TextBox();
            this.a = new System.Windows.Forms.TextBox();
            this.m = new System.Windows.Forms.RadioButton();
            this.f = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.g = new System.Windows.Forms.GroupBox();
            this.result = new System.Windows.Forms.TextBox();
            this.g.SuspendLayout();
            this.SuspendLayout();
            // 
            // w
            // 
            this.w.Location = new System.Drawing.Point(12, 22);
            this.w.Name = "w";
            this.w.Size = new System.Drawing.Size(100, 20);
            this.w.TabIndex = 0;
            // 
            // h
            // 
            this.h.Location = new System.Drawing.Point(12, 66);
            this.h.Name = "h";
            this.h.Size = new System.Drawing.Size(100, 20);
            this.h.TabIndex = 1;
            // 
            // a
            // 
            this.a.Location = new System.Drawing.Point(12, 111);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(100, 20);
            this.a.TabIndex = 2;
            // 
            // m
            // 
            this.m.AutoSize = true;
            this.m.Checked = true;
            this.m.Location = new System.Drawing.Point(6, 19);
            this.m.Name = "m";
            this.m.Size = new System.Drawing.Size(34, 17);
            this.m.TabIndex = 3;
            this.m.TabStop = true;
            this.m.Text = "M";
            this.m.UseVisualStyleBackColor = true;
            // 
            // f
            // 
            this.f.AutoSize = true;
            this.f.Location = new System.Drawing.Point(53, 19);
            this.f.Name = "f";
            this.f.Size = new System.Drawing.Size(32, 17);
            this.f.TabIndex = 4;
            this.f.TabStop = true;
            this.f.Text = "K";
            this.f.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Masa";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "kg";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Wzrost";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(118, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "cm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Wiek";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(118, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "lat";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 187);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Licz BMR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // g
            // 
            this.g.Controls.Add(this.m);
            this.g.Controls.Add(this.f);
            this.g.Location = new System.Drawing.Point(12, 137);
            this.g.Name = "g";
            this.g.Size = new System.Drawing.Size(87, 44);
            this.g.TabIndex = 13;
            this.g.TabStop = false;
            this.g.Text = "Płeć";
            this.g.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(12, 216);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(124, 20);
            this.result.TabIndex = 14;
            this.result.TextChanged += new System.EventHandler(this.result_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(142, 245);
            this.Controls.Add(this.result);
            this.Controls.Add(this.g);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.a);
            this.Controls.Add(this.h);
            this.Controls.Add(this.w);
            this.Name = "Form1";
            this.Text = "Form1";
            this.g.ResumeLayout(false);
            this.g.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox w;
        private System.Windows.Forms.TextBox h;
        private System.Windows.Forms.TextBox a;
        private System.Windows.Forms.RadioButton m;
        private System.Windows.Forms.RadioButton f;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox g;
        private System.Windows.Forms.TextBox result;
    }
}

