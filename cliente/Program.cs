using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Text;
using System.Threading.Tasks;
using Comun;

namespace cliente
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("cliente");
            TcpChannel canal = new TcpChannel();
            ChannelServices.RegisterChannel(canal, false);
            Type tipoRemoto = typeof(IMovieTicket);

            IMovieTicket objetoRemoto = (IMovieTicket)Activator.GetObject(tipoRemoto,
                "tcp://localhost:9998/MovieTicketService");
            string resultado = objetoRemoto.GetTicketStatus("Ticket N1212");
            Console.WriteLine(resultado);
            Console.Read();

        }
    }
}
