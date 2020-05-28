namespace PP_Z12_WinForms_
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
            this.Zadanie = new System.Windows.Forms.GroupBox();
            this.given = new System.Windows.Forms.Label();
            this.information = new System.Windows.Forms.Label();
            this.unaru = new System.Windows.Forms.Label();
            this.unary_rez = new System.Windows.Forms.Label();
            this.text_rez = new System.Windows.Forms.Label();
            this.binary = new System.Windows.Forms.Label();
            this.binary_rez = new System.Windows.Forms.Label();
            this.indexer1 = new System.Windows.Forms.Label();
            this.indexer_0 = new System.Windows.Forms.Label();
            this.indexer2 = new System.Windows.Forms.Label();
            this.indexer_1 = new System.Windows.Forms.Label();
            this.Result = new System.Windows.Forms.Button();
            this.Zadanie.SuspendLayout();
            this.SuspendLayout();
            // 
            // Zadanie
            // 
            this.Zadanie.Controls.Add(this.Result);
            this.Zadanie.Controls.Add(this.indexer_1);
            this.Zadanie.Controls.Add(this.indexer2);
            this.Zadanie.Controls.Add(this.indexer_0);
            this.Zadanie.Controls.Add(this.indexer1);
            this.Zadanie.Controls.Add(this.binary_rez);
            this.Zadanie.Controls.Add(this.binary);
            this.Zadanie.Controls.Add(this.text_rez);
            this.Zadanie.Controls.Add(this.unary_rez);
            this.Zadanie.Controls.Add(this.unaru);
            this.Zadanie.Controls.Add(this.information);
            this.Zadanie.Controls.Add(this.given);
            this.Zadanie.Location = new System.Drawing.Point(12, 12);
            this.Zadanie.Name = "Zadanie";
            this.Zadanie.Size = new System.Drawing.Size(609, 461);
            this.Zadanie.TabIndex = 0;
            this.Zadanie.TabStop = false;
            this.Zadanie.Text = "Задание";
            // 
            // given
            // 
            this.given.AutoSize = true;
            this.given.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.given.Location = new System.Drawing.Point(6, 18);
            this.given.Name = "given";
            this.given.Size = new System.Drawing.Size(52, 17);
            this.given.TabIndex = 0;
            this.given.Text = "Дано:";
            // 
            // information
            // 
            this.information.AutoSize = true;
            this.information.Location = new System.Drawing.Point(6, 35);
            this.information.Name = "information";
            this.information.Size = new System.Drawing.Size(0, 17);
            this.information.TabIndex = 1;
            // 
            // unaru
            // 
            this.unaru.AutoSize = true;
            this.unaru.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.unaru.Location = new System.Drawing.Point(6, 140);
            this.unaru.Name = "unaru";
            this.unaru.Size = new System.Drawing.Size(177, 17);
            this.unaru.TabIndex = 2;
            this.unaru.Text = "Операция унарного - :";
            // 
            // unary_rez
            // 
            this.unary_rez.AutoSize = true;
            this.unary_rez.Location = new System.Drawing.Point(6, 157);
            this.unary_rez.Name = "unary_rez";
            this.unary_rez.Size = new System.Drawing.Size(0, 17);
            this.unary_rez.TabIndex = 3;
            // 
            // text_rez
            // 
            this.text_rez.AutoSize = true;
            this.text_rez.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_rez.Location = new System.Drawing.Point(6, 198);
            this.text_rez.Name = "text_rez";
            this.text_rez.Size = new System.Drawing.Size(0, 17);
            this.text_rez.TabIndex = 4;
            // 
            // binary
            // 
            this.binary.AutoSize = true;
            this.binary.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.binary.Location = new System.Drawing.Point(7, 244);
            this.binary.Name = "binary";
            this.binary.Size = new System.Drawing.Size(190, 17);
            this.binary.TabIndex = 5;
            this.binary.Text = "Операция бинарного + :";
            // 
            // binary_rez
            // 
            this.binary_rez.AutoSize = true;
            this.binary_rez.Location = new System.Drawing.Point(7, 261);
            this.binary_rez.Name = "binary_rez";
            this.binary_rez.Size = new System.Drawing.Size(0, 17);
            this.binary_rez.TabIndex = 6;
            // 
            // indexer1
            // 
            this.indexer1.AutoSize = true;
            this.indexer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.indexer1.Location = new System.Drawing.Point(6, 294);
            this.indexer1.Name = "indexer1";
            this.indexer1.Size = new System.Drawing.Size(539, 17);
            this.indexer1.TabIndex = 7;
            this.indexer1.Text = "Индексатор, позволяющий по индексу 0 обращаться к полю r (My[0]) :";
            // 
            // indexer_0
            // 
            this.indexer_0.AutoSize = true;
            this.indexer_0.Location = new System.Drawing.Point(7, 311);
            this.indexer_0.Name = "indexer_0";
            this.indexer_0.Size = new System.Drawing.Size(0, 17);
            this.indexer_0.TabIndex = 8;
            // 
            // indexer2
            // 
            this.indexer2.AutoSize = true;
            this.indexer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.indexer2.Location = new System.Drawing.Point(6, 344);
            this.indexer2.Name = "indexer2";
            this.indexer2.Size = new System.Drawing.Size(559, 17);
            this.indexer2.TabIndex = 9;
            this.indexer2.Text = "Индексатор, позволяющий по индексу 1 обращаться к полю text (My[1]) :";
            // 
            // indexer_1
            // 
            this.indexer_1.AutoSize = true;
            this.indexer_1.Location = new System.Drawing.Point(6, 361);
            this.indexer_1.Name = "indexer_1";
            this.indexer_1.Size = new System.Drawing.Size(0, 17);
            this.indexer_1.TabIndex = 10;
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(184, 385);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(222, 56);
            this.Result.TabIndex = 11;
            this.Result.Text = "Результат";
            this.Result.UseVisualStyleBackColor = true;
            this.Result.Click += new System.EventHandler(this.Result_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 485);
            this.Controls.Add(this.Zadanie);
            this.Name = "Form1";
            this.Text = "Практика 12";
            this.Zadanie.ResumeLayout(false);
            this.Zadanie.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Zadanie;
        private System.Windows.Forms.Button Result;
        private System.Windows.Forms.Label indexer_1;
        private System.Windows.Forms.Label indexer2;
        private System.Windows.Forms.Label indexer_0;
        private System.Windows.Forms.Label indexer1;
        private System.Windows.Forms.Label binary_rez;
        private System.Windows.Forms.Label binary;
        private System.Windows.Forms.Label text_rez;
        private System.Windows.Forms.Label unary_rez;
        private System.Windows.Forms.Label unaru;
        private System.Windows.Forms.Label information;
        private System.Windows.Forms.Label given;
    }
}

