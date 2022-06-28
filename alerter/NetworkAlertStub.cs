using System;

namespace alerter
{
    class NetworkAlertStub : INetworkAlert
    {
        public int networkAlert(float celcius)
        {
            Console.WriteLine("ALERT: Temperature is {0} celcius", celcius);
            // Return 200 for ok
            // Return 500 for not-ok
            // stub always succeeds and returns 200
            if (celcius > 200)
                return 500;
            return 200;
        }
    }
}
