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
using ClassLibraryLab5;

namespace Lab5
{
    public partial class Lab5 : Form
    {
        public Lab5()
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
                MessageBox.Show("Необходимо выбрать файл", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void buttonRangeSearch_Click(object sender, EventArgs e)
        {
            string checkword = this.textBoxRangeSearch.Text.Trim();
            int maxdistance = Convert.ToInt32(this.textBoxMaxRange.Text.Trim());

            if (!string.IsNullOrWhiteSpace(checkword) && wordlist.Count > 0)
            {
                // Слово для поиска в верхнем регистре
                string wordUpper = checkword.ToUpper();

                List<string> tempList = new List<string>();

                // Запуск таймера
                Stopwatch tmr = new Stopwatch();
                tmr.Start();

                foreach (string str in wordlist)
                {
                    int distance = Range.Distance(wordUpper, str.ToUpper());

                    // Проверка максимального расстояния
                    if (distance <= maxdistance)
                        tempList.Add(str);
                }

                // Остановка таймера
                tmr.Stop();
                this.labelRangeSearchTimer.Text = "Время поиска: " + tmr.Elapsed.ToString();

                this.listBoxRangeSearch.BeginUpdate();

                // Очистка списка
                this.listBoxRangeSearch.Items.Clear();

                //Вывод результатов поиска
                foreach (string str in tempList)
                {
                    this.listBoxRangeSearch.Items.Add(str);
                }

                this.listBoxRangeSearch.EndUpdate();
            }
        }
    }
}
