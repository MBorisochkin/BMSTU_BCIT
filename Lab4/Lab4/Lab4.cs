using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Lab4
{
    public partial class Lab4 : Form
    {
        public Lab4()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Список со словами
        /// </summary>
        List<string> wordlist = new List<string>();

        /// <summary>
        /// Чтение файла
        /// </summary>
        private void buttonReadFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "Текстовые файлы|*.txt";

            if (fd.ShowDialog() == DialogResult.OK)
            {
                // Запуск таймера
                Stopwatch tmr = new Stopwatch();
                tmr.Start();

                //Чтение файла в виде строки
                string ftext = File.ReadAllText(fd.FileName);

                // Разделители
                char[] separators = new char[] { ' ', '.', ',', '!', '?', '/', '\t', '\n' };

                string[] ftetxArray = ftext.Split(separators);

                foreach (string strTemp in ftetxArray)
                {
                    // Удаление пробелов в начале и в конце строки
                    string str = strTemp.Trim();

                    // Добавление строки в список, если её нет с списке
                    if (!wordlist.Contains(str))
                        wordlist.Add(str);
                }

                // Остановка таймера
                tmr.Stop();
                this.labelReadTimer.Text = "Время чтения: " + tmr.Elapsed.ToString();
            }
            else
                MessageBox.Show("Необходимо выбрать файл","Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);    
        }

        /// <summary>
        /// Поиск подстрок
        /// </summary>
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            // Слово для поиска
            string word = this.textBoxSearch.Text.Trim();

            // Если слово для поиска не пусто
            if(!string.IsNullOrWhiteSpace(word) && wordlist.Count > 0)
            {
                // Слово для поиска в верхнем регистре
                string wordUpper = word.ToUpper();

                // Временные результаты поиска
                List<string> tempList = new List<string>();

                // Запуск таймера
                Stopwatch tmr = new Stopwatch();
                tmr.Start();

                foreach(string str in wordlist)
                {
                    if (str.ToUpper().Contains(wordUpper))
                        tempList.Add(str);
                }

                // Остановка таймера
                tmr.Stop();
                this.labelSearchTimer.Text = "Время чтения: " + tmr.Elapsed.ToString();

                this.listBoxSearch.BeginUpdate();

                // Очистка списка
                this.listBoxSearch.Items.Clear();

                //Вывод результатов поиска
                foreach(string str in tempList)
                {
                    this.listBoxSearch.Items.Add(str);
                }

                this.listBoxSearch.EndUpdate();
            }
            else
                MessageBox.Show("Необходимо выбрать слово для поиска или считать файл", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
