using ServiceClient.Services.Interfaces;

namespace ServiceClient.Client
{
    public class Client2
    {
        private IService2 _iService2;

        public Client2(IService2 iService2)
        {
            _iService2 = iService2;
            _iService2.Method2();
        }
    }
}