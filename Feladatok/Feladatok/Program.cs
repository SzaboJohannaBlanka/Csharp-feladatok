namespace Feladatok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            Feladat1(); Console.WriteLine("\n-------------------------------------------------\n");
            Feladat2(); Console.WriteLine("\n-------------------------------------------------\n");
            Feladat3(); Console.WriteLine("\n-------------------------------------------------\n");
            Feladat4(); Console.WriteLine("\n-------------------------------------------------\n");
        }

        private static void Feladat4()
        {
            Console.WriteLine("4. Feladat:");
            Console.Write("Add meg a súlyodat (kg): ");
            double suly = double.Parse(Console.ReadLine());
            Console.Write("Add meg a magasságodat (cm): ");
            double Magassag = double.Parse(Console.ReadLine()) / 100;
            double Bmi = suly / (Magassag * Magassag);
            Console.WriteLine($"Testtömegindex: " + Bmi.ToString("0.00"));

            if (Bmi < 16)
            {
                Console.Write("Te súlyos soványságban szenvedsz!");
            }

        }

        private static void Feladat3()
        {
            Console.WriteLine("Feladat 3: Bevásárló kassza");

            Console.Write("Mennyi tejet szeretnél vásárolni?:");
            int Tej = int.Parse(Console.ReadLine());
            int TejOsszeg = 299;

            Console.Write("Mennyi zsemlét szeretnél vásárolni?:");
            int Zsemle = int.Parse(Console.ReadLine());
            int ZsemleOsszeg = 59;

            Console.Write("Mennyi túrósbatyút szeretnél vásárolni?:");
            int Turosbatyu = int.Parse(Console.ReadLine());
            int TurosbatyuOsszeg = 347;

            Console.Write("Mennyi rántotthúst szeretnél vásárolni?:");
            int Rantotthus = int.Parse(Console.ReadLine());
            int RantotthusOsszeg = 495;

            int Fizetendo = (Tej * TejOsszeg) + (Zsemle * ZsemleOsszeg) + (Turosbatyu * TurosbatyuOsszeg) + (Rantotthus * RantotthusOsszeg);
            Console.Write($"{Fizetendo} ft-ba kerül");

            int VasarloAdta = int.Parse(Console.ReadLine());
            //int Visszajaro1 = VasarloAdta % Fizetendo;
            int Visszajaro2 = VasarloAdta - Fizetendo;

            if (Visszajaro2 == 0)
            {
                Console.WriteLine("Ön pontosan fizetett, Köszönjük");
            }
            if (Visszajaro2 < 0)
            {
                Console.WriteLine($"Sajnos hiánya van, fizessen még: {Visszajaro2}");

            }

        }
        private static void Feladat2()
        {
            Console.WriteLine("Feladat 2: Hell vásárlás");
            Console.Write("Kérem adja meg, hány forintja van: ");
            int Penzem = int.Parse(Console.ReadLine());
            Console.Write("Mennyibe kerül egy doboz hell?: ");
            int HellAra = int.Parse(Console.ReadLine());
            int HellDb = Penzem / HellAra;
            Console.WriteLine($"Hány HELL-t tudok venni?: {HellDb}");
            //int Visszajaro = Penzem - HellAra * HellDb;
            int Visszajaro2 = Penzem % HellAra;
            //Console.WriteLine($"Mennyi lenne a visszajáró: {Visszajaro}");
            Console.WriteLine($"Ennyi lenne a visszajáró: {Visszajaro2}");
        }
        private static void Feladat1()
        {
            Console.WriteLine("Feladat 1: Kör területe, kerülete?");
            Console.Write("Kérem adja meg a kör sugarát számmal: ");
            double Sugar = double.Parse(Console.ReadLine());
            double KorTerulete = Math.Pow(Sugar, 2) * Math.PI;
            Console.WriteLine($"A kör területe: {KorTerulete}");
            double Pi = 3.14;
            double KorKerulet = 2 * Sugar * Pi;
            Console.WriteLine($"A kör kerülete: {KorKerulet}");
        }
    }
}