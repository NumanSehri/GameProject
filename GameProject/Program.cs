using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new NewEStateUserValidationManager());
            gamerManager.Add(new Gamer { Id = 1, BirtYear = 1993, FirstName = "Numan", LastName = "ŞEHRİ", IdentityNumber = 12345 });
        }
    }
}
