using ServiceClient.Client;
using ServiceClient.Services;

namespace ServiceClient
{
    class Program
    {
        static void Main(string[] args)
        {

            var service = new Service();

            new Client1(service);
            new Client2(service);

        }
    }
}
