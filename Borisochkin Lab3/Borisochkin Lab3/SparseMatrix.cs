using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Borisochkin_Lab3
{
    class SparseMatrix<T>
    {
        /// <summary>
        /// Словарь для хранения значений
        /// </summary>
        Dictionary<string, T> _matrix = new Dictionary<string, T>();

        /// <summary>
        /// Количество элементов по X
        /// </summary>
        int maxX;

        /// <summary>
        /// Количество элементов по Y
        /// </summary>
        int maxY;

        /// <summary>
        /// Количество элементов по Z
        /// </summary>
        int maxZ;

        /// <summary>
        /// Реализация интерфейса для проверки пустого элемента
        /// </summary>
        ISparseMatrixCheckEmpty<T> сheckEmpty;

        /// <summary>
        /// Конструктор
        /// </summary>
        public SparseMatrix(int x, int y, int z, ISparseMatrixCheckEmpty<T> сheckEmptyParam)
        {
            this.maxX = x;
            this.maxY = y;
            this.maxZ = z;
            this.сheckEmpty = сheckEmptyParam;
        }

        /// <summary>
        /// Индексатор для доступа к данных
        /// </summary>
        public T this[int x, int y, int z]
        {
            set
            {
                CheckBounds(x, y, z);
                string key = DictKey(x, y, z);
                this._matrix.Add(key, value);
            }
            get
            {
                CheckBounds(x, y, z);
                string key = DictKey(x, y, z);
                if (this._matrix.ContainsKey(key))
                {
                    return this._matrix[key];
                }
                else
                {
                    return this.сheckEmpty.getEmptyElement();
                }
            }
        }

        /// <summary>
        /// Проверка границ
        /// </summary>
        void CheckBounds(int x, int y, int z)
        {
            if (x < 0 || x >= this.maxX)
            {
                throw new ArgumentOutOfRangeException("x", "x = " + x + " выходит за границы");
            }

            if (y < 0 || y >= this.maxY)
            {
                throw new ArgumentOutOfRangeException("y", "y = " + y + " выходит за границы");
            }

            if (z < 0 || z >= this.maxZ)
            {
                throw new ArgumentOutOfRangeException("z", "z = " + z + " выходит за границы");
            }
        }

        /// <summary>
        /// Формирование ключа
        /// </summary>
        string DictKey(int x, int y, int z)
        {
            return x.ToString() + "_" + y.ToString() + "_" + z.ToString();
        }

        /// <summary>
        /// Приведение к строке
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder b = new StringBuilder();

            for(int k =0; k< this.maxZ; k++)
            {
                b.Append("\nz = " + k + "\n");
                for (int j = 0; j < this.maxY; j++)
                {
                    b.Append("[");
                    for (int i = 0; i < this.maxX; i++)
                    {
                        //Добавление разделителя-табуляции
                        if (i > 0)
                        {
                            b.Append("\t");
                        }
                        //Если текущий элемент не пустой
                        if (!this.сheckEmpty.checkEmptyElement(this[i, j, k]))
                        {
                            //Добавить приведенный к строке текущий элемент
                            b.Append(this[i, j, k].ToString());
                        }
                        else
                        {
                            //Иначе добавить признак пустого значения
                            b.Append(" - ");
                        }
                    }
                    b.Append("]\n");
                }
            }
            return b.ToString();
        }
    }
}
