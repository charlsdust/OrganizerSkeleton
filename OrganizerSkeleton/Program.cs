using OrganizerSkeleton.Rzeczy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizerSkeleton
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Ksiazka Bieguni = new Ksiazka() { Name = "Bieguni" , Author="Olga Tokarczuk", DataDodania=DateTime.Now, Cena=100.78m,Rating=5};
            Płyta BlackSabbath = new Płyta() { Name = "Black Sabbath", Author = "Black Sabbath", DataDodania = DateTime.Now, Cena = 49.90m, Rating = 5, Rodzaj = "Winyl" };
            Console.WriteLine(Bieguni.Name + " "+Bieguni.Author+" "+Bieguni.DataDodania +" "+ Bieguni.Cena+ " "+Bieguni.Rating);
            Console.WriteLine(BlackSabbath.Name+" "+BlackSabbath.Author+" "+BlackSabbath.DataDodania+" "+BlackSabbath.Cena+" "+BlackSabbath.Rating+" "+ BlackSabbath.Rodzaj);
            Console.ReadLine();
        }
    }
}
