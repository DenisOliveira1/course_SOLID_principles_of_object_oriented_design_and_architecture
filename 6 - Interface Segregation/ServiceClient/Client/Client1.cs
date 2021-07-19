using ServiceClient.Services.Interfaces;

namespace ServiceClient.Client
{
    public class Client1
    {
        private IService1 _iService1;

        public Client1(IService1 iService1)
        {
            _iService1 = iService1;
            _iService1.Method1();
        }
    }
}