using NUnit.Framework;

namespace alerter
{
    public class TestMethod
    {
        static AlerterMethods networkAlertobj;
        public static void NonAlertTestMethod()
        {
            float farenheit = 303.6f;
            networkAlertobj = new AlerterMethods(new NetworkAlertStub());
            networkAlertobj.alertInCelcius(farenheit);
            int failureCount = networkAlertobj.alertFailureCount;
            Assert.AreEqual(failureCount, 0);
        }

        public static void AlertTestMethod()
        {
            float farenheit = 400.5f;
            networkAlertobj = new AlerterMethods(new NetworkAlert());
            networkAlertobj.alertInCelcius(farenheit);
            int failureCount = networkAlertobj.alertFailureCount;
            Assert.AreEqual(failureCount, 1);
        }
    }
}
