
namespace prac11._2
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
        protected override void Dispose (bool disposing)
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
        private void InitializeComponent ()
        {
            this.name = new System.Windows.Forms.Label();
            this.otc = new System.Windows.Forms.Label();
            this.adres = new System.Windows.Forms.Label();
            this.numbercard = new System.Windows.Forms.Label();
            this.acceptbutton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.surname = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.sort = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name.Location = new System.Drawing.Point(7, 49);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(56, 26);
            this.name.TabIndex = 1;
            this.name.Text = "Имя";
            // 
            // otc
            // 
            this.otc.AutoSize = true;
            this.otc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.otc.Location = new System.Drawing.Point(7, 90);
            this.otc.Name = "otc";
            this.otc.Size = new System.Drawing.Size(108, 26);
            this.otc.TabIndex = 2;
            this.otc.Text = "Отчество";
            // 
            // adres
            // 
            this.adres.AutoSize = true;
            this.adres.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.adres.Location = new System.Drawing.Point(7, 162);
            this.adres.Name = "adres";
            this.adres.Size = new System.Drawing.Size(75, 26);
            this.adres.TabIndex = 3;
            this.adres.Text = "Адрес";
            // 
            // numbercard
            // 
            this.numbercard.AutoSize = true;
            this.numbercard.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numbercard.Location = new System.Drawing.Point(7, 198);
            this.numbercard.Name = "numbercard";
            this.numbercard.Size = new System.Drawing.Size(147, 26);
            this.numbercard.TabIndex = 4;
            this.numbercard.Text = "Номер карты";
            this.numbercard.Click += new System.EventHandler(this.numbercard_Click);
            // 
            // acceptbutton
            // 
            this.acceptbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.acceptbutton.Location = new System.Drawing.Point(181, 238);
            this.acceptbutton.Name = "acceptbutton";
            this.acceptbutton.Size = new System.Drawing.Size(185, 23);
            this.acceptbutton.TabIndex = 5;
            this.acceptbutton.Text = "Применить";
            this.acceptbutton.UseVisualStyleBackColor = true;
            this.acceptbutton.Click += new System.EventHandler(this.acceptbutton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(181, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(185, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(181, 55);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(185, 20);
            this.textBox2.TabIndex = 7;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(181, 96);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(185, 20);
            this.textBox3.TabIndex = 8;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(181, 204);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(185, 20);
            this.textBox4.TabIndex = 9;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(181, 168);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(185, 20);
            this.textBox5.TabIndex = 10;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // surname
            // 
            this.surname.AutoSize = true;
            this.surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surname.Location = new System.Drawing.Point(7, 7);
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(108, 26);
            this.surname.TabIndex = 11;
            this.surname.Text = "Фамилия";
            this.surname.Click += new System.EventHandler(this.surname_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(393, 7);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(265, 225);
            this.listBox1.TabIndex = 12;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // sort
            // 
            this.sort.Location = new System.Drawing.Point(393, 238);
            this.sort.Name = "sort";
            this.sort.Size = new System.Drawing.Size(265, 23);
            this.sort.TabIndex = 13;
            this.sort.Text = "Сортировать";
            this.sort.UseVisualStyleBackColor = true;
            this.sort.Click += new System.EventHandler(this.sort_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(393, 548);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(265, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Сортировать";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(393, 317);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(265, 225);
            this.listBox2.TabIndex = 14;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(181, 478);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(185, 20);
            this.textBox6.TabIndex = 20;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(181, 514);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(185, 20);
            this.textBox7.TabIndex = 19;
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(181, 548);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(185, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "Применить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(7, 508);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 26);
            this.label1.TabIndex = 17;
            this.label1.Text = "Номер карты";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(7, 472);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 26);
            this.label2.TabIndex = 16;
            this.label2.Text = "Адрес";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 607);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.sort);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.surname);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.acceptbutton);
            this.Controls.Add(this.numbercard);
            this.Controls.Add(this.adres);
            this.Controls.Add(this.otc);
            this.Controls.Add(this.name);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label otc;
        private System.Windows.Forms.Label adres;
        private System.Windows.Forms.Label numbercard;
        private System.Windows.Forms.Button acceptbutton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label surname;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button sort;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

