using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odata_client_test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OdataClient client = new OdataClient();
            client.SendRequestTest();

            Console.ReadLine();
        }
    }
}
