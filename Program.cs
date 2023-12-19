using System;

namespace CsharpAdvanced // Tiroir
{
    enum plan // Enumeration
    {
        Free,       // 0
        Bronze,     // 1
        Silver,     // 2 
        Gold,       // 3
        Diamond     // 4
    }

    struct user // Structure
    {
        public int age;
        public string nom;
        public plan p;

        public user(int a, string n, plan pl)  // constructeur
        {
            age = a;
            nom = n;
            p = pl;
        }

        public int DoubleAge() // Fonction
        { 
            return age*2 ; 
        }

        public bool HasAccess()
        {
            return (int)p > 0; // autrement codé : if ((int)p > 0) {return true;} else return false;
        }
    }

    internal class Program
    {
        public static user u1 = new user(15, "Tutu", plan.Free);
        public static user u2 = new user(35, "Tata", plan.Gold);
        public static user u3 = new user(56, "Titi", plan.Silver);
        public static plan p1 = plan.Diamond;

        static void Main(string[] args)
        {
            Console.WriteLine("U1 accès = {0}", u1.HasAccess());
            Console.WriteLine("U2 accès = {0}", u2.HasAccess());
            Console.WriteLine("Plan = {0}", p1); // pour le caster et voir "4" ==> (int)p1
            Console.WriteLine("User_1, {0}, bla bla {1}", u1.nom, u1.age);
            Console.WriteLine("User_2, {0}, bla bla {1}", u2.nom, u2.age);
            Console.WriteLine("User_3, {0}, bla bla {1}", u3.nom, u3.age);
            Console.WriteLine("User_3, Age x 2 = {0}", u3.DoubleAge());
        }
    }
}