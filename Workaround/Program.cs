using Business.Concrete;
using Entities.Concrete;
using System;

namespace Workaround
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.FirstName = "Buket";
            person1.LastName = "Karaçaylı";
            person1.DateOfBirthYear = 1994;
            person1.NationalIdentity = 50452028152;
            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);
        }
    }

}
