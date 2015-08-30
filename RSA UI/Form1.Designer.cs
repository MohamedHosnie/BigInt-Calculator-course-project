namespace RSA_UI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.open_file_button = new System.Windows.Forms.Button();
            this.clear_button = new System.Windows.Forms.Button();
            this.file_dir_text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.start_button = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.save_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.saved_button = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BONUSE = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.Time = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.operation_time = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.full_text = new System.Windows.Forms.Label();
            this.input = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mod_button = new System.Windows.Forms.Button();
            this.power_button = new System.Windows.Forms.Button();
            this.clear_but = new System.Windows.Forms.Button();
            this.minus_button = new System.Windows.Forms.Button();
            this.div_button = new System.Windows.Forms.Button();
            this.equal_button = new System.Windows.Forms.Button();
            this.add_button = new System.Windows.Forms.Button();
            this.mul_button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.Prime = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.Bouns_text = new System.Windows.Forms.TextBox();
            this.SyncTask = new System.ComponentModel.BackgroundWorker();
            this.label8 = new System.Windows.Forms.Label();
            this.BONUSE.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // open_file_button
            // 
            this.open_file_button.Location = new System.Drawing.Point(289, 14);
            this.open_file_button.Name = "open_file_button";
            this.open_file_button.Size = new System.Drawing.Size(75, 23);
            this.open_file_button.TabIndex = 0;
            this.open_file_button.Text = "Open";
            this.open_file_button.UseVisualStyleBackColor = true;
            this.open_file_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // clear_button
            // 
            this.clear_button.Location = new System.Drawing.Point(289, 40);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(75, 23);
            this.clear_button.TabIndex = 1;
            this.clear_button.Text = "Clear";
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.button2_Click);
            // 
            // file_dir_text
            // 
            this.file_dir_text.Location = new System.Drawing.Point(89, 17);
            this.file_dir_text.Name = "file_dir_text";
            this.file_dir_text.Size = new System.Drawing.Size(185, 20);
            this.file_dir_text.TabIndex = 2;
            this.file_dir_text.Text = "Write your File Directory ";
            this.file_dir_text.TextChanged += new System.EventHandler(this.file_dir_text_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "File Directory :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // start_button
            // 
            this.start_button.Location = new System.Drawing.Point(289, 118);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(75, 45);
            this.start_button.TabIndex = 4;
            this.start_button.Text = "Start";
            this.start_button.UseVisualStyleBackColor = true;
            this.start_button.Click += new System.EventHandler(this.start_button_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(48, 97);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(226, 134);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(290, 249);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(75, 23);
            this.save_button.TabIndex = 6;
            this.save_button.Text = "Save";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Saved Text Name";
            // 
            // saved_button
            // 
            this.saved_button.Location = new System.Drawing.Point(117, 258);
            this.saved_button.Name = "saved_button";
            this.saved_button.Size = new System.Drawing.Size(100, 20);
            this.saved_button.TabIndex = 8;
            this.saved_button.TextChanged += new System.EventHandler(this.saved_button_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ouput :";
            // 
            // BONUSE
            // 
            this.BONUSE.Controls.Add(this.tabPage1);
            this.BONUSE.Controls.Add(this.tabPage2);
            this.BONUSE.Controls.Add(this.tabPage3);
            this.BONUSE.Location = new System.Drawing.Point(-3, 2);
            this.BONUSE.Name = "BONUSE";
            this.BONUSE.SelectedIndex = 0;
            this.BONUSE.Size = new System.Drawing.Size(413, 381);
            this.BONUSE.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.progressBar);
            this.tabPage1.Controls.Add(this.Time);
            this.tabPage1.Controls.Add(this.file_dir_text);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.start_button);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.saved_button);
            this.tabPage1.Controls.Add(this.open_file_button);
            this.tabPage1.Controls.Add(this.clear_button);
            this.tabPage1.Controls.Add(this.save_button);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(405, 355);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "RSA ";
            // 
            // progressBar
            // 
            this.progressBar.Cursor = System.Windows.Forms.Cursors.Default;
            this.progressBar.Location = new System.Drawing.Point(89, 68);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(185, 23);
            this.progressBar.TabIndex = 11;
            this.progressBar.Click += new System.EventHandler(this.progressBar_Click);
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.Location = new System.Drawing.Point(290, 187);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(39, 13);
            this.Time.TabIndex = 10;
            this.Time.Text = " Time :";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.operation_time);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.full_text);
            this.tabPage2.Controls.Add(this.input);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(405, 355);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "BigInteger Calculator";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // operation_time
            // 
            this.operation_time.AutoSize = true;
            this.operation_time.Location = new System.Drawing.Point(61, 170);
            this.operation_time.Name = "operation_time";
            this.operation_time.Size = new System.Drawing.Size(0, 13);
            this.operation_time.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Time :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Full input :";
            // 
            // full_text
            // 
            this.full_text.AutoSize = true;
            this.full_text.Location = new System.Drawing.Point(69, 76);
            this.full_text.Name = "full_text";
            this.full_text.Size = new System.Drawing.Size(0, 13);
            this.full_text.TabIndex = 9;
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(58, 97);
            this.input.Multiline = true;
            this.input.Name = "input";
            this.input.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.input.Size = new System.Drawing.Size(148, 70);
            this.input.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.mod_button);
            this.panel1.Controls.Add(this.power_button);
            this.panel1.Controls.Add(this.clear_but);
            this.panel1.Controls.Add(this.minus_button);
            this.panel1.Controls.Add(this.div_button);
            this.panel1.Controls.Add(this.equal_button);
            this.panel1.Controls.Add(this.add_button);
            this.panel1.Controls.Add(this.mul_button);
            this.panel1.Location = new System.Drawing.Point(232, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(161, 153);
            this.panel1.TabIndex = 7;
            // 
            // mod_button
            // 
            this.mod_button.Location = new System.Drawing.Point(70, 81);
            this.mod_button.Name = "mod_button";
            this.mod_button.Size = new System.Drawing.Size(51, 29);
            this.mod_button.TabIndex = 7;
            this.mod_button.Text = "%";
            this.mod_button.UseVisualStyleBackColor = true;
            this.mod_button.Click += new System.EventHandler(this.mod_button_Click);
            // 
            // power_button
            // 
            this.power_button.Location = new System.Drawing.Point(13, 81);
            this.power_button.Name = "power_button";
            this.power_button.Size = new System.Drawing.Size(51, 29);
            this.power_button.TabIndex = 6;
            this.power_button.Text = "^";
            this.power_button.UseVisualStyleBackColor = true;
            this.power_button.Click += new System.EventHandler(this.power_button_Click);
            // 
            // clear_but
            // 
            this.clear_but.Location = new System.Drawing.Point(70, 117);
            this.clear_but.Name = "clear_but";
            this.clear_but.Size = new System.Drawing.Size(51, 29);
            this.clear_but.TabIndex = 5;
            this.clear_but.Text = "C";
            this.clear_but.UseVisualStyleBackColor = true;
            this.clear_but.Click += new System.EventHandler(this.clear_but_Click);
            // 
            // minus_button
            // 
            this.minus_button.Location = new System.Drawing.Point(70, 7);
            this.minus_button.Name = "minus_button";
            this.minus_button.Size = new System.Drawing.Size(51, 29);
            this.minus_button.TabIndex = 1;
            this.minus_button.Text = "-";
            this.minus_button.UseVisualStyleBackColor = true;
            this.minus_button.Click += new System.EventHandler(this.minus_button_Click);
            // 
            // div_button
            // 
            this.div_button.Location = new System.Drawing.Point(13, 44);
            this.div_button.Name = "div_button";
            this.div_button.Size = new System.Drawing.Size(51, 29);
            this.div_button.TabIndex = 3;
            this.div_button.Text = "/";
            this.div_button.UseVisualStyleBackColor = true;
            this.div_button.Click += new System.EventHandler(this.div_button_Click);
            // 
            // equal_button
            // 
            this.equal_button.Location = new System.Drawing.Point(13, 116);
            this.equal_button.Name = "equal_button";
            this.equal_button.Size = new System.Drawing.Size(51, 29);
            this.equal_button.TabIndex = 4;
            this.equal_button.Text = "=";
            this.equal_button.UseVisualStyleBackColor = true;
            this.equal_button.Click += new System.EventHandler(this.equal_button_Click);
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(13, 7);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(51, 29);
            this.add_button.TabIndex = 0;
            this.add_button.Text = "+";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // mul_button
            // 
            this.mul_button.Location = new System.Drawing.Point(70, 45);
            this.mul_button.Name = "mul_button";
            this.mul_button.Size = new System.Drawing.Size(51, 29);
            this.mul_button.TabIndex = 2;
            this.mul_button.Text = "*";
            this.mul_button.UseVisualStyleBackColor = true;
            this.mul_button.Click += new System.EventHandler(this.mul_button_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(278, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Controls";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Controls.Add(this.Prime);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.Bouns_text);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(405, 355);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Bonus";
            // 
            // Prime
            // 
            this.Prime.Location = new System.Drawing.Point(134, 198);
            this.Prime.Name = "Prime";
            this.Prime.Size = new System.Drawing.Size(87, 23);
            this.Prime.TabIndex = 13;
            this.Prime.Text = "Prime";
            this.Prime.UseVisualStyleBackColor = true;
            this.Prime.Click += new System.EventHandler(this.Prime_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Enter Your Text ";
            // 
            // Bouns_text
            // 
            this.Bouns_text.Location = new System.Drawing.Point(113, 111);
            this.Bouns_text.Multiline = true;
            this.Bouns_text.Name = "Bouns_text";
            this.Bouns_text.Size = new System.Drawing.Size(143, 50);
            this.Bouns_text.TabIndex = 1;
            // 
            // SyncTask
            // 
            this.SyncTask.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Progress";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(410, 381);
            this.Controls.Add(this.BONUSE);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "RSA";
            this.BONUSE.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button open_file_button;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.TextBox file_dir_text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox saved_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl BONUSE;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Button div_button;
        private System.Windows.Forms.Button minus_button;
        private System.Windows.Forms.Button mul_button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button equal_button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label full_text;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button clear_but;
        private System.Windows.Forms.Label Time;
        private System.ComponentModel.BackgroundWorker SyncTask;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label operation_time;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Prime;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Bouns_text;
        private System.Windows.Forms.Button mod_button;
        private System.Windows.Forms.Button power_button;
        private System.Windows.Forms.Label label8;
    }
}

