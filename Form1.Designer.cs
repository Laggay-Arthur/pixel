namespace pixel
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox0y = new System.Windows.Forms.TextBox();
            this.textBox0x = new System.Windows.Forms.TextBox();
            this.textBox1y = new System.Windows.Forms.TextBox();
            this.textBox1x = new System.Windows.Forms.TextBox();
            this.textBox2y = new System.Windows.Forms.TextBox();
            this.textBox2x = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(379, 257);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(220, 275);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 45);
            this.button1.TabIndex = 1;
            this.button1.Text = "Точка";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox0y
            // 
            this.textBox0y.Location = new System.Drawing.Point(46, 301);
            this.textBox0y.Name = "textBox0y";
            this.textBox0y.Size = new System.Drawing.Size(48, 20);
            this.textBox0y.TabIndex = 2;
            this.textBox0y.Text = "10";
            // 
            // textBox0x
            // 
            this.textBox0x.Location = new System.Drawing.Point(46, 275);
            this.textBox0x.Name = "textBox0x";
            this.textBox0x.Size = new System.Drawing.Size(48, 20);
            this.textBox0x.TabIndex = 3;
            this.textBox0x.Text = "10";
            // 
            // textBox1y
            // 
            this.textBox1y.Location = new System.Drawing.Point(100, 300);
            this.textBox1y.Name = "textBox1y";
            this.textBox1y.Size = new System.Drawing.Size(54, 20);
            this.textBox1y.TabIndex = 4;
            this.textBox1y.Text = "200";
            // 
            // textBox1x
            // 
            this.textBox1x.Location = new System.Drawing.Point(100, 275);
            this.textBox1x.Name = "textBox1x";
            this.textBox1x.Size = new System.Drawing.Size(54, 20);
            this.textBox1x.TabIndex = 5;
            this.textBox1x.Text = "100";
            // 
            // textBox2y
            // 
            this.textBox2y.Location = new System.Drawing.Point(160, 300);
            this.textBox2y.Name = "textBox2y";
            this.textBox2y.Size = new System.Drawing.Size(54, 20);
            this.textBox2y.TabIndex = 6;
            this.textBox2y.Text = "150";
            // 
            // textBox2x
            // 
            this.textBox2x.Location = new System.Drawing.Point(160, 274);
            this.textBox2x.Name = "textBox2x";
            this.textBox2x.Size = new System.Drawing.Size(54, 20);
            this.textBox2x.TabIndex = 7;
            this.textBox2x.Text = "30";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(278, 275);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(52, 45);
            this.button2.TabIndex = 8;
            this.button2.Text = "Линия";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(336, 275);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(55, 45);
            this.button3.TabIndex = 9;
            this.button3.Text = "Треуг.";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "x";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "y";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(403, 326);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox2x);
            this.Controls.Add(this.textBox2y);
            this.Controls.Add(this.textBox1x);
            this.Controls.Add(this.textBox1y);
            this.Controls.Add(this.textBox0x);
            this.Controls.Add(this.textBox0y);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Базовая графика";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox0y;
        private System.Windows.Forms.TextBox textBox0x;
        private System.Windows.Forms.TextBox textBox1y;
        private System.Windows.Forms.TextBox textBox1x;
        private System.Windows.Forms.TextBox textBox2y;
        private System.Windows.Forms.TextBox textBox2x;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

