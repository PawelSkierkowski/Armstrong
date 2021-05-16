using System;

namespace Amstrong.Human
{
    public class Human
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public DateTime BirthDate { get; set; }
    }


    public class Worker: Human
    {
        public string Pesel { get; set; }
    }

    public class Client: Human
    {
        public string TaxNumber { get; set; }
    }
}
