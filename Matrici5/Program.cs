namespace Matrice4
{
    internal class Program
    {
        static void Stampa(int[,] m)
        {
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    Console.Write($"[{m[i, j]}]");
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
                    if (m.GetLength(0) == m1.GetLength(1))
                    {
                        m1[j, i] = m[i, j];
                    }
                }

            }

            return m1;
        }
        static void Main(string[] args)
        {
            int[,] m = { { 1, 2 }, { 3, 4 }, { 6, 7 } };
            int[,] m1 = new int[m.GetLength(1), m.GetLength(0)];

            Stampa(m);

            Console.WriteLine();

            Stampa(Trasporta(m, m1));
        }
    }
}

