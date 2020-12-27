namespace Lab4
{
    partial class Lab4
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
            this.buttonReadFile = new System.Windows.Forms.Button();
            this.labelReadTimer = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.labelSearch = new System.Windows.Forms.Label();
            this.labelSearchTimer = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.listBoxSearch = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // buttonReadFile
            // 
            this.buttonReadFile.Location = new System.Drawing.Point(12, 12);
            this.buttonReadFile.Name = "buttonReadFile";
            this.buttonReadFile.Size = new System.Drawing.Size(107, 49);
            this.buttonReadFile.TabIndex = 0;
            this.buttonReadFile.Text = "Чтение файла";
            this.buttonReadFile.UseVisualStyleBackColor = true;
            this.buttonReadFile.Click += new System.EventHandler(this.buttonReadFile_Click);
            // 
            // labelReadTimer
            // 
            this.labelReadTimer.AutoSize = true;
            this.labelReadTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.labelReadTimer.Location = new System.Drawing.Point(126, 25);
            this.labelReadTimer.Name = "labelReadTimer";
            this.labelReadTimer.Size = new System.Drawing.Size(108, 18);
            this.labelReadTimer.TabIndex = 1;
            this.labelReadTimer.Text = "Время чтения:";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(134, 121);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(100, 20);
            this.textBoxSearch.TabIndex = 2;
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelSearch.Location = new System.Drawing.Point(2, 121);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(130, 17);
            this.labelSearch.TabIndex = 3;
            this.labelSearch.Text = "Слово для поиска:";
            // 
            // labelSearchTimer
            // 
            this.labelSearchTimer.AutoSize = true;
            this.labelSearchTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelSearchTimer.Location = new System.Drawing.Point(332, 122);
            this.labelSearchTimer.Name = "labelSearchTimer";
            this.labelSearchTimer.Size = new System.Drawing.Size(104, 17);
            this.labelSearchTimer.TabIndex = 4;
            this.labelSearchTimer.Text = "Время поиска:";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(240, 119);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 5;
            this.buttonSearch.Text = "Поиск";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // listBoxSearch
            // 
            this.listBoxSearch.FormattingEnabled = true;
            this.listBoxSearch.Location = new System.Drawing.Point(12, 167);
            this.listBoxSearch.Name = "listBoxSearch";
            this.listBoxSearch.Size = new System.Drawing.Size(303, 251);
            this.listBoxSearch.TabIndex = 6;
            // 
            // Lab4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 450);
            this.Controls.Add(this.listBoxSearch);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.labelSearchTimer);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.labelReadTimer);
            this.Controls.Add(this.buttonReadFile);
            this.Name = "Lab4";
            this.Text = "Lab 4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonReadFile;
        private System.Windows.Forms.Label labelReadTimer;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.Label labelSearchTimer;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.ListBox listBoxSearch;
    }
}

