using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizerSkeleton.Rzeczy
{
    interface IRzecz
    {
        string Name { set; get; }
        string Author { set; get; }
        DateTime DataDodania { get; set; }
        decimal Cena { get; set; }
        byte Rating { get; set; }

    }
}
