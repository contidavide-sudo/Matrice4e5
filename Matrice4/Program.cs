namespace Matrice4
{
    internal class Program
    {
        static void Stampa(int[,] m, int[,] m1)
        {
            for(int i=0; i<m.GetLength(0); i++)
            {
                for(int j=0; j < m.GetLength(1); j++)
                {
                    Console.Write($"[{m[i, j]}]");
                }

                Console.WriteLine();
            }

            Console.WriteLine();

            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    Console.Write($"[{m1[i, j]}]");
                }

                Console.WriteLine();
            }
        }

        static int[,] Trasporta(int[,] m, int[,] m1)
        {
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    m1[j, i] = m[i, j];
                }
                
            }

            return m1;
        }
        static void Main(string[] args)
        {
            int[,] m = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            int[,] m1 = new int[m.GetLength(0), m.GetLength(1)];

            Stampa(m, m1);

            Console.WriteLine();

            m1 = Trasporta(m, m1);

            Stampa(m, m1);
        }
    }
}
