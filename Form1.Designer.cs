namespace WindowsFormsApplication3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.jpan = new System.Windows.Forms.CheckBox();
            this.phil = new System.Windows.Forms.CheckBox();
            this.thai = new System.Windows.Forms.CheckBox();
            this.aust = new System.Windows.Forms.CheckBox();
            this.othrs = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.subB = new System.Windows.Forms.Button();
            this.closeB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(51, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Survey";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(53, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "What country would you like to visit?";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(53, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "If Others, Please Specify:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // jpan
            // 
            this.jpan.AutoSize = true;
            this.jpan.Location = new System.Drawing.Point(56, 132);
            this.jpan.Name = "jpan";
            this.jpan.Size = new System.Drawing.Size(55, 17);
            this.jpan.TabIndex = 3;
            this.jpan.Text = "Japan";
            this.jpan.UseVisualStyleBackColor = true;
            this.jpan.CheckedChanged += new System.EventHandler(this.jpan_CheckedChanged);
            // 
            // phil
            // 
            this.phil.AutoSize = true;
            this.phil.Location = new System.Drawing.Point(56, 155);
            this.phil.Name = "phil";
            this.phil.Size = new System.Drawing.Size(76, 17);
            this.phil.TabIndex = 4;
            this.phil.Text = "Philippines";
            this.phil.UseVisualStyleBackColor = true;
            this.phil.CheckedChanged += new System.EventHandler(this.phil_CheckedChanged);
            // 
            // thai
            // 
            this.thai.AutoSize = true;
            this.thai.Location = new System.Drawing.Point(171, 132);
            this.thai.Name = "thai";
            this.thai.Size = new System.Drawing.Size(67, 17);
            this.thai.TabIndex = 5;
            this.thai.Text = "Thailand";
            this.thai.UseVisualStyleBackColor = true;
            this.thai.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // aust
            // 
            this.aust.AutoSize = true;
            this.aust.Location = new System.Drawing.Point(171, 155);
            this.aust.Name = "aust";
            this.aust.Size = new System.Drawing.Size(66, 17);
            this.aust.TabIndex = 6;
            this.aust.Text = "Australia";
            this.aust.UseVisualStyleBackColor = true;
            this.aust.CheckedChanged += new System.EventHandler(this.aust_CheckedChanged);
            // 
            // othrs
            // 
            this.othrs.AutoSize = true;
            this.othrs.Location = new System.Drawing.Point(171, 187);
            this.othrs.Name = "othrs";
            this.othrs.Size = new System.Drawing.Size(57, 17);
            this.othrs.TabIndex = 7;
            this.othrs.Text = "Others";
            this.othrs.UseVisualStyleBackColor = true;
            this.othrs.CheckedChanged += new System.EventHandler(this.othrs_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(56, 274);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(160, 20);
            this.textBox1.TabIndex = 8;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // subB
            // 
            this.subB.Location = new System.Drawing.Point(95, 341);
            this.subB.Name = "subB";
            this.subB.Size = new System.Drawing.Size(75, 23);
            this.subB.TabIndex = 9;
            this.subB.Text = "Submit";
            this.subB.UseVisualStyleBackColor = true;
            this.subB.Click += new System.EventHandler(this.subB_Click);
            // 
            // closeB
            // 
            this.closeB.Location = new System.Drawing.Point(176, 341);
            this.closeB.Name = "closeB";
            this.closeB.Size = new System.Drawing.Size(75, 23);
            this.closeB.TabIndex = 10;
            this.closeB.Text = "Close";
            this.closeB.UseVisualStyleBackColor = true;
            this.closeB.Click += new System.EventHandler(this.closeB_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 413);
            this.Controls.Add(this.closeB);
            this.Controls.Add(this.subB);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.othrs);
            this.Controls.Add(this.aust);
            this.Controls.Add(this.thai);
            this.Controls.Add(this.phil);
            this.Controls.Add(this.jpan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox jpan;
        private System.Windows.Forms.CheckBox phil;
        private System.Windows.Forms.CheckBox thai;
        private System.Windows.Forms.CheckBox aust;
        private System.Windows.Forms.CheckBox othrs;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button subB;
        private System.Windows.Forms.Button closeB;
    }
}

