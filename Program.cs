using System.Security.Cryptography.X509Certificates;

namespace Lekcia6_Cvicenie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] pole12 = [5, 3, 1, 2, 4];

            int[] pole1 = null;
            //Console.WriteLine("Pôvodné pole: [" + string.Join(", ", pole1) + "]");

            int[] zoradenePole = ZoradeniePola(pole1);
            Console.WriteLine("Nové pole zoradené: [" + string.Join(", ", zoradenePole) + "]");

            int[] obratenePole = obratitPole(pole1);
            Console.WriteLine("Nové pole obrátené: [" + string.Join(", ", obratenePole) + "]");

            int[] odstraneniePrvehoElementu = odstraneniePrvehoPrvku(pole1);
            Console.WriteLine("Nové pole odstánený prvý element: [" + string.Join(", ", odstraneniePrvehoElementu) + "]");
            
            int[] odstraneniePoslednehoElementu = odstraneniePoslednehoPrvku(pole1);
            Console.WriteLine("Nové pole odstránený posledný element: [" + string.Join(", ", odstraneniePoslednehoElementu) + "]");

            int[] odstranenieZadanehoElementu = odstranenieZadanehoPrvku(pole1,2);
            Console.WriteLine("Nové pole odstránený posledný element: [" + string.Join(", ", odstranenieZadanehoElementu) + "]");

            int[] novyPrvokNaZaciatku = PriradeniePrvkuNaZaciatok(pole1);
            Console.WriteLine("Nové pole pridaný nový element na začiatku: [" + string.Join(", ", novyPrvokNaZaciatku) + "]");
            
            int[] novyPrvokNaKonci = PriradeniePrvkuNaKoniec(pole1);
            Console.WriteLine("Nové pole pridaný nový element na koniec: [" + string.Join(", ", novyPrvokNaKonci) + "]");            
            
            int[] novyPrvokLubovolne = PriradeniePrvkuNaLubovolne(pole1,2);
            Console.WriteLine("Nové pole pridaný nový element na ľubovolnú pozíciu: [" + string.Join(", ", novyPrvokLubovolne) + "]");

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
                    if (zoradenePole[j] > zoradenePole[j + 1])
                    {
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
                return new int [0];
            }
            int dlzkaPola = pole.Length;
            int[] obratenePole = new int[dlzkaPola];
            for (int i = 0;i < dlzkaPola; i++)
            {
                obratenePole[i] = pole[dlzkaPola - i - 1];
            }
            return obratenePole;
        }

        public static int[] odstraneniePrvehoPrvku(int[] pole)
        {
            if (pole == null || pole.Length == 0)
            {
                Console.WriteLine("Zadal si neplatné hodnoty");
                return new int[0];
            }
            int dlzkaPola = pole.Length;
            int[] novePole = new int[pole.Length - 1];
            int indexNovePole = 0;
            for (int i = 1; i < dlzkaPola; i++)
            {
                novePole[indexNovePole] = pole[i];
                indexNovePole++;
            }
                return novePole;
        }

        public static int[] odstraneniePoslednehoPrvku(int[] pole)
        {
            if (pole == null || pole.Length == 0)
            {
                Console.WriteLine("Zadal si neplatné hodnoty");
                return new int[0];
            }
            int dlzkaPola = pole.Length;
            int[] novePole = new int[pole.Length - 1];
            int indexNovePole = 0;
            for (int i = 0; i < dlzkaPola-1; i++)
            {
                novePole[indexNovePole] = pole[i];
                indexNovePole++;
            }
            return novePole;
        }

        public static int[] odstranenieZadanehoPrvku(int[] pole, int index)
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

        public static int[] PriradeniePrvkuNaZaciatok(int[] pole)
        {
            if (pole == null || pole.Length == 0)
            {
                Console.WriteLine("Pole je null alebo je prázne");
                return new int[] { 0 };
            }

            int dlzkaPola = pole.Length;
            int[] novePole = new int[pole.Length + 1];
            novePole[0] = 0;
            for (int i = 1, j = 0; i < novePole.Length; i++)
            {

                novePole[i] = pole[j];
                j++;

            }
            return novePole;
        }

        public static int[] PriradeniePrvkuNaKoniec(int[] pole)
        {
            if (pole == null || pole.Length == 0)
            {
                Console.WriteLine("Pole je null alebo je prázne");
                return new int[] { 0 };
            }

            int dlzkaPola = pole.Length;
            int[] novePole = new int[pole.Length + 1];
            novePole[dlzkaPola] = 0;
            for (int i = 0, j = 0; i < dlzkaPola; i++)
            {
                novePole[i] = pole[j];
                j++;
            }
            return novePole;
        }

        public static int[] PriradeniePrvkuNaLubovolne(int[] pole, int index)
        {
            if (pole == null || pole.Length == 0)
            {
                Console.WriteLine("Pole je null alebo je prázne");
                return new int[] { 0 };
            }
            else if (index < 0 || index >= pole.Length)
            {
                Console.WriteLine("Index je mimo rozsahu. Vraciam pôvodné pole");
                return pole;
            }
            int dlzkaPola = pole.Length;
            int[] novePole = new int[pole.Length + 1];
            for (int i = 0, j = 0; i < novePole.Length; i++)
            {
                if (i == index)
                {
                    novePole[i] = 0;
                }
                else
                {
                    novePole[i] = pole[j];
                    j++;
                }
            }
            return novePole;
        }
    }
}
