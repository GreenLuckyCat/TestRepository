namespace WindowsFormsApplication2
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
            this.l_a = new System.Windows.Forms.Label();
            this.l_b = new System.Windows.Forms.Label();
            this.l_c = new System.Windows.Forms.Label();
            this.txt_a = new System.Windows.Forms.TextBox();
            this.txt_b = new System.Windows.Forms.TextBox();
            this.txt_c = new System.Windows.Forms.TextBox();
            this.l_S = new System.Windows.Forms.Label();
            this.l_result = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(352, 241);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // l_a
            // 
            this.l_a.AutoSize = true;
            this.l_a.Location = new System.Drawing.Point(117, 288);
            this.l_a.Name = "l_a";
            this.l_a.Size = new System.Drawing.Size(13, 13);
            this.l_a.TabIndex = 1;
            this.l_a.Text = "a";
            // 
            // l_b
            // 
            this.l_b.AutoSize = true;
            this.l_b.Location = new System.Drawing.Point(117, 313);
            this.l_b.Name = "l_b";
            this.l_b.Size = new System.Drawing.Size(13, 13);
            this.l_b.TabIndex = 2;
            this.l_b.Text = "b";
            // 
            // l_c
            // 
            this.l_c.AutoSize = true;
            this.l_c.Location = new System.Drawing.Point(117, 337);
            this.l_c.Name = "l_c";
            this.l_c.Size = new System.Drawing.Size(13, 13);
            this.l_c.TabIndex = 3;
            this.l_c.Text = "c";
            // 
            // txt_a
            // 
            this.txt_a.Location = new System.Drawing.Point(154, 285);
            this.txt_a.Name = "txt_a";
            this.txt_a.Size = new System.Drawing.Size(100, 20);
            this.txt_a.TabIndex = 4;
            this.txt_a.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_a_KeyPress);
            // 
            // txt_b
            // 
            this.txt_b.Location = new System.Drawing.Point(154, 310);
            this.txt_b.Name = "txt_b";
            this.txt_b.Size = new System.Drawing.Size(100, 20);
            this.txt_b.TabIndex = 5;
            this.txt_b.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_b_KeyPress);
            // 
            // txt_c
            // 
            this.txt_c.Location = new System.Drawing.Point(154, 334);
            this.txt_c.Name = "txt_c";
            this.txt_c.Size = new System.Drawing.Size(100, 20);
            this.txt_c.TabIndex = 6;
            this.txt_c.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_c_KeyPress);
            // 
            // l_S
            // 
            this.l_S.AutoSize = true;
            this.l_S.Location = new System.Drawing.Point(151, 413);
            this.l_S.Name = "l_S";
            this.l_S.Size = new System.Drawing.Size(26, 13);
            this.l_S.TabIndex = 7;
            this.l_S.Text = "S = ";
            // 
            // l_result
            // 
            this.l_result.AutoSize = true;
            this.l_result.Location = new System.Drawing.Point(189, 413);
            this.l_result.Name = "l_result";
            this.l_result.Size = new System.Drawing.Size(0, 13);
            this.l_result.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(154, 370);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Считаем";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 451);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.l_result);
            this.Controls.Add(this.l_S);
            this.Controls.Add(this.txt_c);
            this.Controls.Add(this.txt_b);
            this.Controls.Add(this.txt_a);
            this.Controls.Add(this.l_c);
            this.Controls.Add(this.l_b);
            this.Controls.Add(this.l_a);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label l_a;
        private System.Windows.Forms.Label l_b;
        private System.Windows.Forms.Label l_c;
        private System.Windows.Forms.TextBox txt_a;
        private System.Windows.Forms.TextBox txt_b;
        private System.Windows.Forms.TextBox txt_c;
        private System.Windows.Forms.Label l_S;
        private System.Windows.Forms.Label l_result;
        private System.Windows.Forms.Button button1;
    }
}

