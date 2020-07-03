namespace Tugas_Kalkulator
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
            this.clearBack = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btnKurang = new System.Windows.Forms.Button();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnHasil = new System.Windows.Forms.Button();
            this.btnTititk = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnMod = new System.Windows.Forms.Button();
            this.btnKali = new System.Windows.Forms.Button();
            this.btnBagi = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtHasil = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // clearBack
            // 
            this.clearBack.Location = new System.Drawing.Point(85, 65);
            this.clearBack.Name = "clearBack";
            this.clearBack.Size = new System.Drawing.Size(42, 23);
            this.clearBack.TabIndex = 0;
            this.clearBack.Text = "<-";
            this.clearBack.UseVisualStyleBackColor = true;
            this.clearBack.Click += new System.EventHandler(this.backspace);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(150, 145);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(42, 23);
            this.btn6.TabIndex = 1;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btnKurang
            // 
            this.btnKurang.Location = new System.Drawing.Point(216, 145);
            this.btnKurang.Name = "btnKurang";
            this.btnKurang.Size = new System.Drawing.Size(42, 23);
            this.btnKurang.TabIndex = 2;
            this.btnKurang.Text = "-";
            this.btnKurang.UseVisualStyleBackColor = true;
            this.btnKurang.Click += new System.EventHandler(this.operator_click);
            // 
            // btnTambah
            // 
            this.btnTambah.Location = new System.Drawing.Point(216, 182);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(42, 23);
            this.btnTambah.TabIndex = 3;
            this.btnTambah.Text = "+";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.operator_click);
            // 
            // btnHasil
            // 
            this.btnHasil.Location = new System.Drawing.Point(216, 220);
            this.btnHasil.Name = "btnHasil";
            this.btnHasil.Size = new System.Drawing.Size(42, 23);
            this.btnHasil.TabIndex = 4;
            this.btnHasil.Text = "=";
            this.btnHasil.UseVisualStyleBackColor = true;
            this.btnHasil.Click += new System.EventHandler(this.hasil);
            // 
            // btnTititk
            // 
            this.btnTititk.Location = new System.Drawing.Point(150, 220);
            this.btnTititk.Name = "btnTititk";
            this.btnTititk.Size = new System.Drawing.Size(42, 23);
            this.btnTititk.TabIndex = 5;
            this.btnTititk.Text = ".";
            this.btnTititk.UseVisualStyleBackColor = true;
            this.btnTititk.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(85, 145);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(42, 23);
            this.btn5.TabIndex = 6;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(85, 106);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(42, 23);
            this.btn8.TabIndex = 7;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btnC
            // 
            this.btnC.Location = new System.Drawing.Point(25, 65);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(42, 23);
            this.btnC.TabIndex = 8;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.ClearAll);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(25, 106);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(42, 23);
            this.btn7.TabIndex = 9;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(25, 145);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(42, 23);
            this.btn4.TabIndex = 10;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(150, 182);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(42, 23);
            this.btn3.TabIndex = 11;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(85, 185);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(42, 23);
            this.btn2.TabIndex = 12;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(25, 185);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(42, 23);
            this.btn1.TabIndex = 13;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(25, 220);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(102, 23);
            this.btn0.TabIndex = 14;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(150, 106);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(42, 23);
            this.btn9.TabIndex = 15;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btnMod
            // 
            this.btnMod.Location = new System.Drawing.Point(150, 65);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(42, 23);
            this.btnMod.TabIndex = 16;
            this.btnMod.Text = "%";
            this.btnMod.UseVisualStyleBackColor = true;
            this.btnMod.Click += new System.EventHandler(this.persen);
            // 
            // btnKali
            // 
            this.btnKali.Location = new System.Drawing.Point(216, 106);
            this.btnKali.Name = "btnKali";
            this.btnKali.Size = new System.Drawing.Size(42, 23);
            this.btnKali.TabIndex = 17;
            this.btnKali.Text = "*";
            this.btnKali.UseVisualStyleBackColor = true;
            this.btnKali.Click += new System.EventHandler(this.operator_click);
            // 
            // btnBagi
            // 
            this.btnBagi.Location = new System.Drawing.Point(216, 65);
            this.btnBagi.Name = "btnBagi";
            this.btnBagi.Size = new System.Drawing.Size(42, 23);
            this.btnBagi.TabIndex = 18;
            this.btnBagi.Text = ":";
            this.btnBagi.UseVisualStyleBackColor = true;
            this.btnBagi.Click += new System.EventHandler(this.operator_click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.Exit);
            // 
            // txtHasil
            // 
            this.txtHasil.Location = new System.Drawing.Point(25, 28);
            this.txtHasil.Name = "txtHasil";
            this.txtHasil.Size = new System.Drawing.Size(233, 20);
            this.txtHasil.TabIndex = 20;
            this.txtHasil.Text = "0";
            this.txtHasil.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txtHasil);
            this.Controls.Add(this.btnBagi);
            this.Controls.Add(this.btnKali);
            this.Controls.Add(this.btnMod);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btnTititk);
            this.Controls.Add(this.btnHasil);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.btnKurang);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.clearBack);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Kalkulator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button clearBack;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btnKurang;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnHasil;
        private System.Windows.Forms.Button btnTititk;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnMod;
        private System.Windows.Forms.Button btnKali;
        private System.Windows.Forms.Button btnBagi;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TextBox txtHasil;
    }
}

