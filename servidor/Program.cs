using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Text;
using System.Threading.Tasks;

namespace servidor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("servidor");

            TcpChannel canal = new TcpChannel(9998);
            ChannelServices.RegisterChannel(canal, false);
            Type tipoRemoto = typeof(Moneda);


            RemotingConfiguration.RegisterWellKnownServiceType(tipoRemoto, "MonedaService", WellKnownObjectMode.SingleCall);

            Console.WriteLine("Servicio en alto");
            Console.ReadLine();
        }
    }
}
