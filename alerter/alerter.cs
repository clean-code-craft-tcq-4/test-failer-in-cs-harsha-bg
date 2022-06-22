using System;
using System.Diagnostics;

namespace AlerterSpace
{
    class Alerter
    {
        static int alertFailureCount = 0;
        static int networkAlertStub(float celcius)
        {
            Console.WriteLine("ALERT: Temperature is {0} celcius", celcius);
            // Return 200 for ok
            // Return 500 for not-ok
            // stub always succeeds and returns 200
            if (celcius > 200)
                return 500;
            return 200;
        }
        static void alertInCelcius(float farenheit)
        {
            float celcius = (farenheit - 32) * 5 / 9;
            int returnCode = networkAlertStub(celcius);
            if (returnCode != 200)
            {
                // non-ok response is not an error! Issues happen in life!
                // let us keep a count of failures to report
                // However, this code doesn't count failures!
                // Add a test below to catch this bug. Alter the stub above, if needed.
                alertFailureCount += 0;
            }
        }
        static void Main(string[] args)
        {
            AlertTestMethod();
            NonAlertTestMethod();

            Console.WriteLine("{0} alerts failed.", alertFailureCount);
            Console.WriteLine("All is well (maybe!)\n");
        }

        private static void NonAlertTestMethod()
        {
            float farenheit = 303.6f;
            alertInCelcius(farenheit);
            AssertFailureStatus(false);
        }

        private static void AlertTestMethod()
        {
            float farenheit = 400.5f;
            alertInCelcius(farenheit);
            AssertFailureStatus(true);
        }

        public static void AssertFailureStatus(bool IsFailureExpected)
        {
            if (alertFailureCount == 0 && !IsFailureExpected)
                Debug.Assert(true);
            else
                Debug.Assert(false);
        }
    }
}
