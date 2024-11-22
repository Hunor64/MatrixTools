namespace MatrixTools
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix<int> matrix = new Matrix<int>(4, 3);
            matrix.Fill(12);
            Console.WriteLine(matrix.ToString());

            Matrix<int> matrix2 = new Matrix<int>(4, 3);
            matrix2.Fill(1);
            Matrix<int> result = Matrix<int>.Add(matrix, matrix2);
            Console.WriteLine(result.ToString());

            matrix.RotateX();
            Console.WriteLine(matrix.ToString());

            matrix.RotateY();
            matrix.RotateY();
            Console.WriteLine(matrix.ToString());
        }
    }
}