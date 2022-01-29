
namespace WindowsFormsApp1
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
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Качества = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "1.Аккуратность",
            "2. Беспечность",
            "3. Вдумчивость",
            "4. Восприимчивость",
            "5. Вспыльчивость",
            "6. Гордость",
            "7. Грубость",
            "8. Гуманность ",
            "9. Доброта",
            "10. Жизнерадостность",
            "11. Заботливость",
            "12. Завистливость",
            "13.Застенчивость",
            "14. Злопамятность",
            "15. Искренность",
            "16. Капризность",
            "17. Легковерие",
            "18. Медлительность",
            "19. Мечтательность",
            "20. Мнительность",
            "21. Мстительность\t",
            "22. Надежность",
            "23. Настойчивость",
            "24. Нежность",
            "25. Нерешительность",
            "26. Несдержанность",
            "27. Обаяние",
            "28. Обидчивость",
            "29. Осторожность",
            "30. Отзывчивость",
            "31. Подозрительность",
            "32. Принципиальность",
            "33. Педантичность",
            "34. Радушие",
            "35. Развязность",
            "36. Рассудительность",
            "37. Самокритичность",
            "38. Сдержанность",
            "39. Справедливость",
            "40. Сострадание",
            "41. Стыдливость",
            "42. Практичность",
            "43. Трудолюбие",
            "44. Трусость",
            "45. Убежденность",
            "46. Увлеченность",
            "47. Черствость",
            "48. Эгоизм"});
            this.checkedListBox1.Location = new System.Drawing.Point(12, 31);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(238, 429);
            this.checkedListBox1.TabIndex = 0;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Fuchsia;
            this.label1.Location = new System.Drawing.Point(214, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "0/20";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Fuchsia;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(12, 478);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(238, 58);
            this.button1.TabIndex = 2;
            this.button1.Text = "ВЫБРАТЬ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Fuchsia;
            this.button2.Location = new System.Drawing.Point(123, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "обновить";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(277, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(517, 429);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.Visible = false;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Качества
            // 
            this.Качества.AutoSize = true;
            this.Качества.BackColor = System.Drawing.Color.DarkOrchid;
            this.Качества.Location = new System.Drawing.Point(12, 8);
            this.Качества.Name = "Качества";
            this.Качества.Size = new System.Drawing.Size(72, 17);
            this.Качества.TabIndex = 6;
            this.Качества.Text = "качества:";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Fuchsia;
            this.button3.Location = new System.Drawing.Point(422, 478);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(228, 58);
            this.button3.TabIndex = 7;
            this.button3.Text = "РЕЗУЛЬТАТ";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Fuchsia;
            this.button4.Location = new System.Drawing.Point(871, 79);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(230, 74);
            this.button4.TabIndex = 8;
            this.button4.Text = "Информация о программе";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Fuchsia;
            this.button5.Location = new System.Drawing.Point(871, 278);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(230, 81);
            this.button5.TabIndex = 9;
            this.button5.Text = "ПРАВИЛА";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Fuchsia;
            this.button6.Location = new System.Drawing.Point(871, 185);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(230, 73);
            this.button6.TabIndex = 10;
            this.button6.Text = "Цели теста";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1104, 548);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Качества);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkedListBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label Качества;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}

