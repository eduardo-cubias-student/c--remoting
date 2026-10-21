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
            Type tipoRemoto = typeof(IMoneda);

            IMoneda objetoRemoto = (IMoneda)Activator.GetObject(tipoRemoto,
                "tcp://localhost:9998/MonedaService");
            double resultadoEuros = objetoRemoto.Convertir(TipoMoneda.EuroDolar, 12.3);
            Console.WriteLine("De dolares a euros");
            Console.WriteLine(resultadoEuros);
            double resultadoDolares = objetoRemoto.Convertir(TipoMoneda.DolarEuro, 20.4);
            Console.WriteLine("De euros a dolares");
            Console.WriteLine(resultadoDolares);
            Console.Read();

        }
    }
}
