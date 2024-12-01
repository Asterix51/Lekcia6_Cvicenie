using System.Security.Cryptography.X509Certificates;

namespace Lekcia6_Cvicenie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] pole1 = [5, 3, 1, 2, 4];

            int[] pole1x = null;
            Console.WriteLine("Pôvodné pole: [" + string.Join(", ", pole1) + "]");

            int[] zoradenePole = ZoradeniePola(pole1);
            Console.WriteLine("Nové pole zoradené: [" + string.Join(", ", zoradenePole) + "]");

            int[] obratenePole = obratitPole(pole1);
            Console.WriteLine("Nové pole obrátené: [" + string.Join(", ", obratenePole) + "]");

            int[] odstraneniePrvehoPrvku = odstraniePrvehoPrvku(pole1, 2);
            Console.WriteLine("Nové pole obrátené: [" + string.Join(", ", odstraneniePrvehoPrvku) + "]");
        }

        public static int[] ZoradeniePola(int[] pole)
        {
            if (pole == null || pole.Length == 0)
            {
                Console.WriteLine("Zadal si neplatné hodnoty");
                return new int[0];
            }
            int dlzkaPola = pole.Length;
            int[] zoradenePole = new int[dlzkaPola];
            Array.Copy(pole, zoradenePole, dlzkaPola);
            for (int i = 0; i < dlzkaPola - 1; i++)
            {
                for (int j = 0; j < dlzkaPola - i - 1; j++)
                {
                    // Porovnanie susedných prvkov
                    if (zoradenePole[j] > zoradenePole[j + 1])
                    {
                        // Vymenenie prvkov, ak sú v zlom poradí
                        int vymenaPrvkov = zoradenePole[j];
                        zoradenePole[j] = zoradenePole[j + 1];
                        zoradenePole[j + 1] = vymenaPrvkov;
                    }
                }
            }
            return zoradenePole;
        }
        public static int[] obratitPole(int[] pole)
        {
            if (pole == null || pole.Length == 0)
            {
                Console.WriteLine("Zadal si neplatné hodnoty");
                return new int[0];
            }
            int dlzkaPola = pole.Length;
            int[] obratenePole = new int[dlzkaPola];
            for (int i = 0;i < dlzkaPola; i++)
            {
                // Výmena prvkov prvý sa vymení s posledným
                obratenePole[i] = pole[dlzkaPola - i - 1];
            }
            return obratenePole;
        }

        public static int[] odstraniePrvehoPrvku(int[] pole, int index)
        {
            if (pole == null || pole.Length == 0)
            {
                Console.WriteLine("Zadal si neplatné hodnoty");
                return new int[0];
            }
            else if (index < 0 || index >= pole.Length)
            {
                Console.WriteLine("Index je mimo rozsahu. Vraciam pôvodné pole");
                return pole;
            }
            int dlzkaPola = pole.Length;
            int[] novePole = new int[pole.Length - 1];
            int indexNovePole = 0;
            for (int i = 0; i < dlzkaPola; i++)
            {
                if (i != index)
                {
                    novePole[indexNovePole] = pole[i];
                    indexNovePole++;
                }
            }
                return novePole;
        }
    }
}
