namespace Lab5
{
    partial class Lab5
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
            this.listBoxRangeSearch = new System.Windows.Forms.ListBox();
            this.buttonRangeSearch = new System.Windows.Forms.Button();
            this.labelRangeSearchTimer = new System.Windows.Forms.Label();
            this.labelSearch = new System.Windows.Forms.Label();
            this.textBoxRangeSearch = new System.Windows.Forms.TextBox();
            this.labelReadTimer = new System.Windows.Forms.Label();
            this.buttonReadFile = new System.Windows.Forms.Button();
            this.labelMaxRange = new System.Windows.Forms.Label();
            this.textBoxMaxRange = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBoxRangeSearch
            // 
            this.listBoxRangeSearch.FormattingEnabled = true;
            this.listBoxRangeSearch.Location = new System.Drawing.Point(12, 235);
            this.listBoxRangeSearch.Name = "listBoxRangeSearch";
            this.listBoxRangeSearch.Size = new System.Drawing.Size(303, 251);
            this.listBoxRangeSearch.TabIndex = 13;
            // 
            // buttonRangeSearch
            // 
            this.buttonRangeSearch.Location = new System.Drawing.Point(300, 119);
            this.buttonRangeSearch.Name = "buttonRangeSearch";
            this.buttonRangeSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonRangeSearch.TabIndex = 12;
            this.buttonRangeSearch.Text = "Поиск";
            this.buttonRangeSearch.UseVisualStyleBackColor = true;
            this.buttonRangeSearch.Click += new System.EventHandler(this.buttonRangeSearch_Click);
            // 
            // labelRangeSearchTimer
            // 
            this.labelRangeSearchTimer.AutoSize = true;
            this.labelRangeSearchTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelRangeSearchTimer.Location = new System.Drawing.Point(300, 149);
            this.labelRangeSearchTimer.Name = "labelRangeSearchTimer";
            this.labelRangeSearchTimer.Size = new System.Drawing.Size(104, 17);
            this.labelRangeSearchTimer.TabIndex = 11;
            this.labelRangeSearchTimer.Text = "Время поиска:";
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelSearch.Location = new System.Drawing.Point(58, 122);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(130, 17);
            this.labelSearch.TabIndex = 10;
            this.labelSearch.Text = "Слово для поиска:";
            // 
            // textBoxRangeSearch
            // 
            this.textBoxRangeSearch.Location = new System.Drawing.Point(194, 122);
            this.textBoxRangeSearch.Name = "textBoxRangeSearch";
            this.textBoxRangeSearch.Size = new System.Drawing.Size(100, 20);
            this.textBoxRangeSearch.TabIndex = 9;
            // 
            // labelReadTimer
            // 
            this.labelReadTimer.AutoSize = true;
            this.labelReadTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.labelReadTimer.Location = new System.Drawing.Point(126, 25);
            this.labelReadTimer.Name = "labelReadTimer";
            this.labelReadTimer.Size = new System.Drawing.Size(108, 18);
            this.labelReadTimer.TabIndex = 8;
            this.labelReadTimer.Text = "Время чтения:";
            // 
            // buttonReadFile
            // 
            this.buttonReadFile.Location = new System.Drawing.Point(12, 12);
            this.buttonReadFile.Name = "buttonReadFile";
            this.buttonReadFile.Size = new System.Drawing.Size(107, 49);
            this.buttonReadFile.TabIndex = 7;
            this.buttonReadFile.Text = "Чтение файла";
            this.buttonReadFile.UseVisualStyleBackColor = true;
            this.buttonReadFile.Click += new System.EventHandler(this.buttonReadFile_Click);
            // 
            // labelMaxRange
            // 
            this.labelMaxRange.AutoSize = true;
            this.labelMaxRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelMaxRange.Location = new System.Drawing.Point(2, 147);
            this.labelMaxRange.Name = "labelMaxRange";
            this.labelMaxRange.Size = new System.Drawing.Size(186, 17);
            this.labelMaxRange.TabIndex = 15;
            this.labelMaxRange.Text = "Максимальное расстояние";
            // 
            // textBoxMaxRange
            // 
            this.textBoxMaxRange.Location = new System.Drawing.Point(194, 148);
            this.textBoxMaxRange.Name = "textBoxMaxRange";
            this.textBoxMaxRange.Size = new System.Drawing.Size(100, 20);
            this.textBoxMaxRange.TabIndex = 14;
            // 
            // Lab5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 498);
            this.Controls.Add(this.labelMaxRange);
            this.Controls.Add(this.textBoxMaxRange);
            this.Controls.Add(this.listBoxRangeSearch);
            this.Controls.Add(this.buttonRangeSearch);
            this.Controls.Add(this.labelRangeSearchTimer);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.textBoxRangeSearch);
            this.Controls.Add(this.labelReadTimer);
            this.Controls.Add(this.buttonReadFile);
            this.Name = "Lab5";
            this.Text = "Lab5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxRangeSearch;
        private System.Windows.Forms.Button buttonRangeSearch;
        private System.Windows.Forms.Label labelRangeSearchTimer;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.TextBox textBoxRangeSearch;
        private System.Windows.Forms.Label labelReadTimer;
        private System.Windows.Forms.Button buttonReadFile;
        private System.Windows.Forms.Label labelMaxRange;
        private System.Windows.Forms.TextBox textBoxMaxRange;
    }
}

