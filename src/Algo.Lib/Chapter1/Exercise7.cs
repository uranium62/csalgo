namespace Algo.Lib.Chapter1
{
    public class Exercise7
    {
        public static void Zero(int[,] matrix, int n, int m)
        {
            bool[] rows = new bool[n];
            bool[] cols = new bool[m];

            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    if (matrix[i, j] == 0)
                    {
                        rows[i] = true;
                        cols[j] = true;
                    }

            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    if (rows[i] || cols[j]) matrix[i, j] = 0; 
        } 
    }
}
