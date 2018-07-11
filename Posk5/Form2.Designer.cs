namespace Posk5
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.instrukcjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autodiagnostykaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dwieminuty = new System.Windows.Forms.ToolStripMenuItem();
            this.piecminut = new System.Windows.Forms.ToolStripMenuItem();
            this.dziesiecminut = new System.Windows.Forms.ToolStripMenuItem();
            this.pietnascieminut = new System.Windows.Forms.ToolStripMenuItem();
            this.dwadziesciaminut = new System.Windows.Forms.ToolStripMenuItem();
            this.trzydziesciminut = new System.Windows.Forms.ToolStripMenuItem();
            this.ustawCzas = new System.Windows.Forms.ToolStripMenuItem();
            this.wylogujToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zakończToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.instrukcjaToolStripMenuItem,
            this.autodiagnostykaToolStripMenuItem,
            this.wylogujToolStripMenuItem,
            this.zakończToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(554, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // instrukcjaToolStripMenuItem
            // 
            this.instrukcjaToolStripMenuItem.Name = "instrukcjaToolStripMenuItem";
            this.instrukcjaToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.instrukcjaToolStripMenuItem.Text = "Instrukcja";
            this.instrukcjaToolStripMenuItem.Click += new System.EventHandler(this.instrukcjaToolStripMenuItem_Click);
            // 
            // autodiagnostykaToolStripMenuItem
            // 
            this.autodiagnostykaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dwieminuty,
            this.piecminut,
            this.dziesiecminut,
            this.pietnascieminut,
            this.dwadziesciaminut,
            this.trzydziesciminut,
            this.ustawCzas});
            this.autodiagnostykaToolStripMenuItem.Name = "autodiagnostykaToolStripMenuItem";
            this.autodiagnostykaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.autodiagnostykaToolStripMenuItem.Text = "Alarm";
            // 
            // dwieminuty
            // 
            this.dwieminuty.Name = "dwieminuty";
            this.dwieminuty.Size = new System.Drawing.Size(152, 22);
            this.dwieminuty.Text = "2 minuty";
            this.dwieminuty.Click += new System.EventHandler(this.dwieminuty_Click);
            // 
            // piecminut
            // 
            this.piecminut.Name = "piecminut";
            this.piecminut.Size = new System.Drawing.Size(152, 22);
            this.piecminut.Text = "5 minut";
            this.piecminut.Click += new System.EventHandler(this.piecminut_Click);
            // 
            // dziesiecminut
            // 
            this.dziesiecminut.Name = "dziesiecminut";
            this.dziesiecminut.Size = new System.Drawing.Size(152, 22);
            this.dziesiecminut.Text = "10 minut";
            this.dziesiecminut.Click += new System.EventHandler(this.dziesiecminut_Click);
            // 
            // pietnascieminut
            // 
            this.pietnascieminut.Name = "pietnascieminut";
            this.pietnascieminut.Size = new System.Drawing.Size(152, 22);
            this.pietnascieminut.Text = "15 minut";
            this.pietnascieminut.Click += new System.EventHandler(this.pietnascieminut_Click);
            // 
            // dwadziesciaminut
            // 
            this.dwadziesciaminut.Name = "dwadziesciaminut";
            this.dwadziesciaminut.Size = new System.Drawing.Size(152, 22);
            this.dwadziesciaminut.Text = "20 minut";
            this.dwadziesciaminut.Click += new System.EventHandler(this.dwadziesciaminut_Click);
            // 
            // trzydziesciminut
            // 
            this.trzydziesciminut.Name = "trzydziesciminut";
            this.trzydziesciminut.Size = new System.Drawing.Size(152, 22);
            this.trzydziesciminut.Text = "30 minut";
            this.trzydziesciminut.Click += new System.EventHandler(this.trzydziesciminut_Click);
            // 
            // ustawCzas
            // 
            this.ustawCzas.Name = "ustawCzas";
            this.ustawCzas.Size = new System.Drawing.Size(152, 22);
            this.ustawCzas.Text = "Ustaw alarm...";
            this.ustawCzas.Click += new System.EventHandler(this.ustawCzas_Click);
            // 
            // wylogujToolStripMenuItem
            // 
            this.wylogujToolStripMenuItem.Name = "wylogujToolStripMenuItem";
            this.wylogujToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.wylogujToolStripMenuItem.Text = "Wyloguj";
            this.wylogujToolStripMenuItem.Click += new System.EventHandler(this.wylogujToolStripMenuItem_Click);
            // 
            // zakończToolStripMenuItem
            // 
            this.zakończToolStripMenuItem.Name = "zakończToolStripMenuItem";
            this.zakończToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.zakończToolStripMenuItem.Text = "Zakończ";
            this.zakończToolStripMenuItem.Click += new System.EventHandler(this.zakończToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe MDL2 Assets", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(213, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Panel Sterowania";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("NSimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Temperatura [°C]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("NSimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ciśnienie [atm]";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("NSimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Moc [MW]";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(386, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Czekaj...";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(386, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 17);
            this.label8.TabIndex = 4;
            this.label8.Text = "Czekaj...";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(386, 190);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 17);
            this.label9.TabIndex = 4;
            this.label9.Text = "Czekaj...";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button1.Font = new System.Drawing.Font("NSimSun", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(441, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 18);
            this.button1.TabIndex = 5;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button2.Font = new System.Drawing.Font("NSimSun", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(441, 140);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(44, 18);
            this.button2.TabIndex = 5;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button3.Font = new System.Drawing.Font("NSimSun", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(441, 190);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(44, 18);
            this.button3.TabIndex = 5;
            this.button3.Text = "+";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button4.Font = new System.Drawing.Font("NSimSun", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(498, 90);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(44, 18);
            this.button4.TabIndex = 5;
            this.button4.Text = "-";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button5.Font = new System.Drawing.Font("NSimSun", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(498, 140);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(44, 18);
            this.button5.TabIndex = 5;
            this.button5.Text = "-";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button6.Font = new System.Drawing.Font("NSimSun", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(498, 190);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(44, 18);
            this.button6.TabIndex = 5;
            this.button6.Text = "-";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.progressBar1.Location = new System.Drawing.Point(185, 90);
            this.progressBar1.MarqueeAnimationSpeed = 50;
            this.progressBar1.Maximum = 300;
            this.progressBar1.Minimum = 200;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(171, 15);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 6;
            this.progressBar1.Value = 200;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(185, 141);
            this.progressBar2.MarqueeAnimationSpeed = 50;
            this.progressBar2.Maximum = 80;
            this.progressBar2.Minimum = 70;
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(171, 15);
            this.progressBar2.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar2.TabIndex = 6;
            this.progressBar2.Value = 70;
            // 
            // progressBar3
            // 
            this.progressBar3.Location = new System.Drawing.Point(185, 191);
            this.progressBar3.MarqueeAnimationSpeed = 50;
            this.progressBar3.Maximum = 9;
            this.progressBar3.Minimum = 2;
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(171, 15);
            this.progressBar3.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar3.TabIndex = 6;
            this.progressBar3.Value = 2;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Posk5.Properties.Resources.gradient;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(554, 309);
            this.Controls.Add(this.progressBar3);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Elektrownia - Panel Główny";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem instrukcjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autodiagnostykaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dwieminuty;
        private System.Windows.Forms.ToolStripMenuItem piecminut;
        private System.Windows.Forms.ToolStripMenuItem dziesiecminut;
        private System.Windows.Forms.ToolStripMenuItem pietnascieminut;
        private System.Windows.Forms.ToolStripMenuItem dwadziesciaminut;
        private System.Windows.Forms.ToolStripMenuItem trzydziesciminut;
        private System.Windows.Forms.ToolStripMenuItem ustawCzas;
        private System.Windows.Forms.ToolStripMenuItem wylogujToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zakończToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.ProgressBar progressBar3;
    }
}