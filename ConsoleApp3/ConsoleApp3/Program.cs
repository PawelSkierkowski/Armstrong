using Amstrong.Human;
using System;

namespace ConsoleApp3
{

    class Program
    {
        static void Main(string[] args)
        {
            var ageService = new AgeService();
            var decadeService = new DecadeService();

            var human = new Human();

            var worker = new Worker();

            var client = new Client();
            client.Name = "Paweł";
            client.Surname = "Kowalski";
            client.BirthDate = new DateTime(1990, 1, 3);
            client.TaxNumber = "1234354345";


            var age = ageService.CalculateAge(client);
            var decades = decadeService.CalculateDecade(age);
              


            //var result = IsAmstrong(0); // 407, 153
        }
    }
}
