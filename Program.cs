namespace Lekcia6DU
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] pole1 = [5, 3, 1, 2, 4];

            int[] pole1x = null;
            Console.WriteLine("Pôvodné pole: [" + string.Join(", ", pole1) + "]");

            ZoradeniePola(pole1x);
            Console.WriteLine("Nové pole: [" + string.Join(", ", pole1) + "]");
        }

        public static void ZoradeniePola(int[] pole)
        {
            if (pole == null || pole.Length == 0)
            {
                Console.WriteLine("Zadal si neplatné hodnoty");
                return;
            }
            int dlzkaPola = pole.Length;
            for (int i = 0; i < dlzkaPola - 1; i++)
            {
                for (int j = 0; j < dlzkaPola - i - 1; j++)
                {
                    // Porovnanie susedných prvkov
                    if (pole[j] > pole[j + 1])
                    {
                        // Vymenenie prvkov, ak sú v zlom poradí
                        int vymenaPrvkov = pole[j];
                        pole[j] = pole[j + 1];
                        pole[j + 1] = vymenaPrvkov;
                    }
                }
            }
        }
    }
}
