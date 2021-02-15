using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManeManager = new GamerManager(new UserValidationManager());
            gamerManeManager.Add(new Gamer{Id = 1,BirtYear = 1985,FirstName = "Engin",LastName = "Demiroğ", IdentityNumber = 12345});
            Console.ReadLine();
        }
    }
}
