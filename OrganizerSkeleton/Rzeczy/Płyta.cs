using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizerSkeleton.Rzeczy
{
    class Płyta : IRzecz
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public DateTime DataDodania { get; set; }
        public decimal Cena { get; set; }
        public byte Rating { get; set; }
        public string Rodzaj { get; set; }
    }
}
