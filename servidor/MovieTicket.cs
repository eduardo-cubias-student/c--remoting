using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Comun;

namespace servidor
{
    internal class MovieTicket : MarshalByRefObject, Comun.IMovieTicket
    {
        public static int numInstancias;

        public MovieTicket() {
            numInstancias++;
        }

        
        public string GetTicketStatus(string stringToPrint)
        {
            Console.WriteLine(stringToPrint);
            return $"Ticket Confirmado, Nº + {numInstancias}";
        }
    }
}
