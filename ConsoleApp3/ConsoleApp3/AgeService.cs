using Amstrong.Human;
using System;

namespace ConsoleApp3
{
    public class AgeService
    { 
        bool IsAmstrong(int initial)
        {
            var armStrong = CountAmstrong(initial);
            return initial == armStrong;
        }

        int CountAmstrong(int initialNumber, int curr = 0)
        {
            var moduloRes = initialNumber % 10;
            var modRes = moduloRes * moduloRes * moduloRes;

            if (initialNumber > 0)
            {
                return CountAmstrong(initialNumber / 10, curr + modRes);
            }

            return curr;
        }

        public int CalculateAge()
        {
            var costam = "costam1";
            Console.WriteLine($"Podaj datę urodzenia {costam}");
            var inputDate = Console.ReadLine();

            DateTime data;

            var result = DateTime.TryParse(inputDate, out data);
            Int32.TryParse(inputDate, out int age);

            if (result)
            {
                var dateNow = DateTime.Now.Date;
                if (data > dateNow)
                {
                    Console.WriteLine($"Podałeś chujową datę {data}");
                    return CalculateAge();
                }
                else
                {
                    Console.WriteLine($"Podałeś poprawną datę {data}");

                    DateTime zeroTime = new DateTime(1, 1, 1);
                    TimeSpan span = dateNow - data;
                    // Because we start at year 1 for the Gregorian
                    // calendar, we must subtract a year here.
                    int years = (zeroTime + span).Year - 1;

                    // 1, where my other algorithm resulted in 0.
                    Console.WriteLine("Yrs elapsed: " + years);

                    return years;
                }

            }
            else
            {
                Console.WriteLine("Wartość nieprawidłowa. Spróbuj jeszcze raz.");
                return CalculateAge();
            }
        }

        public int CalculateAge(int liczba)
        {
            return CalculateAge() + liczba;
        }

        public int CalculateAge(int liczba, int liczba2)
        {
            return CalculateAge() + liczba + liczba2;
        }

        public int CalculateAge(Client client)
        {
            return CalculateAge() + client.BirthDate.Year;
        }
    }
}
