using System;

namespace KalkulatorBMI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj swój wzrost (w metrach np 1.83): ");

            double wzrost = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Podaj swoją wagę: (82, jak do kilo)");

            double waga = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Wybierz płeć: (1 - mężczyzna 2 - kobieta) ");

            int plec = Convert.ToInt32(Console.ReadLine());

            if (wzrost <= 0 || waga <= 0)
            {
                Console.WriteLine("Podano niepoprawne dane!");
                return;
            }


            double bmi = waga / (wzrost * wzrost);
            Console.WriteLine($"Twoje BMI to: {bmi:F2}");

            if (plec == 1)
            {

                if (bmi < 18)
                {
                    Console.WriteLine("Masz niedowagę - Musisz więcej jeść zdrowo oraz ćwiczyć aby utrzymać masę");
                }
                else if (bmi > 18 && bmi < 25)
                {
                    Console.WriteLine("Twoja waga jest poprawna - Tak trzymaj");
                }
                else if (bmi > 25 && bmi < 30)
                {
                    Console.WriteLine("Masz nadwagę - Musisz trochę Schudnąć aby dociąć sylwetkę chyba że masujesz");
                }
                else if (bmi > 30)
                {
                    Console.WriteLine("Jesteś otyły - Zakończ tą masę bratku");
                }



            }

            if (plec == 2)
            {

                if (bmi < 19)
                {
                    Console.WriteLine("Masz niedowagę");
                }
                else if (bmi > 19 && bmi < 24)
                {
                    Console.WriteLine("Twoja waga jest poprawna");
                }
                else if (bmi > 24 && bmi < 29)
                {
                    Console.WriteLine("Masz nadwagę");
                }
                else if (bmi > 29)
                {
                    Console.WriteLine("Jesteś otyła");
                }

            }

            if (plec != 1 && plec != 2)
            {
                Console.WriteLine("Niepoprawny wybór płci!");
                return;
            }
            Console.WriteLine("\nDziękujemy za skorzystanie z kalkulatora BMI!");
            Console.ReadKey();

        }

    }
}