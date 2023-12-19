using System;

namespace CsharpAdvanced // Tiroir
{
    struct user // Structure
    {
        public int age;
        public string nom;

        public user(int a, string n)  // constructeur
        {
            age = a;
            nom = n;
        }

        public int DoubleAge() // Fonction
        { 
            return age*2 ; 
        } 

    }

    internal class Program
    {
        public static user u1 = new user(15, "Tutu");
        public static user u2 = new user(35, "Tata");
        public static user u3 = new user(56, "Titi");

        static void Main(string[] args)
        {
            Console.WriteLine("User_1, {0}, bla bla {1}", u1.nom, u1.age);
            Console.WriteLine("User_2, {0}, bla bla {1}", u2.nom, u2.age);
            Console.WriteLine("User_3, {0}, bla bla {1}", u3.nom, u3.age);
            Console.WriteLine("User_3, Age x 2 = {0}", u3.DoubleAge());
        }
    }
}