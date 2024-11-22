namespace MatrixTools
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix<int> matrix = new(4, 3);
            matrix.Fill(12);
            Console.WriteLine(matrix.ToString());

            Matrix<int> matrix2 = new(4, 3);
            matrix2.Fill(1);
            Matrix<int> result = Matrix<int>.Add(matrix, matrix2);
            Console.WriteLine(result.ToString());

            matrix.RotateX();
            Console.WriteLine(matrix.ToString());

            matrix.RotateY();
            Console.WriteLine(matrix.ToString());
        }
    }
}
