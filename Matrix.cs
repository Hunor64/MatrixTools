using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixTools
{
    public class Matrix<T> where T : struct
    {
        private T[,] data;
        private int rows;
        private int columns;

        public Matrix(int rows, int columns)
        {
            this.rows = rows;
            this.columns = columns;
            data = new T[rows, columns];
        }

        public Matrix(int size) : this(size, size) { }

        public Matrix() : this(3, 3) { }

        public int Rows => rows;
        public int Columns => columns;

        public void Fill(T element)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    data[i, j] = element;
                }
            }
        }

        public static Matrix<T> Add(Matrix<T> A, Matrix<T> B)
        {
            if (A.rows == B.rows || A.columns == B.columns)
            {
                Matrix<T> result = new Matrix<T>(A.rows, A.columns);
                for (int i = 0; i < A.rows; i++)
                {
                    for (int j = 0; j < A.columns; j++)
                    {
                        result.data[i, j] = (dynamic)A.data[i, j] + (dynamic)B.data[i, j];
                    }
                }
                return result;
            }
            else
            {
                return null;
            }

        }

        public void RotateX()
        {
            T[,] rotated = new T[columns, rows];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    rotated[j, rows - 1 - i] = data[i, j];
                }
            }
            data = rotated;
            int temp = rows;
            rows = columns;
            columns = temp;
        }

        public void RotateY()
        {
            T[,] rotated = new T[columns, rows];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    rotated[columns - 1 - j, i] = data[i, j];
                }
            }
            data = rotated;
            int temp = rows;
            rows = columns;
            columns = temp;
        }

        public override string ToString()
        {
            string result = "";
            for (int i = 0; i < rows; i++)
            {
                result += "| ";
                for (int j = 0; j < columns; j++)
                {
                    result += data[i, j].ToString() + " , ";
                }
                result = result.TrimEnd(' ', ',') + " |\n";
            }
            return result;
        }
    }
}
